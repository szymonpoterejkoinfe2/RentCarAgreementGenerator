using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarDocument
{
    public partial class GenerateAgreementForm : Form
    {
        public GenerateAgreementForm()
        {
            InitializeComponent();

            SetReturnLocationPanelVisibility();
        }


        #region ClientInfo

        private Client GetClientInfo()
        { 
            string name = clientNameTextBox.Text;
            string surname = clientSurnameTextBox.Text;
            string email = clientEmailTextBox.Text;
            string phoneNumber = clientPhoneNumberTextBox.Text;

            //To do : Evaluate with regex.

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

        private void GenerateAgreementForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SetReturnLocationPanelVisibility();
        }
        private void SetReturnLocationPanelVisibility()
        {
            if (sameLocationTextBox.Checked)
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

        private void printButton_Click(object sender, EventArgs e)
        {

        }
    }
}
