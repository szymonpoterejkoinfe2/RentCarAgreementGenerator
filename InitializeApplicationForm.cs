using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarDocument
{
    public partial class InitializeApplicationForm : Form
    {

        public InitializeApplicationForm()
        {
            InitializeComponent();
            InitializeTextBoxes();
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                folderPathTextBox.Text = folderBrowserDialog.SelectedPath;
            }
            else {
                folderPathTextBox.Text = string.Empty;
            }
        }

        private void InitializeTextBoxes()
        {
            serverTextBox.Text = "localhost";
            userTextBox.Text = "root";
        }

        private void startApplicationButton_Click(object sender, EventArgs e)
        {
            Thread thread;

            User.server = serverTextBox.Text;
            User.username = userTextBox.Text;
            User.password = passwordTextBox.Text;
            User.folderPath = folderPathTextBox.Text;


            Close();
            thread = new Thread(OpenMainForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenMainForm()
        {
            Application.Run(new MainForm());

        }
    }
}
