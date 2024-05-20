using DocumentFormat.OpenXml.Packaging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarDocument
{
    public partial class GenerateAgreementForm : Form
    {
        DataBase dataBase = new DataBase();
        Agreement agreement = new Agreement();

        public GenerateAgreementForm()
        {
            InitializeComponent();

            InitializeForm();

            InitializeCarComboBoxes();
            
        }

        private void InitializeForm()
        {
            pickUpDateTime.CustomFormat = "HH:mm | dd-MM-yyyy";

            returnDateTime.CustomFormat = "HH:mm | dd-MM-yyyy";

            pickUpDateTime.Text = DateTime.Now.ToString();
            returnDateTime.Text = DateTime.Now.ToString();

            SetReturnLocationPanelVisibility();
        }

        #region ClientInfo

        private Client GetClientInfo()
        { 
            string name = clientNameTextBox.Text;
            string surname = clientSurnameTextBox.Text;
            string email = clientEmailTextBox.Text;
            string phoneNumber = clientPhoneNumberTextBox.Text;

            Client client = new Client(name,surname,phoneNumber, email);
            return client;
        }

        #endregion

        #region LocationInfo

        private Location GetLocationInfo(TextBox cityTextBox, TextBox streetTextBox, TextBox postalCodeTextBox)
        {
            string city = cityTextBox.Text;
            string street = streetTextBox.Text;
            string postalCode = postalCodeTextBox.Text;

            Location location = new Location(city,street,postalCode);
            return location;
        }

        #endregion

        #region ReservationInfo

        private Reservation GetReservationInfo()
        {
            int reservationNum = Convert.ToInt32(reservationNumber.Value);
            DateTime pickUpDate = pickUpDateTime.Value;
            DateTime returnDate = returnDateTime.Value;
            float price = ((float)costUpDown.Value);

            Reservation reservation = new Reservation(reservationNum,pickUpDate,returnDate,price);

            return reservation;
        }

        #endregion

        #region AccessoriesInfo

        private Accessories GetAccessoriesInfo()
        {
            bool abroad = abroadCheckBox.Checked;
            bool insurance = insuranceCheckBox.Checked;
            bool kilometerLimit = kilometerLimitCheckBox.Checked;
            bool carSeat = carSeatCheckBox.Checked;
            bool navi = naviCheckBox.Checked;

            Accessories accessories = new Accessories(abroad,insurance,kilometerLimit,carSeat,navi);

            return accessories;
        }

        #endregion

        private void GenerateAgreementForm_Load(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SetReturnLocationPanelVisibility();
        }
        private void SetReturnLocationPanelVisibility()
        {
            if (sameLocationCheckBox.Checked)
            {
                returnLocationPanel.Visible = false;
                label18.Visible = false;
            }
            else
            {
                label18.Visible = true;
                returnLocationPanel.Visible = true;
            }
        }
        private void generateButton_Click(object sender, EventArgs e)
        {

            bool[] evaluatedParams = {false,false,false}; 

            #region ClientDataEvaluation

            Client client = GetClientInfo();

            if (client.EvaluateAttributes())
            { 
                agreement.client = client;
                evaluatedParams[0] = true;
            }

            #endregion

            #region ReservationDataEvaluation

            Reservation reservation = GetReservationInfo();

            if (reservation.EvaluateAttributes())
            { 
                agreement.reservation = reservation;
                evaluatedParams[1] = true;
            }

            #endregion

            #region LocationsEvaluation

            Location pickUpLocation = GetLocationInfo(pickUpCityTextBox,pickUpStreetTextBox,pickUpPostalCodeTextBox);
            Location returnLocation;

            if (sameLocationCheckBox.Checked && pickUpLocation.EvaluateAttributes())
            {
                returnLocation = pickUpLocation;
                agreement.pickUpLocation = pickUpLocation;
                agreement.returnLocation = returnLocation;
                evaluatedParams[2] = true;
            }
            else if (!sameLocationCheckBox.Checked)
            {
                returnLocation = GetLocationInfo(returnCityTextBox, returnStreetTextBox, returnPostalCode);
                if (returnLocation.EvaluateAttributes() && pickUpLocation.EvaluateAttributes())
                {
                    agreement.pickUpLocation = pickUpLocation;
                    agreement.returnLocation = returnLocation;
                    evaluatedParams[2] = true;
                }
            }

            #endregion

            #region Car

            Car car = registrationComboBox.SelectedItem as Car;
            agreement.car = car;

            #endregion

            #region Accessories

            Accessories accessories = new Accessories(abroadCheckBox.Checked, insuranceCheckBox.Checked,kilometerLimitCheckBox.Checked, carSeatCheckBox.Checked, naviCheckBox.Checked);

            agreement.accessories = accessories;
            #endregion

            if (evaluatedParams[0] && evaluatedParams[1] && evaluatedParams[2])
            {
                agreement.GenerateDocument();
            }
       
        }
        private void InitializeCarComboBoxes()
        {
            List<CarBrand> carBrands = GetCarBrands();

            brandComboBox.DataSource = carBrands;
            brandComboBox.ValueMember = "brandId";
            brandComboBox.DisplayMember = "brandName";

            CarBrand carBrand = brandComboBox.SelectedItem as CarBrand;

            if (carBrand != null)
            {
                List<CarModel> carModels = GetCarModels(carBrand.brandName);

                modelComboBox.DataSource = carModels;
                modelComboBox.ValueMember = "modelId";
                modelComboBox.DisplayMember = "modelName";
            }
            else {
                modelComboBox.Text = "";
            }

            CarModel carModel = modelComboBox.SelectedItem as CarModel;

            if (carModel != null)
            {
                List<Car> cars = GetCars(carModel.brandName, carModel.modelName);

                registrationComboBox.DataSource = cars;
                registrationComboBox.ValueMember = "carId";
                registrationComboBox.DisplayMember = "carRegistration";

            }
            else {
                registrationComboBox.Text = " ";
            }

        }
        private List<CarBrand> GetCarBrands()
        {
            MySqlDataReader reader;
            string query = "SELECT * FROM rentcar.carbrand;";
            reader = dataBase.ReturnQuery(query);

            List<CarBrand> selectBrands = new List<CarBrand>();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["brandId"]);
                string name = reader["brandName"].ToString();
                CarBrand brand = new CarBrand(id, name);

                selectBrands.Add(brand);
            }

            reader.Close();

            return selectBrands;

        }
        private List<CarModel> GetCarModels(string brandName)
        {
            List<CarModel> selectedModels = new List<CarModel>();
            MySqlDataReader reader;

            string query = $"SELECT modelId, modelName, brandName FROM carmodel " +
               $"JOIN carbrand ON carmodel.brandId = carbrand.brandId " +
               $"WHERE brandName = '{brandName}';";

            reader = dataBase.ReturnQuery(query);

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["modelId"]);
                string name = reader["modelName"].ToString();
                string brand = reader["brandName"].ToString();
                CarModel model = new CarModel(id, name, brand);

                selectedModels.Add(model);
            }

            reader.Close();

            return selectedModels;
        }
        private List<Car> GetCars(string brandName, string modelName)
        {
            List<Car> cars = new List<Car>();

            MySqlDataReader reader;

            string query = $"SELECT car.carId, carbrand.brandName, carmodel.modelName, car.carRegistration FROM car JOIN carbrand ON car.brandId = carbrand.brandId JOIN carmodel ON car.modelId = carmodel.modelId  WHERE carbrand.brandName = '{brandName}' AND carmodel.modelName = '{modelName}';";

            reader = dataBase.ReturnQuery(query);

            while (reader.Read())
            {
                int carId = Convert.ToInt32(reader["carId"]);
                string brand = reader["brandName"].ToString();
                string model = reader["modelName"].ToString();
                string registration = reader["carRegistration"].ToString();

                Car newCar = new Car(carId, brand, model, registration);
                cars.Add(newCar);

            }
            reader.Close();

            return cars;
        }
        private void brandComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            CarBrand carBrand = brandComboBox.SelectedItem as CarBrand;
            
            if (carBrand != null)
            {
                List<CarModel> carModels = GetCarModels(carBrand.brandName);

                modelComboBox.DataSource = carModels;
                modelComboBox.ValueMember = "modelId";
                modelComboBox.DisplayMember = "modelName";

            }
            else
            {
                modelComboBox.Text = null;
            }

        }
        private void modelComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            CarModel carModel = modelComboBox.SelectedItem as CarModel;
            List<Car> cars = GetCars(carModel.brandName, carModel.modelName);

            registrationComboBox.DataSource = cars;
            registrationComboBox.ValueMember = "carId";
            registrationComboBox.DisplayMember = "carRegistration";

            if (cars.Count < 1)
            {
                registrationComboBox.Text = null;
            }

        }

    }
}
