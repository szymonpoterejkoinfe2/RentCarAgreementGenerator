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
                List<TimeSpan> periods = rentPeriodFrequency.GetData();

                //UpdateFrequenciesChart
                RentPeriods rentPeriodsFrequencies = rentPeriodFrequency.GetFrequencies(periods);
                rentPeriodsFrequenciesChart.DataSource = rentPeriodsFrequencies;


            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane wejściowe. Data końcowa nie może być mniejsza niz data końcowa", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
