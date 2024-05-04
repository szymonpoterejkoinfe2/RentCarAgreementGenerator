using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace RentCarDocument
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EditDataBaseButton_Click(object sender, EventArgs e)
        {
            EditDataBase editDataBaseForm = new EditDataBase();
            editDataBaseForm.ShowDialog();
        }

        private void GenerateAgreementButton_Click(object sender, EventArgs e)
        {
            GenerateAgreementForm generateAgreementForm = new GenerateAgreementForm();
            generateAgreementForm.ShowDialog();
        }

    }
}
