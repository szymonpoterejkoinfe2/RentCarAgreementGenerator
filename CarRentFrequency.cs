using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;

namespace RentCarDocument
{
    internal class CarRentFrequency: StatisticalData<List<Car>>
    {
        private List<Car> rentedCars;
        public override List<Car> GetData()
        {
            string query = $"SELECT reservation.carId, brandName, modelName, carRegistration FROM reservation JOIN car ON reservation.carId = car.carId JOIN carmodel ON car.modelId = carmodel.modelId JOIN carbrand On carmodel.brandId = carbrand.brandId WHERE pickUpDateTime >= '{startOfPeriodDate}' AND returnDateTime <= '{endOfPeriodDate}';";

            MySqlDataReader dataReader = base.dataBase.ReturnQuery(query);

            rentedCars = GetDataFromDataBase(dataReader);

            return rentedCars;
        }
        protected override List<Car> GetDataFromDataBase(MySqlDataReader reader)
        {
            List<Car> selectCars = new List<Car>();

            while (reader.Read())
            {
                int carId = Convert.ToInt32(reader["carId"]);
                string brand = reader["brandName"].ToString();
                string model = reader["modelName"].ToString();
                string registration = reader["carRegistration"].ToString();

                Car newCar = new Car(carId, brand, model, registration);
                selectCars.Add(newCar);

            }
            reader.Close();

            return selectCars;
        }
    }
}
