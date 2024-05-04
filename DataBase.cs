using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace RentCarDocument
{
    internal class DataBase
    {
        string connectionDetails = "server = localhost;uid=root;pwd=Goleszycow37;database=carrentaldatabase";

        MySqlConnection connection;

        public DataBase()
        {
            ConnectToDataBase();
        }

        private void ConnectToDataBase()
        {
            try
            {
                connection = new MySqlConnection(connectionDetails);
                connection.Open();
            }
            catch
            {
                Console.WriteLine("Error while connecting");
            }
        }

        public MySqlDataReader ReturnQuery(string query)
        {
            MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            return reader;
        }

        public void NonReturnQuery(string query)
        {
            MySqlCommand addToTable = new MySqlCommand(query, connection);
          
            addToTable.ExecuteNonQuery();
        }

        public string GetDataBaseName()
        {
            return connection.Database;
        }
    }
}
