using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RentCarDocument
{
    public partial class Statistics : Form
    {
        List<TimeSpan> periods;

        public Statistics()
        {
            InitializeComponent();
            HideCharts();
        }

        private void generateChartsButton_Click(object sender, EventArgs e)
        {

            ClearChart(rentCarsFrequenciesChart, "Series1");
            ClearChart(rentPeriodsFrequenciesChart, "Długość Wynajmu");
            ClearChart(averageValuesChart, "Średni Koszt Najmu");
            ClearChart(averageValuesChart, "Spacing");
            ClearChart(averageValuesChart, "Średnia Długość Najmu");

            #region createObjects
            CarRentFrequency carRentFrequency = new CarRentFrequency();
            carRentFrequency.startOfPeriodDate = startDateTimePicker.Value;
            carRentFrequency.endOfPeriodDate = endDateTimePicker.Value;

            RentPeriodFrequency rentPeriodFrequency = new RentPeriodFrequency();
            rentPeriodFrequency.startOfPeriodDate = startDateTimePicker.Value;
            rentPeriodFrequency.endOfPeriodDate = endDateTimePicker.Value;

            AverageValues averageValues = new AverageValues();
            averageValues.startOfPeriodDate = startDateTimePicker.Value;
            averageValues.endOfPeriodDate = endDateTimePicker.Value;
            #endregion

            if (carRentFrequency.EvaluateDateTimeValues() && rentPeriodFrequency.EvaluateDateTimeValues() && averageValues.EvaluateDateTimeValues())
            {

                #region prepareData
                List<Car> cars = carRentFrequency.GetData();
                
                List<TimeSpan> periods = rentPeriodFrequency.GetData();
                RentPeriods rentPeriodFrequencies = rentPeriodFrequency.GetFrequencies(periods);

                List<float> rentCosts = averageValues.GetData();
                #endregion

                InitializeCarFrequencyChart(cars);

                InitializeRentPeriodFrequenciesChart(rentPeriodFrequencies);

                InitializeAverageValuesChart(averageValues.GetAverageCost(rentCosts), averageValues.GetAverageRentPeriod(periods));

                ShowCharts();
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane wejściowe. Data końcowa nie może być mniejsza niz data początkowa!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private Dictionary<string, int> GetRentedModels(List<Car> cars)
        {
            Dictionary<string, int> tempDictionary = new Dictionary<string, int>();

            foreach(Car car in cars)
            {
                string carName = car.carBrand + " " + car.carModel;
                try
                {
                    tempDictionary.Add(carName, 1);
                }
                catch
                {
                    tempDictionary[carName] += 1;
                }
            }

            return tempDictionary;
        }

        private void InitializeCarFrequencyChart(List<Car> cars)
        {
            SetChartAxisTitles(rentCarsFrequenciesChart, "Model", "Ilość wynajmów");
            SetChartAxisIntervalAndMajorGrid(rentCarsFrequenciesChart, false, true);

            #region AddCarFrequencyPoints
            Dictionary<string, int>  rentedModels = GetRentedModels(cars);
            foreach (var modelAndQuantity in rentedModels)
            {
                rentCarsFrequenciesChart.Series["Series1"].Points.AddXY(modelAndQuantity.Key, modelAndQuantity.Value);
            }
            #endregion
        }

        private void InitializeRentPeriodFrequenciesChart(RentPeriods rentPeriodFrequencies)
        {
            SetChartAxisTitles(rentPeriodsFrequenciesChart, "Długość wynajmu w dniach", "Ilość wynajmów");
            SetChartAxisIntervalAndMajorGrid(rentPeriodsFrequenciesChart, false, true);

            #region AddRentPeriodFrequencyPoints
            rentPeriodsFrequenciesChart.Series["Długość Wynajmu"].Points.AddXY("1-3", rentPeriodFrequencies.lengthOneToThree);
            rentPeriodsFrequenciesChart.Series["Długość Wynajmu"].Points.AddXY("3-5", rentPeriodFrequencies.lengthThreeToFive);
            rentPeriodsFrequenciesChart.Series["Długość Wynajmu"].Points.AddXY("5-7", rentPeriodFrequencies.lengthFiveToSeven);
            rentPeriodsFrequenciesChart.Series["Długość Wynajmu"].Points.AddXY("7-14", rentPeriodFrequencies.lengthSevenToFourteen);
            rentPeriodsFrequenciesChart.Series["Długość Wynajmu"].Points.AddXY("14+", rentPeriodFrequencies.lengthFourteenPlus);
            #endregion
        }

        private void InitializeAverageValuesChart(float averagRentCost, float averageRentPeriod)
        {

            #region AddAverageValuePoints
            averageValuesChart.Series["Średni Koszt Najmu"].Points.AddY(averagRentCost);

            // Add spacing point to chart
            averageValuesChart.Series["Spacing"].Points.AddY("");
            averageValuesChart.Series["Spacing"]["PixelPointWidth"] = "90";
            averageValuesChart.Series["Spacing"].IsVisibleInLegend = false;

            averageValuesChart.Series["Średnia Długość Najmu"].Points.AddY(averageRentPeriod);
            #endregion

            SetChartAxisIntervalAndMajorGrid(averageValuesChart, false, false);
            SetSeriesAndPointColor(averageValuesChart, "Średni Koszt Najmu", System.Drawing.Color.Pink);
            SetSeriesAndPointColor(averageValuesChart, "Średnia Długość Najmu", System.Drawing.Color.DarkBlue);

        }

        private void SetChartAxisTitles(Chart chart, string xAxisTitle, string yAxisTitle)
        {
            chart.ChartAreas[0].AxisX.Title = xAxisTitle;
            chart.ChartAreas[0].AxisY.Title = yAxisTitle;
        }

        private void SetChartAxisIntervalAndMajorGrid(Chart chart, bool xAxisMajorGridEnabled, bool yAxisMajorGridEnabled,int xAxisInterval = 1)
        {
            chart.ChartAreas[0].AxisX.Interval = xAxisInterval;
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = xAxisMajorGridEnabled;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = yAxisMajorGridEnabled;
        }

        private void SetSeriesAndPointColor(Chart chart, string seriesName, System.Drawing.Color color)
        {
            chart.Series[seriesName].Color = color;
            chart.Series[seriesName].Points[0].Color = color;
        }

        private void HideCharts()
        {
            rentCarsFrequenciesChart.Visible = false;
            rentPeriodsFrequenciesChart.Visible = false;
            averageValuesChart.Visible = false;
        }
        private void ShowCharts()
        {
            rentCarsFrequenciesChart.Visible = true;
            rentPeriodsFrequenciesChart.Visible = true;
            averageValuesChart.Visible = true;
        }
        private void ClearChart(Chart chart, string seriesName)
        {
            chart.Series[seriesName].Points.Clear();
        }


    }
}
