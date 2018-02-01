#include <DallasTemperature.h>
#include <OneWire.h>
#define ONE_WIRE_BUS 2

const int pwm = 5;
const int aIn = A0;
const float tempIn = 7;

boolean firstValReaded = false;

int laskuri = 0;
int taulukko[25];
int i;
int ad[4] = {1019, 424, 360, 284}; //kosteusmittarilla kalibroidut anturiarvot
int kost[4] = {19, 55, 70, 84}; //anturiarvoja vastaavat kosteusarvot

OneWire oneWire(ONE_WIRE_BUS);

DallasTemperature sensors(&oneWire);

float arvo = 0;
int maxval = 0;
float kosteus;

void setup() {
  // put your setup code here, to run once:
  analogWrite(pwm, 128);
  Serial.begin(9600);
  sensors.begin();

}

void loop() {
  // put your main code here, to run repeatedly:

  int sensoriArvo = analogRead(aIn);
  float temp = digitalRead(tempIn);
  taulukko[laskuri] = (double)sensoriArvo;
  laskuri++;
  float temperature = sensors.getTempCByIndex(0);

  if (laskuri == 25)
  {
    if (firstValReaded)
    {
      sensors.requestTemperatures();
      Serial.print(temperature);
      Serial.print("\t");
      Serial.print(kosteus);
      Serial.println("\t");
    }

    maxval = taulukko[0];

    for (i = 0; i < 25; i++)
    {
      if (maxval < taulukko[i + 1]) maxval = taulukko[i + 1];
    }
    arvo = maxval;
    laskuri = 0;
    firstValReaded = true;
  }

  if (arvo >= ad[0]) {
    kosteus = kost[0] - (kost[0] - 0) * (arvo - ad[0]) / (1023 - ad[0]);
  }
  else if (arvo < ad[0] && arvo >= ad[1]) {
    kosteus = kost[1] - (kost[1] - kost[0]) * (arvo - ad[1]) / (ad[0] - ad[1]);
  }
  else if (arvo < ad[1] && arvo >= ad[2]) {
    kosteus = kost[2] - (kost[2] - kost[1]) * (arvo - ad[2]) / (ad[1] - ad[2]);
  }
  else if (arvo < ad[2] && arvo >= ad[3]) {
    kosteus = kost[3] - (kost[3] - kost[2]) * (arvo - ad[3]) / (ad[2] - ad[3]);
  }
  else kosteus = 100 - (100 - kost[3]) * (arvo - 0) / (ad[3] - 0);
}




