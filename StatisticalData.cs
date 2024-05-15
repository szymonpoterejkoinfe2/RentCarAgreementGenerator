using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarDocument
{
    internal class StatisticalData<T>
    {
        public DateTime startOfPeriodDate { set; get; }
        public DateTime endOfPeriodDate { set; get; }

        protected DataBase dataBase = new DataBase();

        public bool EvaluateDateTimeValues()
        {
            if (startOfPeriodDate <= endOfPeriodDate)
            {
                return true;
            }
            else { 
                return false;
            }
        }
        public virtual T GetData()
        {
            return default(T); // Return default value for type T
        }

        protected virtual T GetDataFromDataBase(MySqlDataReader reader)
        { 
            return default(T);
        }
    }
}
