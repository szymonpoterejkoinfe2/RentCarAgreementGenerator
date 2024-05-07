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
using Mysqlx.Crud;

namespace RentCarDocument
{
    public partial class EditDataBase : Form
    {

        DataBase dataBase = new DataBase();

        //Brands data
        List<CarBrand> carBrands;
        CarBrand brandToDelete;
        Regex brandRegex = new Regex(@"[A-Za-z]");

        //Models data
        List<CarModel> allCarModels;
        List<CarModel> carModelsOfBrand;
        Regex modelRegex = new Regex(@"[A-Za-z0-9]");

        //Cars data
        List<Car> allCars;
        List<Car> carsWithRegistration;
        Regex registrationRegex = new Regex(@"[a-zA-Z]{2,3}\s?\w{4,5}");

        public EditDataBase()
        {
            InitializeComponent();

            InitializeTabBrand();

            InitializeTabModel();            

            InitializeTabCar();
        }

        #region TabBrand

        private void InitializeTabBrand()
        {
            carBrands = GetBrands();
            brandToDelete = carBrands.First();

            brandsComboBox.DataSource = carBrands;
            brandsComboBox.ValueMember = "brandId";
            brandsComboBox.DisplayMember = "brandName";

            UpdateBrandsDataView();
        }

        private void UpdateBrandsDataView()
        {
            brandsDataView.DataSource = carBrands;

            brandsDataView.Columns[0].Width = 50;
            brandsDataView.Columns[0].HeaderText = "Id";
            brandsDataView.Columns[1].HeaderText = "Marka";
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
            UpdateBrandsDataView();
        }

        private void DeleteBrand_Click(object sender, EventArgs e)
        {
            DeleteBrandQuery(brandToDelete);

            carBrands = GetBrands();
            UpdateBrandsDataView();
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region TabModel

        private void InitializeTabModel()
        {
            allCarModels = GetModels();
            carModelsOfBrand = GetModelsOfBrand(carBrands.First().brandName);

            UpdateModelsDataView();

            modelsDataView.Columns[0].Width = 50;
            modelsDataView.Columns[0].HeaderText = "Id";
            modelsDataView.Columns[1].HeaderText = "Model";
            modelsDataView.Columns[2].HeaderText = "Marka";

            modelTabAddBrandsComboBox.DataSource = carBrands;
            modelTabAddBrandsComboBox.ValueMember = "brandId";
            modelTabAddBrandsComboBox.DisplayMember = "brandName";

            modelTabDeleteBrandsComboBox.DataSource = carBrands;
            modelTabDeleteBrandsComboBox.ValueMember = "brandId";
            modelTabDeleteBrandsComboBox.DisplayMember = "brandName";

            modelsComboBox.DataSource = carModelsOfBrand;
            modelsComboBox.ValueMember = "modelId";
            modelsComboBox.DisplayMember = "modelName";

            modelTabDeleteBrandsComboBox.SelectedItem = carBrands.First();
            modelTabAddBrandsComboBox.SelectedItem = carBrands.First();

            
        }

        private void DataBaseOptions_TabIndexChanged(object sender, EventArgs e)
        {
            carBrands = GetBrands();
            allCarModels = GetModels();

            brandsComboBox.DataSource = carBrands;
            modelTabAddBrandsComboBox.DataSource = carBrands;
            modelTabDeleteBrandsComboBox.DataSource = carBrands;

            modelTabDeleteBrandsComboBox.SelectedItem = carBrands.First();
            modelTabAddBrandsComboBox.SelectedItem = carBrands.First();

            UpdateModelsDataView();
            UpdateBrandsDataView();
            UpdateModelsBrandComboBox();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            allCarModels = GetModels();

            UpdateModelsBrandComboBox();
            UpdateModelsDataView();
           
        }

        private void modelTabDeleteBrandsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateModelsBrandComboBox();
        }

        private List<CarModel> GetModels()
        { 
            List<CarModel> selectedModels = new List<CarModel>();
            MySqlDataReader reader;


            string query = "SELECT modelId, modelName, CarBrand FROM carrentaldatabase.carmodels JOIN carbrand ON carmodels.brandId = carbrand.idCarBrand;";
            reader = dataBase.ReturnQuery(query);


            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["modelId"]);
                string name = reader["modelName"].ToString();
                string brand = reader["CarBrand"].ToString();
                CarModel model = new CarModel(id, name, brand);

                selectedModels.Add(model);

            }

            reader.Close();

