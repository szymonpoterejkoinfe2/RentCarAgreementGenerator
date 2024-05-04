using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace RentCarDocument
{
    public partial class EditDataBase : Form
    {

        DataBase dataBase = new DataBase();

        List<CarBrand> carBrands;
        CarBrand brandToDelete;

        Regex brandRegex = new Regex(@"[A-Za-z]");

        public EditDataBase()
        {
            InitializeComponent();

            carBrands = GetBrands();
            brandToDelete = carBrands.First();


            UpdateDataView();
            brandsComboBox.DataSource = carBrands;
            brandsComboBox.ValueMember = "brandId";
            brandsComboBox.DisplayMember = "brandName";
        }

        #region TabBrand
        private void UpdateDataView()
        {
            brandsDataView.DataSource = carBrands;
        }

        private void AddBrand_Click(object sender, EventArgs e)
        {
            string inputBrand = carBrandTextBox.Text.ToString();

            if (brandRegex.IsMatch(inputBrand))
            {
                AddBrandQuery(inputBrand);
                carBrandTextBox.Text = "";
            }
            else {
                MessageBox.Show("Nie można używać znaków specjalnych. Proszę usunąć znaki specjalne z wprowadzonych danych!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            carBrands = GetBrands();
            brandsComboBox.DataSource = carBrands;
            UpdateDataView();
        }

        private void DeleteBrand_Click(object sender, EventArgs e)
        {
            DeleteBrandQuery(brandToDelete);

            carBrands = GetBrands();
            UpdateDataView();
            brandsComboBox.DataSource = carBrands;
        }

        private List<CarBrand> GetBrands()
        {
            MySqlDataReader reader;
            string query = "SELECT * FROM carrentaldatabase.carbrand;";
            reader = dataBase.ReturnQuery(query);

            List<CarBrand> selectBrands = new List<CarBrand>();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["idCarBrand"]);
                string name = reader["CarBrand"].ToString();
                CarBrand brand = new CarBrand(id, name);

                selectBrands.Add(brand);
            }

            reader.Close();

            return selectBrands;
        }

        private void DeleteBrandQuery(CarBrand carBrand)
        {
            try
            {
                string query = $"DELETE FROM carrentaldatabase.carbrand WHERE idCarBrand = {carBrand.brandId};";
                dataBase.NonReturnQuery(query);
            }
            catch(Exception e)
            {
                ErrorLabelDelete.Text = e.Message;
            }
        }

        private void AddBrandQuery(string carBrand)
        {
            try
            {
                string query = $"INSERT INTO carrentaldatabase.carbrand (CarBrand) VALUES ('{carBrand}');";
                dataBase.NonReturnQuery(query);
            }
            catch (Exception e)
            {
                ErrorLabelAdd.Text = e.Message;
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            brandToDelete = brandsComboBox.SelectedItem as CarBrand;
        }

        #endregion

        #region TabModel



        #endregion

        private void DataBaseOptions_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataBaseOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AddPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ErrorLabelAdd_Click(object sender, EventArgs e)
        {

        }

        private void AddTitle_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void carBrandTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeletePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ErrorLabelDelete_Click(object sender, EventArgs e)
        {

        }

        private void DeleteTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void brandsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void brandsDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
