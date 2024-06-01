namespace RentCarDocument
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.rentCarsFrequenciesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.averageValuesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rentPeriodsFrequenciesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generateChartsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rentCarsFrequenciesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageValuesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentPeriodsFrequenciesChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentCarsFrequenciesChart
            // 
            this.rentCarsFrequenciesChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rentCarsFrequenciesChart.BorderlineColor = System.Drawing.Color.Black;
            this.rentCarsFrequenciesChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.rentCarsFrequenciesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.rentCarsFrequenciesChart.Legends.Add(legend1);
            this.rentCarsFrequenciesChart.Location = new System.Drawing.Point(411, 23);
            this.rentCarsFrequenciesChart.Name = "rentCarsFrequenciesChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.rentCarsFrequenciesChart.Series.Add(series1);
            this.rentCarsFrequenciesChart.Size = new System.Drawing.Size(355, 205);
            this.rentCarsFrequenciesChart.TabIndex = 0;
            this.rentCarsFrequenciesChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Ilość wynajmów samochodu";
            this.rentCarsFrequenciesChart.Titles.Add(title1);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(44, 50);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(291, 20);
            this.startDateTimePicker.TabIndex = 1;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(44, 100);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(291, 20);
            this.endDateTimePicker.TabIndex = 2;
            // 
            // averageValuesChart
            // 
            this.averageValuesChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.averageValuesChart.BorderlineColor = System.Drawing.Color.Black;
            this.averageValuesChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.averageValuesChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.averageValuesChart.Legends.Add(legend2);
            this.averageValuesChart.Location = new System.Drawing.Point(411, 234);
            this.averageValuesChart.Name = "averageValuesChart";
            this.averageValuesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "{0.0} zł";
            series2.Legend = "Legend1";
            series2.Name = "Średni Koszt Najmu";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Spacing";
            series4.ChartArea = "ChartArea1";
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series4.IsValueShownAsLabel = true;
            series4.LabelFormat = "{0} dni";
            series4.Legend = "Legend1";
            series4.Name = "Średnia Długość Najmu";
            this.averageValuesChart.Series.Add(series2);
            this.averageValuesChart.Series.Add(series3);
            this.averageValuesChart.Series.Add(series4);
            this.averageValuesChart.Size = new System.Drawing.Size(355, 205);
            this.averageValuesChart.TabIndex = 3;
            this.averageValuesChart.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title2.Name = "Title1";
            title2.Text = "Średnie wartości";
            this.averageValuesChart.Titles.Add(title2);
            // 
            // rentPeriodsFrequenciesChart
            // 
            this.rentPeriodsFrequenciesChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rentPeriodsFrequenciesChart.BorderlineColor = System.Drawing.Color.Black;
            this.rentPeriodsFrequenciesChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.rentPeriodsFrequenciesChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.rentPeriodsFrequenciesChart.Legends.Add(legend3);
            this.rentPeriodsFrequenciesChart.Location = new System.Drawing.Point(50, 234);
            this.rentPeriodsFrequenciesChart.Name = "rentPeriodsFrequenciesChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Długość Wynajmu";
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.rentPeriodsFrequenciesChart.Series.Add(series5);
            this.rentPeriodsFrequenciesChart.Size = new System.Drawing.Size(355, 205);
            this.rentPeriodsFrequenciesChart.TabIndex = 4;
            this.rentPeriodsFrequenciesChart.Text = "chart3";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title3.Name = "Title1";
            title3.Text = "Długość wynajmów";
            this.rentPeriodsFrequenciesChart.Titles.Add(title3);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.generateChartsButton);
            this.panel1.Controls.Add(this.endDateTimePicker);
            this.panel1.Controls.Add(this.startDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(50, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 205);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data końca statystyki";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data początku statystyki";
            // 
            // generateChartsButton
            // 
            this.generateChartsButton.Location = new System.Drawing.Point(204, 152);
            this.generateChartsButton.Name = "generateChartsButton";
            this.generateChartsButton.Size = new System.Drawing.Size(131, 31);
            this.generateChartsButton.TabIndex = 3;
            this.generateChartsButton.Text = "Generuj Wykresy";
            this.generateChartsButton.UseVisualStyleBackColor = true;
            this.generateChartsButton.Click += new System.EventHandler(this.generateChartsButton_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rentPeriodsFrequenciesChart);
            this.Controls.Add(this.averageValuesChart);
            this.Controls.Add(this.rentCarsFrequenciesChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Statistics";
            this.Text = "Dane statystyczne";
            ((System.ComponentModel.ISupportInitialize)(this.rentCarsFrequenciesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageValuesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentPeriodsFrequenciesChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart rentCarsFrequenciesChart;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DataVisualization.Charting.Chart averageValuesChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart rentPeriodsFrequenciesChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button generateChartsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}