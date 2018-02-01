namespace EmbeddedSystemProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelTempTxt = new System.Windows.Forms.Label();
            this.labelHumidTxt = new System.Windows.Forms.Label();
            this.labelTempValue = new System.Windows.Forms.Label();
            this.labelHumidValue = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.aGaugeTemp = new System.Windows.Forms.AGauge();
            this.aGaugeHumid = new System.Windows.Forms.AGauge();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartLiveData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chartHumHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chartTempHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLiveData)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHumHistory)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTempHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTempTxt
            // 
            this.labelTempTxt.AutoSize = true;
            this.labelTempTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempTxt.Location = new System.Drawing.Point(130, 268);
            this.labelTempTxt.Name = "labelTempTxt";
            this.labelTempTxt.Size = new System.Drawing.Size(101, 17);
            this.labelTempTxt.TabIndex = 4;
            this.labelTempTxt.Text = "Temperature";
            // 
            // labelHumidTxt
            // 
            this.labelHumidTxt.AutoSize = true;
            this.labelHumidTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidTxt.Location = new System.Drawing.Point(499, 268);
            this.labelHumidTxt.Name = "labelHumidTxt";
            this.labelHumidTxt.Size = new System.Drawing.Size(70, 17);
            this.labelHumidTxt.TabIndex = 5;
            this.labelHumidTxt.Text = "Humidity";
            this.labelHumidTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTempValue
            // 
            this.labelTempValue.AutoSize = true;
            this.labelTempValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempValue.Location = new System.Drawing.Point(139, 248);
            this.labelTempValue.Name = "labelTempValue";
            this.labelTempValue.Size = new System.Drawing.Size(27, 20);
            this.labelTempValue.TabIndex = 6;
            this.labelTempValue.Text = "°C";
            // 
            // labelHumidValue
            // 
            this.labelHumidValue.AutoSize = true;
            this.labelHumidValue.BackColor = System.Drawing.Color.Transparent;
            this.labelHumidValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidValue.Location = new System.Drawing.Point(498, 248);
            this.labelHumidValue.Name = "labelHumidValue";
            this.labelHumidValue.Size = new System.Drawing.Size(24, 20);
            this.labelHumidValue.TabIndex = 7;
            this.labelHumidValue.Text = "%";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(749, 443);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.labelTempValue);
            this.tabPage1.Controls.Add(this.labelHumidValue);
            this.tabPage1.Controls.Add(this.labelTempTxt);
            this.tabPage1.Controls.Add(this.labelHumidTxt);
            this.tabPage1.Controls.Add(this.aGaugeTemp);
            this.tabPage1.Controls.Add(this.aGaugeHumid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(741, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Real-Time Gauges";
            // 
            // aGaugeTemp
            // 
            this.aGaugeTemp.BaseArcColor = System.Drawing.Color.Brown;
            this.aGaugeTemp.BaseArcRadius = 80;
            this.aGaugeTemp.BaseArcStart = 135;
            this.aGaugeTemp.BaseArcSweep = 270;
            this.aGaugeTemp.BaseArcWidth = 2;
            this.aGaugeTemp.Center = new System.Drawing.Point(100, 100);
            this.aGaugeTemp.Location = new System.Drawing.Point(75, 80);
            this.aGaugeTemp.Margin = new System.Windows.Forms.Padding(2);
            this.aGaugeTemp.MaxValue = 70F;
            this.aGaugeTemp.MinValue = -20F;
            this.aGaugeTemp.Name = "aGaugeTemp";
            this.aGaugeTemp.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.aGaugeTemp.NeedleColor2 = System.Drawing.Color.DarkRed;
            this.aGaugeTemp.NeedleRadius = 80;
            this.aGaugeTemp.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGaugeTemp.NeedleWidth = 5;
            this.aGaugeTemp.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGaugeTemp.ScaleLinesInterInnerRadius = 73;
            this.aGaugeTemp.ScaleLinesInterOuterRadius = 80;
            this.aGaugeTemp.ScaleLinesInterWidth = 1;
            this.aGaugeTemp.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGaugeTemp.ScaleLinesMajorInnerRadius = 73;
            this.aGaugeTemp.ScaleLinesMajorOuterRadius = 80;
            this.aGaugeTemp.ScaleLinesMajorStepValue = 5F;
            this.aGaugeTemp.ScaleLinesMajorWidth = 2;
            this.aGaugeTemp.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGaugeTemp.ScaleLinesMinorInnerRadius = 75;
            this.aGaugeTemp.ScaleLinesMinorOuterRadius = 80;
            this.aGaugeTemp.ScaleLinesMinorTicks = 9;
            this.aGaugeTemp.ScaleLinesMinorWidth = 1;
            this.aGaugeTemp.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGaugeTemp.ScaleNumbersFormat = null;
            this.aGaugeTemp.ScaleNumbersRadius = 93;
            this.aGaugeTemp.ScaleNumbersRotation = 0;
            this.aGaugeTemp.ScaleNumbersStartScaleLine = 0;
            this.aGaugeTemp.ScaleNumbersStepScaleLines = 1;
            this.aGaugeTemp.Size = new System.Drawing.Size(210, 192);
            this.aGaugeTemp.TabIndex = 2;
            this.aGaugeTemp.Text = "aGauge1";
            this.aGaugeTemp.Value = 0F;
            // 
            // aGaugeHumid
            // 
            this.aGaugeHumid.BaseArcColor = System.Drawing.Color.MidnightBlue;
            this.aGaugeHumid.BaseArcRadius = 80;
            this.aGaugeHumid.BaseArcStart = 135;
            this.aGaugeHumid.BaseArcSweep = 270;
            this.aGaugeHumid.BaseArcWidth = 2;
            this.aGaugeHumid.Center = new System.Drawing.Point(100, 100);
            this.aGaugeHumid.Location = new System.Drawing.Point(438, 80);
            this.aGaugeHumid.Margin = new System.Windows.Forms.Padding(2);
            this.aGaugeHumid.MaxValue = 100F;
            this.aGaugeHumid.MinValue = 0F;
            this.aGaugeHumid.Name = "aGaugeHumid";
            this.aGaugeHumid.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Blue;
            this.aGaugeHumid.NeedleColor2 = System.Drawing.Color.MidnightBlue;
            this.aGaugeHumid.NeedleRadius = 80;
            this.aGaugeHumid.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGaugeHumid.NeedleWidth = 5;
            this.aGaugeHumid.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGaugeHumid.ScaleLinesInterInnerRadius = 73;
            this.aGaugeHumid.ScaleLinesInterOuterRadius = 80;
            this.aGaugeHumid.ScaleLinesInterWidth = 1;
            this.aGaugeHumid.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGaugeHumid.ScaleLinesMajorInnerRadius = 70;
            this.aGaugeHumid.ScaleLinesMajorOuterRadius = 80;
            this.aGaugeHumid.ScaleLinesMajorStepValue = 20F;
            this.aGaugeHumid.ScaleLinesMajorWidth = 2;
            this.aGaugeHumid.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGaugeHumid.ScaleLinesMinorInnerRadius = 75;
            this.aGaugeHumid.ScaleLinesMinorOuterRadius = 80;
            this.aGaugeHumid.ScaleLinesMinorTicks = 9;
            this.aGaugeHumid.ScaleLinesMinorWidth = 1;
            this.aGaugeHumid.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGaugeHumid.ScaleNumbersFormat = null;
            this.aGaugeHumid.ScaleNumbersRadius = 95;
            this.aGaugeHumid.ScaleNumbersRotation = 0;
            this.aGaugeHumid.ScaleNumbersStartScaleLine = 0;
            this.aGaugeHumid.ScaleNumbersStepScaleLines = 1;
            this.aGaugeHumid.Size = new System.Drawing.Size(199, 205);
            this.aGaugeHumid.TabIndex = 3;
            this.aGaugeHumid.Text = "aGauge2";
            this.aGaugeHumid.Value = 0F;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartLiveData);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(741, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Live Chart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartLiveData
            // 
            chartArea1.AxisY.Title = "Temperature °C, Humidity %";
            chartArea1.Name = "ChartArea1";
            this.chartLiveData.ChartAreas.Add(chartArea1);
            this.chartLiveData.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chartLiveData.Legends.Add(legend1);
            this.chartLiveData.Location = new System.Drawing.Point(0, 0);
            this.chartLiveData.Name = "chartLiveData";
            this.chartLiveData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Humidity";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Temperature";
            this.chartLiveData.Series.Add(series1);
            this.chartLiveData.Series.Add(series2);
            this.chartLiveData.Size = new System.Drawing.Size(697, 397);
            this.chartLiveData.TabIndex = 0;
            this.chartLiveData.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartHumHistory);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(741, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Humidity History Chart";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartHumHistory
            // 
            chartArea2.Name = "ChartArea1";
            this.chartHumHistory.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartHumHistory.Legends.Add(legend2);
            this.chartHumHistory.Location = new System.Drawing.Point(0, 0);
            this.chartHumHistory.Name = "chartHumHistory";
            series3.ChartArea = "ChartArea1";
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Min Humidity";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.ChartArea = "ChartArea1";
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.Name = "Max Humidity";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chartHumHistory.Series.Add(series3);
            this.chartHumHistory.Series.Add(series4);
            this.chartHumHistory.Size = new System.Drawing.Size(697, 397);
            this.chartHumHistory.TabIndex = 0;
            this.chartHumHistory.Text = "chart1";
            this.chartHumHistory.Click += new System.EventHandler(this.chartHumHistory_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chartTempHistory);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(741, 417);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Temperature History Chart";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chartTempHistory
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTempHistory.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTempHistory.Legends.Add(legend3);
            this.chartTempHistory.Location = new System.Drawing.Point(0, 0);
            this.chartTempHistory.Name = "chartTempHistory";
            series5.ChartArea = "ChartArea1";
            series5.IsXValueIndexed = true;
            series5.Legend = "Legend1";
            series5.Name = "Min Temperature";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series6.ChartArea = "ChartArea1";
            series6.IsXValueIndexed = true;
            series6.Legend = "Legend1";
            series6.Name = "Max Temperature";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chartTempHistory.Series.Add(series5);
            this.chartTempHistory.Series.Add(series6);
            this.chartTempHistory.Size = new System.Drawing.Size(697, 397);
            this.chartTempHistory.TabIndex = 0;
            this.chartTempHistory.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 468);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Weather station";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLiveData)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHumHistory)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTempHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.AGauge aGaugeTemp;
        private System.Windows.Forms.AGauge aGaugeHumid;
        private System.Windows.Forms.Label labelTempTxt;
        private System.Windows.Forms.Label labelHumidTxt;
        private System.Windows.Forms.Label labelTempValue;
        private System.Windows.Forms.Label labelHumidValue;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLiveData;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHumHistory;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTempHistory;
    }
}

