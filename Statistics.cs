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

namespace RentCarDocument
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void generateChartsButton_Click(object sender, EventArgs e)
        {
            CarRentFrequency carRentFrequency = new CarRentFrequency();
            carRentFrequency.startOfPeriodDate = startDateTimePicker.Value;
            carRentFrequency.endOfPeriodDate = endDateTimePicker.Value;

            RentPeriodFrequency rentPeriodFrequency = new RentPeriodFrequency();
            rentPeriodFrequency.startOfPeriodDate = startDateTimePicker.Value;
            rentPeriodFrequency.endOfPeriodDate= endDateTimePicker.Value;

            if (carRentFrequency.EvaluateDateTimeValues() && rentPeriodFrequency.EvaluateDateTimeValues())
            { 
                List<Car> cars = carRentFrequency.GetData();


                InitializeCarFrequencyChart(cars);

                InitializeRentPeriodFrequenciesChart(rentPeriodFrequency);
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
                try
                {
                    tempDictionary.Add(car.carModel, 1);
                }
                catch
                {
                    tempDictionary[car.carModel] += 1;
                }
            }


            return tempDictionary;
        }

        private void InitializeCarFrequencyChart(List<Car> cars)
        {

            rentCarsFrequenciesChart.ChartAreas[0].AxisX.Title = "Model";
            rentCarsFrequenciesChart.ChartAreas[0].AxisY.Title = "Ilość wynajmów";
            rentCarsFrequenciesChart.ChartAreas[0].AxisX.Interval = 1;
            rentCarsFrequenciesChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            Dictionary<string, int>  rentedModels = GetRentedModels(cars);

            foreach (var modelAndQuantity in rentedModels)
            {
                rentCarsFrequenciesChart.Series["Series1"].Points.AddXY(modelAndQuantity.Key, modelAndQuantity.Value);
            }

            rentCarsFrequenciesChart.Series["Series1"].IsValueShownAsLabel = true;
        }

        private void InitializeRentPeriodFrequenciesChart(RentPeriodFrequency rentPeriodFrequency)
        {
            List<TimeSpan> periods = rentPeriodFrequency.GetData();

            //UpdateFrequenciesChart
            RentPeriods rentPeriodsFrequencies = rentPeriodFrequency.GetFrequencies(periods);

            rentPeriodsFrequenciesChart.ChartAreas[0].AxisX.Title = "Długość wynajmu w dniach";
            rentPeriodsFrequenciesChart.ChartAreas[0].AxisY.Title = "Ilość wynajmów";
            rentPeriodsFrequenciesChart.ChartAreas[0].AxisX.Interval = 1;
            rentPeriodsFrequenciesChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;



            rentPeriodsFrequenciesChart.Series["Series1"].Points.AddXY("1-3", rentPeriodsFrequencies.lengthOneToThree);
            rentPeriodsFrequenciesChart.Series["Series1"].Points.AddXY("3-5", rentPeriodsFrequencies.lengthThreeToFive);
            rentPeriodsFrequenciesChart.Series["Series1"].Points.AddXY("5-7", rentPeriodsFrequencies.lengthFiveToSeven);
            rentPeriodsFrequenciesChart.Series["Series1"].Points.AddXY("7-14", rentPeriodsFrequencies.lengthSevenToFourteen);
            rentPeriodsFrequenciesChart.Series["Series1"].Points.AddXY("14+", rentPeriodsFrequencies.lengthFourteenPlus);

        }
    }
}
