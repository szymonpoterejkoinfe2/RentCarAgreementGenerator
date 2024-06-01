using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace RentCarDocument
{
    internal class DataBase
    {
        string connectionDetails = $"server={User.server};uid={User.username};pwd={User.password};database=rentcar";

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
            catch(Exception e)
            {
                MessageBox.Show($"{e.ToString()}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CloseConnection()
        { 
            connection.Close();
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
    }
}
