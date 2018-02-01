#!/usr/bin/env python

# -*- coding: utf-8 -*-

import MySQLdb as mdb
import serial
from datetime import datetime
import time

runOnce = False

arduino = serial.Serial("/dev/ttyACM0")
arduino.baudrate=9600
connection = mdb.connect('localhost','root','root','weatherLog')

while 1 :

	if runOnce is False :

		for x in range(0,4) :

			data = arduino.readline()

	# Mittaustulosten vakauttamiseksi täytyy data mitata kaksi kertaa
	data = arduino.readline()
	data = arduino.readline()

	pieces = data.split("\t") 		# Jaa data kahteen osaan, erottimena yksi tabin lyönti

	try :
		temperature = pieces[0] 	# Lämpötila, datan ensimmäinen osa
		humidity = pieces[1] 		# Kosteus, toinen osa

	except IndexError:
		pass 						# Vältetään koodin kaatuminen, jos dataa ei kerran ilmesty

	if data :

		with connection:

			cursor=connection.cursor()

			if runOnce is False :

				cursor.execute("SELECT DATE_FORMAT(date, '%Y-%m-%d') FROM historyLog WHERE id = (SELECT MAX(id) FROM historyLog)")
				dateFetch = cursor.fetchone() 			# Noudetaan viimeisin päivämäärä historyLog taulusta
				oldDate = str(dateFetch[0]) 			# Määritellään oldDate myöhempää vertailua varten

				cursor.execute("SELECT MAX(id) FROM historyLog")
				maxId = cursor.fetchone() 				# Noudetaan suurin id luku historyLog taulusta
				dateId = maxId[0] 						# dateId täytyy määritellä käytettäväksi mySql-koodissa

				if dateId == 0 :

					dateId = 1
					runOnce = True

			cursor.execute("SELECT CURDATE()")
			newDateFetch = cursor.fetchone()
			newDate = str(newDateFetch[0]) 				# Määritellään newDate vertailtavaksi oldDaten kanssa

			if newDate != oldDate : 					# Vertaillaan tietokannan viimeisintä ja tämänhetkistä päivää

				dateId = dateId + 1

			oldDate = newDate 							# Päivitetään oldDate vastaamaan tätä päivää vertailun jälkeen

			# Rajataan dataLog-taulu sisältämään vain 10 riviä tietoa kerrallaan ja lisätään viimeisin mittaustulos
			cursor.execute("DELETE FROM dataLog WHERE id NOT IN (SELECT id FROM (SELECT id FROM dataLog ORDER BY id DESC LIMIT 10)foo)")
			cursor.execute("INSERT INTO dataLog (date,temperature,humidity) VALUES(NOW(),%s,%s)",(temperature ,humidity))

			# historyLog-tauluun lisätään uusi rivi, jos se on päivän ensimmäinen. Muuten päivitetään tiedot tarvittaessa
			cursor.execute("""INSERT INTO historyLog (id, date, temperature_min, temperature_max, humidity_min, humidity_max)
							VALUES (%s, CURDATE(), %s, %s, %s, %s)
							ON DUPLICATE KEY UPDATE
							temperature_min = LEAST(temperature_min, VALUES(temperature_min)),										
							temperature_max = GREATEST(temperature_max, VALUES(temperature_max)),
							humidity_min = LEAST(humidity_min, VALUES(humidity_min)),
							humidity_max = GREATEST(humidity_max, VALUES(humidity_max))""", (dateId, temperature, temperature, humidity, humidity))

			connection.commit()
			print "Temperature: %s and Humidity: %s" % (temperature, humidity)
			cursor.close()