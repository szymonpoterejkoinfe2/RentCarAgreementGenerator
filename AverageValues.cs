using DocumentFormat.OpenXml.Drawing.Charts;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarDocument
{
    internal class AverageValues : StatisticalData<List<float>>
    {
        private List<float> data = new List<float>();

        public override List<float> GetData()
        {

            string query = $"SELECT reservationCost FROM reservation WHERE pickUpDateTime >= '{startOfPeriodDate}' AND returnDateTime <= '{endOfPeriodDate}';";

            MySqlDataReader dataReader = base.dataBase.ReturnQuery(query);

            data = GetDataFromDataBase(dataReader);

            return data;
        }

        protected override List<float> GetDataFromDataBase(MySqlDataReader reader)
        {
            List<float> selectedValuesForAverage = new List<float>();

            while (reader.Read())
            {
                float cost = (float)reader["reservationCost"];

                selectedValuesForAverage.Add(cost);
            }

            reader.Close();

            return selectedValuesForAverage;

        }

        public float GetAverageCost(List<float> costsData)
        {
            float average = 0;
            if (costsData.Count > 0)
            {
                average = costsData.Average();
            }
            return average;
        }

        public float GetAverageRentPeriod(List<TimeSpan> periods)
        {
            float averageDays = 0;

            if (periods.Count > 0)
            {
                TimeSpan averagePeriod = TimeSpan.FromTicks((long)periods.Average(timeSpan => timeSpan.Ticks));
                averageDays = (float)averagePeriod.TotalDays;
            }

            return averageDays;
        }
    }
}