            return selectedModels;
        }

        private List<CarModel> GetModelsOfBrand(string brandName)
        {
            List<CarModel> selectedModels = new List<CarModel>();
            MySqlDataReader reader;

            string query = $"SELECT modelId, modelName, CarBrand FROM carrentaldatabase.carmodels " +
               $"JOIN carbrand ON carmodels.brandId = carbrand.idCarBrand " +
               $"WHERE CarBrand = '{brandName}';";

            reader = dataBase.ReturnQuery(query);

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["modelId"]);
                string name = reader["modelName"].ToString();
                string brand = reader["CarBrand"].ToString();
                CarModel model = new CarModel(id, name, brand);

                selectedModels.Add(model);

            }

            reader.Close();

            return selectedModels;

        }

        private void UpdateModelsBrandComboBox()
        {
            CarBrand selectedBrandDelete = modelTabDeleteBrandsComboBox.SelectedItem as CarBrand;
            carModelsOfBrand = GetModelsOfBrand(selectedBrandDelete.brandName);

            if (carModelsOfBrand.Count != 0)
            {
                modelsComboBox.DataSource = carModelsOfBrand;
                modelsComboBox.ValueMember = "modelId";
                modelsComboBox.DisplayMember = "modelName";
            }
            else {
                modelsComboBox.DataSource = null;
            }

        }

        private void UpdateModelsDataView()
        {
            allCarModels = GetModels();
            modelsDataView.DataSource = allCarModels;
        }

        private void deleteModelButton_Click(object sender, EventArgs e)
        {
            CarModel carModelToDelete = modelsComboBox.SelectedItem as CarModel;

            DeleteModelQuery(carModelToDelete);

            UpdateModelsDataView();

            UpdateModelsBrandComboBox();
        }

        private void addModelButton_Click(object sender, EventArgs e)
        {
            string inputModel = modelTextBox.Text;

            if(modelRegex.IsMatch(inputModel))
            {
                CarBrand carBrand = modelTabAddBrandsComboBox.SelectedItem as CarBrand;
                AddModelQuery(inputModel, carBrand.brandId);
                modelTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Nie można używać znaków specjalnych. Proszę usunąć znaki specjalne z wprowadzonych danych!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateModelsDataView();
            UpdateModelsBrandComboBox();
        }

        private void DeleteModelQuery(CarModel carModel)
        {
            try {
                string query = $"DELETE FROM carrentaldatabase.carmodels WHERE modelId = {carModel.modelId};";
                dataBase.NonReturnQuery(query);
                modelsComboBox.Text = "";
            }
            catch (Exception e)
            {
                errorLabelModelDelete.Text = e.Message;
            }
        }

        private void AddModelQuery(string modelName,int brandId)
        {
            try
            {
                string query = $"INSERT INTO carrentaldatabase.carmodels (modelName, brandId) VALUES ('{modelName}','{brandId}');";
                dataBase.NonReturnQuery(query);
            }
            catch (Exception e)
            {
                errorLabelModelAdd.Text = e.Message;    
            }
        }

        #endregion

        #region TabCar

        private void tabPage3_Click(object sender, EventArgs e)
        {
            UpdateCarDataView();
        }

        private void InitializeTabCar()
        {
            addCarBrandComboBox.DataSource = carBrands;
            addCarBrandComboBox.ValueMember = "brandId";
            addCarBrandComboBox.DisplayMember = "brandName";

            addCarModelComboBox.DataSource = carModelsOfBrand;
            addCarModelComboBox.ValueMember = "modelId";
            addCarModelComboBox.DisplayMember = "modelName";

            deleteCarBrandComboBox.DataSource = carBrands;
            deleteCarBrandComboBox.ValueMember = "brandId";
            deleteCarBrandComboBox.DisplayMember = "brandName";

            deleteCarModelComboBox.DataSource = carModelsOfBrand;
            deleteCarModelComboBox.ValueMember = "modelId";
            deleteCarModelComboBox.DisplayMember = "modelName";

            UpdateCarDataView();
        }

        private void UpdateCarDataView()
        {
            allCars = GetCars();
            carDataGridView.DataSource = allCars;
            carDataGridView.Columns[0].HeaderText = "Id";
            carDataGridView.Columns[0].Width = 30;
            carDataGridView.Columns[1].HeaderText = "Marka";
            carDataGridView.Columns[1].Width = 60;
            carDataGridView.Columns[2].HeaderText = "Model";
            carDataGridView.Columns[2].Width = 60;
            carDataGridView.Columns[3].HeaderText = "Rejestracja";
            carDataGridView.Columns[3].Width = 65;

        }

        private List<Car> GetCars()
        {
            List<Car> selectedCars = new List<Car>();
            MySqlDataReader reader;

            string query = "SELECT cars.carId, carbrand.CarBrand, carmodels.modelName, cars.carRegistration FROM carrentaldatabase.cars JOIN  carbrand ON cars.brandId = carbrand.idCarBrand JOIN carmodels ON cars.modelId = carmodels.modelId;";
            reader = dataBase.ReturnQuery(query);

            while (reader.Read())
            {
                int carId = Convert.ToInt32(reader["carId"]);
                string brandName = reader["CarBrand"].ToString();
                string modelName = reader["modelName"].ToString();
                string registration = reader["carRegistration"].ToString();

                Car newCar = new Car(carId,  brandName, modelName, registration);
                selectedCars.Add(newCar);

            }

            reader.Close();
            return selectedCars;
        }

        private void addCarBrandComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateModelsBrandComboBox(addCarModelComboBox,addCarBrandComboBox);
        }

        private void deleteCarBrandComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateModelsBrandComboBox(deleteCarModelComboBox, deleteCarBrandComboBox);
        }

        private void UpdateModelsBrandComboBox(ComboBox modelComboBox,ComboBox brandComboBox)
        {
            CarBrand selectedBrand = brandComboBox.SelectedItem as CarBrand;

            carModelsOfBrand = GetModelsOfBrand(selectedBrand.brandName);

            if (carModelsOfBrand.Count != 0)
            {
                modelComboBox.DataSource = carModelsOfBrand;
                modelComboBox.ValueMember = "modelId";
                modelComboBox.DisplayMember = "modelName";
            }
            else
            {
                modelComboBox.DataSource = null;
            }
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            string inputRegistration = addCarRegistrationTextBox.Text;

            if (registrationRegex.IsMatch(inputRegistration))
            {
                CarBrand selectedBrand = addCarBrandComboBox.SelectedItem as CarBrand;
                CarModel selectedModel = addCarModelComboBox.SelectedItem as CarModel;

                AddCarQuery(selectedBrand.brandId,selectedModel.modelId,inputRegistration);
                addCarRegistrationTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Nie można używać znaków specjalnych. Proszę usunąć znaki specjalne z wprowadzonych danych!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateCarDataView();
        }

        private void AddCarQuery(int brandId, int modelId, string registration)
        {
            try
            {
                string query = $"INSERT INTO carrentaldatabase.cars (brandId,modelId,carRegistration) VALUES ('{brandId}','{modelId}','{registration}');";
                dataBase.NonReturnQuery(query);
            }
            catch (Exception e)
            {
                errorLabelCarAdd.Text = e.Message;
            }
        }

        private void deleteCarModelComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateRegistrationComboBox();
        }

        private void UpdateRegistrationComboBox()
        {
            CarBrand selectedBrand = deleteCarBrandComboBox.SelectedItem as CarBrand;
            CarModel selectedModel = deleteCarModelComboBox.SelectedItem as CarModel;

            carsWithRegistration = GetCarsWithRegistration(selectedBrand.brandName,selectedModel.modelName);

            if(carsWithRegistration.Count > 0)
            { 
                carDeleteRegistrationComboBox.DataSource = carsWithRegistration;
                carDeleteRegistrationComboBox.ValueMember = "carId";
                carDeleteRegistrationComboBox.DisplayMember = "carRegistration";
            }
            else {
                carDeleteRegistrationComboBox.DataSource = null;
            }
        }

        private List<Car> GetCarsWithRegistration(string brandName, string modelName)
        {
            List<Car> cars = new List<Car>();

            MySqlDataReader reader;

            string query = $"SELECT cars.carId, carbrand.CarBrand, carmodels.modelName, cars.carRegistration FROM carrentaldatabase.cars JOIN carbrand ON cars.brandId = carbrand.idCarBrand JOIN carmodels ON cars.modelId = carmodels.modelId  WHERE carbrand.CarBrand = '{brandName}' AND carmodels.modelName = '{modelName}';";

            reader = dataBase.ReturnQuery(query);

            while (reader.Read())
            {
                int carId = Convert.ToInt32(reader["carId"]);
                string brand = reader["CarBrand"].ToString();
                string model = reader["modelName"].ToString();
                string registration = reader["carRegistration"].ToString();

                Car newCar = new Car(carId, brand, model, registration);
                cars.Add(newCar);

            }
            reader.Close();

            return cars;
        }

        private void deleteCarButton_Click(object sender, EventArgs e)
        {
            Car carToDelete = carDeleteRegistrationComboBox.SelectedItem as Car;

            DeleteCarQuery(carToDelete);

            UpdateRegistrationComboBox();
            UpdateCarDataView();
        }

        private void DeleteCarQuery(Car carToDelete)
        {
            try
            {
                string query = $"DELETE FROM carrentaldatabase.cars WHERE carId = {carToDelete.carId};";
                dataBase.NonReturnQuery(query);
                modelsComboBox.Text = "";
            }
            catch (Exception e)
            {
                deleteCarErrorLabel.Text = e.Message;
            }
        }


        #endregion

        private void DataBaseOptions_Selected(object sender, TabControlEventArgs e)
        {
            InitializeTabBrand();
            InitializeTabModel();
            InitializeTabCar();
        }
    }
}
