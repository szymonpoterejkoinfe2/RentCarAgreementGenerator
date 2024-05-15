using DocumentFormat.OpenXml.Office2010.ExcelAc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarDocument
{
    internal class RentPeriodFrequency : StatisticalData<List<TimeSpan>>
    {
        
        private List<TimeSpan> rentPeriods;
        public override List<TimeSpan> GetData()
        {
            const string query = "SELECT Query for RentPeriodFrequency";

            MySqlDataReader dataReader = base.dataBase.ReturnQuery(query);

            rentPeriods = GetDataFromDataBase(dataReader);

            return rentPeriods;
        }

        protected override List<TimeSpan> GetDataFromDataBase(MySqlDataReader reader)
        {
            List<TimeSpan> selectedTimeSpans = new List<TimeSpan>();

            while (reader.Read())
            {
                // Getting rent time spans 
            }

            reader.Close();

            return selectedTimeSpans;
        }

        public RentPeriods GetFrequencies(List<TimeSpan> timeSpans)
        {
            RentPeriods rentPeriods = new RentPeriods();
            rentPeriods.SetRentPeriods(timeSpans);
            return rentPeriods;
        }
    }
}
