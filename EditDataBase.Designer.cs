namespace RentCarDocument
{
    partial class EditDataBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataBaseOptions = new System.Windows.Forms.TabControl();
            this.brandTab = new System.Windows.Forms.TabPage();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.ErrorLabelAdd = new System.Windows.Forms.Label();
            this.AddTitle = new System.Windows.Forms.Label();
            this.AddBrand = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.carBrandTextBox = new System.Windows.Forms.TextBox();
            this.DeletePanel = new System.Windows.Forms.Panel();
            this.ErrorLabelDelete = new System.Windows.Forms.Label();
            this.DeleteTitle = new System.Windows.Forms.Label();
            this.DeleteBrand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.brandsComboBox = new System.Windows.Forms.ComboBox();
            this.brandsDataView = new System.Windows.Forms.DataGridView();
            this.modelTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorLabelModelDelete = new System.Windows.Forms.Label();
            this.modelsComboBox = new System.Windows.Forms.ComboBox();
            this.deleteModelButton = new System.Windows.Forms.Button();
            this.modelDeleteText = new System.Windows.Forms.Label();
            this.brandDeleteText = new System.Windows.Forms.Label();
            this.modelTabDeleteBrandsComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorLabelModelAdd = new System.Windows.Forms.Label();
            this.addModelButton = new System.Windows.Forms.Button();
            this.modelAddText = new System.Windows.Forms.Label();
            this.brandAddText = new System.Windows.Forms.Label();
            this.modelTabAddBrandsComboBox = new System.Windows.Forms.ComboBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.modelsDataView = new System.Windows.Forms.DataGridView();
            this.carTab = new System.Windows.Forms.TabPage();
            this.deleteCarPanel = new System.Windows.Forms.Panel();
            this.panelTitleDeleteCar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteCarModelComboBox = new System.Windows.Forms.ComboBox();
            this.deleteCarBrandComboBox = new System.Windows.Forms.ComboBox();
            this.deleteCarButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.addCarPanel = new System.Windows.Forms.Panel();
            this.panelTitleAddCar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addCarRegistrationTextBox = new System.Windows.Forms.TextBox();
            this.addCarModelComboBox = new System.Windows.Forms.ComboBox();
            this.addCarBrandComboBox = new System.Windows.Forms.ComboBox();
            this.addCarButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.carDataGridView = new System.Windows.Forms.DataGridView();
            this.carDeleteRegistrationComboBox = new System.Windows.Forms.ComboBox();
            this.errorLabelCarAdd = new System.Windows.Forms.Label();
            this.deleteCarErrorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DataBaseOptions.SuspendLayout();
            this.brandTab.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.DeletePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandsDataView)).BeginInit();
            this.modelTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataView)).BeginInit();
            this.carTab.SuspendLayout();
            this.deleteCarPanel.SuspendLayout();
            this.addCarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataBaseOptions
            // 
            this.DataBaseOptions.Controls.Add(this.brandTab);
            this.DataBaseOptions.Controls.Add(this.modelTab);
            this.DataBaseOptions.Controls.Add(this.carTab);
            this.DataBaseOptions.Location = new System.Drawing.Point(12, 12);
            this.DataBaseOptions.Name = "DataBaseOptions";
            this.DataBaseOptions.SelectedIndex = 0;
            this.DataBaseOptions.Size = new System.Drawing.Size(776, 426);
            this.DataBaseOptions.TabIndex = 5;
            this.DataBaseOptions.Selected += new System.Windows.Forms.TabControlEventHandler(this.DataBaseOptions_Selected);
            this.DataBaseOptions.TabIndexChanged += new System.EventHandler(this.DataBaseOptions_TabIndexChanged);
            // 
            // brandTab
            // 
            this.brandTab.Controls.Add(this.AddPanel);
            this.brandTab.Controls.Add(this.DeletePanel);
            this.brandTab.Controls.Add(this.brandsDataView);
            this.brandTab.Location = new System.Drawing.Point(4, 22);
            this.brandTab.Name = "brandTab";
            this.brandTab.Padding = new System.Windows.Forms.Padding(3);
            this.brandTab.Size = new System.Drawing.Size(768, 400);
            this.brandTab.TabIndex = 0;
            this.brandTab.Text = "Edytuj Marki";
            this.brandTab.UseVisualStyleBackColor = true;
            this.brandTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // AddPanel
            // 
            this.AddPanel.BackColor = System.Drawing.Color.Transparent;
            this.AddPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddPanel.Controls.Add(this.ErrorLabelAdd);
            this.AddPanel.Controls.Add(this.AddTitle);
            this.AddPanel.Controls.Add(this.AddBrand);
            this.AddPanel.Controls.Add(this.label4);
            this.AddPanel.Controls.Add(this.carBrandTextBox);
            this.AddPanel.Location = new System.Drawing.Point(77, 64);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(271, 114);
            this.AddPanel.TabIndex = 9;
            // 
            // ErrorLabelAdd
            // 
            this.ErrorLabelAdd.AutoSize = true;
            this.ErrorLabelAdd.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabelAdd.Location = new System.Drawing.Point(17, 82);
            this.ErrorLabelAdd.Name = "ErrorLabelAdd";
            this.ErrorLabelAdd.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabelAdd.TabIndex = 10;
            // 
            // AddTitle
            // 
            this.AddTitle.AutoSize = true;
            this.AddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddTitle.Location = new System.Drawing.Point(84, 0);
            this.AddTitle.Name = "AddTitle";
            this.AddTitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.AddTitle.Size = new System.Drawing.Size(110, 25);
            this.AddTitle.TabIndex = 8;
            this.AddTitle.Text = "Dodaj Markę";
            // 
            // AddBrand
            // 
            this.AddBrand.Location = new System.Drawing.Point(153, 70);
            this.AddBrand.Name = "AddBrand";
            this.AddBrand.Size = new System.Drawing.Size(100, 25);
            this.AddBrand.TabIndex = 3;
            this.AddBrand.Text = "Dodaj";
            this.AddBrand.UseVisualStyleBackColor = true;
            this.AddBrand.Click += new System.EventHandler(this.AddBrand_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(17, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marka Samochodu";
            // 
            // carBrandTextBox
            // 
            this.carBrandTextBox.Location = new System.Drawing.Point(153, 43);
            this.carBrandTextBox.Name = "carBrandTextBox";
            this.carBrandTextBox.Size = new System.Drawing.Size(100, 20);
            this.carBrandTextBox.TabIndex = 1;
            // 
            // DeletePanel
            // 
            this.DeletePanel.BackColor = System.Drawing.Color.Transparent;
            this.DeletePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeletePanel.Controls.Add(this.ErrorLabelDelete);
            this.DeletePanel.Controls.Add(this.DeleteTitle);
            this.DeletePanel.Controls.Add(this.DeleteBrand);
            this.DeletePanel.Controls.Add(this.label1);
            this.DeletePanel.Controls.Add(this.brandsComboBox);
            this.DeletePanel.Location = new System.Drawing.Point(77, 221);
            this.DeletePanel.Name = "DeletePanel";
            this.DeletePanel.Size = new System.Drawing.Size(271, 114);
            this.DeletePanel.TabIndex = 7;
            // 
            // ErrorLabelDelete
            // 
            this.ErrorLabelDelete.AutoSize = true;
            this.ErrorLabelDelete.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabelDelete.Location = new System.Drawing.Point(17, 76);
            this.ErrorLabelDelete.Name = "ErrorLabelDelete";
            this.ErrorLabelDelete.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabelDelete.TabIndex = 9;
            // 
            // DeleteTitle
            // 
            this.DeleteTitle.AutoSize = true;
            this.DeleteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteTitle.Location = new System.Drawing.Point(89, -1);
            this.DeleteTitle.Name = "DeleteTitle";
            this.DeleteTitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.DeleteTitle.Size = new System.Drawing.Size(105, 25);
            this.DeleteTitle.TabIndex = 8;
            this.DeleteTitle.Text = "Usuń Markę";
            // 
            // DeleteBrand
            // 
            this.DeleteBrand.Location = new System.Drawing.Point(153, 70);
            this.DeleteBrand.Name = "DeleteBrand";
            this.DeleteBrand.Size = new System.Drawing.Size(100, 25);
            this.DeleteBrand.TabIndex = 7;
            this.DeleteBrand.Text = "Usuń";
            this.DeleteBrand.UseVisualStyleBackColor = true;
            this.DeleteBrand.Click += new System.EventHandler(this.DeleteBrand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marka Samochodu";
            // 
            // brandsComboBox
            // 
            this.brandsComboBox.FormattingEnabled = true;
            this.brandsComboBox.Location = new System.Drawing.Point(153, 42);
            this.brandsComboBox.Name = "brandsComboBox";
            this.brandsComboBox.Size = new System.Drawing.Size(100, 21);
            this.brandsComboBox.TabIndex = 5;
            this.brandsComboBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // brandsDataView
            // 
            this.brandsDataView.AllowUserToAddRows = false;
            this.brandsDataView.AllowUserToDeleteRows = false;
            this.brandsDataView.AllowUserToResizeColumns = false;
            this.brandsDataView.AllowUserToResizeRows = false;
            this.brandsDataView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.brandsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brandsDataView.Location = new System.Drawing.Point(427, 64);
            this.brandsDataView.Name = "brandsDataView";
            this.brandsDataView.ReadOnly = true;
            this.brandsDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.brandsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.brandsDataView.Size = new System.Drawing.Size(267, 271);
            this.brandsDataView.TabIndex = 2;
            // 
            // modelTab
            // 
            this.modelTab.Controls.Add(this.panel2);
            this.modelTab.Controls.Add(this.panel1);
            this.modelTab.Controls.Add(this.modelsDataView);
            this.modelTab.Location = new System.Drawing.Point(4, 22);
            this.modelTab.Name = "modelTab";
            this.modelTab.Padding = new System.Windows.Forms.Padding(3);
            this.modelTab.Size = new System.Drawing.Size(768, 400);
            this.modelTab.TabIndex = 1;
            this.modelTab.Text = "Edytuj Modele";
            this.modelTab.UseVisualStyleBackColor = true;
            this.modelTab.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.errorLabelModelDelete);
            this.panel2.Controls.Add(this.modelsComboBox);
            this.panel2.Controls.Add(this.deleteModelButton);
            this.panel2.Controls.Add(this.modelDeleteText);
            this.panel2.Controls.Add(this.brandDeleteText);
            this.panel2.Controls.Add(this.modelTabDeleteBrandsComboBox);
            this.panel2.Location = new System.Drawing.Point(50, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 155);
            this.panel2.TabIndex = 1;
            // 
            // errorLabelModelDelete
            // 
            this.errorLabelModelDelete.AutoSize = true;
            this.errorLabelModelDelete.ForeColor = System.Drawing.Color.Red;
            this.errorLabelModelDelete.Location = new System.Drawing.Point(40, 101);
            this.errorLabelModelDelete.Name = "errorLabelModelDelete";
            this.errorLabelModelDelete.Size = new System.Drawing.Size(0, 13);
            this.errorLabelModelDelete.TabIndex = 1;
            // 
            // modelsComboBox
            // 
            this.modelsComboBox.FormattingEnabled = true;
            this.modelsComboBox.Location = new System.Drawing.Point(147, 74);
            this.modelsComboBox.Name = "modelsComboBox";
            this.modelsComboBox.Size = new System.Drawing.Size(100, 21);
            this.modelsComboBox.TabIndex = 1;
            // 
            // deleteModelButton
            // 
            this.deleteModelButton.Location = new System.Drawing.Point(147, 112);
            this.deleteModelButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.deleteModelButton.Name = "deleteModelButton";
            this.deleteModelButton.Size = new System.Drawing.Size(100, 26);
            this.deleteModelButton.TabIndex = 1;
            this.deleteModelButton.Text = "Usuń";
            this.deleteModelButton.UseVisualStyleBackColor = true;
            this.deleteModelButton.Click += new System.EventHandler(this.deleteModelButton_Click);
            // 
            // modelDeleteText
            // 
            this.modelDeleteText.AutoSize = true;
            this.modelDeleteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modelDeleteText.Location = new System.Drawing.Point(52, 75);
            this.modelDeleteText.Name = "modelDeleteText";
            this.modelDeleteText.Size = new System.Drawing.Size(48, 16);
            this.modelDeleteText.TabIndex = 1;
            this.modelDeleteText.Text = "Model:";
            this.modelDeleteText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // brandDeleteText
            // 
            this.brandDeleteText.AutoSize = true;
            this.brandDeleteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brandDeleteText.Location = new System.Drawing.Point(52, 36);
            this.brandDeleteText.Name = "brandDeleteText";
            this.brandDeleteText.Size = new System.Drawing.Size(48, 16);
            this.brandDeleteText.TabIndex = 1;
            this.brandDeleteText.Text = "Marka:";
            // 
            // modelTabDeleteBrandsComboBox
            // 
            this.modelTabDeleteBrandsComboBox.FormattingEnabled = true;
            this.modelTabDeleteBrandsComboBox.Location = new System.Drawing.Point(147, 35);
            this.modelTabDeleteBrandsComboBox.Name = "modelTabDeleteBrandsComboBox";
            this.modelTabDeleteBrandsComboBox.Size = new System.Drawing.Size(100, 21);
            this.modelTabDeleteBrandsComboBox.TabIndex = 1;
            this.modelTabDeleteBrandsComboBox.SelectedValueChanged += new System.EventHandler(this.modelTabDeleteBrandsComboBox_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.errorLabelModelAdd);
            this.panel1.Controls.Add(this.addModelButton);
            this.panel1.Controls.Add(this.modelAddText);
            this.panel1.Controls.Add(this.brandAddText);
            this.panel1.Controls.Add(this.modelTabAddBrandsComboBox);
            this.panel1.Controls.Add(this.modelTextBox);
            this.panel1.Location = new System.Drawing.Point(50, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 155);
            this.panel1.TabIndex = 1;
            // 
            // errorLabelModelAdd
            // 
            this.errorLabelModelAdd.AutoSize = true;
            this.errorLabelModelAdd.ForeColor = System.Drawing.Color.Red;
            this.errorLabelModelAdd.Location = new System.Drawing.Point(40, 102);
            this.errorLabelModelAdd.Name = "errorLabelModelAdd";
            this.errorLabelModelAdd.Size = new System.Drawing.Size(0, 13);
            this.errorLabelModelAdd.TabIndex = 2;
            // 
            // addModelButton
            // 
            this.addModelButton.Location = new System.Drawing.Point(147, 111);
            this.addModelButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.addModelButton.Name = "addModelButton";
            this.addModelButton.Size = new System.Drawing.Size(100, 26);
            this.addModelButton.TabIndex = 1;
            this.addModelButton.Text = "Dodaj";
            this.addModelButton.UseVisualStyleBackColor = true;
            this.addModelButton.Click += new System.EventHandler(this.addModelButton_Click);
            // 
            // modelAddText
            // 
            this.modelAddText.AutoSize = true;
            this.modelAddText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modelAddText.Location = new System.Drawing.Point(52, 80);
            this.modelAddText.Name = "modelAddText";
            this.modelAddText.Size = new System.Drawing.Size(48, 16);
            this.modelAddText.TabIndex = 1;
            this.modelAddText.Text = "Model:";
            this.modelAddText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // brandAddText
            // 
            this.brandAddText.AutoSize = true;
            this.brandAddText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brandAddText.Location = new System.Drawing.Point(52, 40);
            this.brandAddText.Name = "brandAddText";
            this.brandAddText.Size = new System.Drawing.Size(48, 16);
            this.brandAddText.TabIndex = 1;
            this.brandAddText.Text = "Marka:";
            // 
            // modelTabAddBrandsComboBox
            // 
            this.modelTabAddBrandsComboBox.FormattingEnabled = true;
            this.modelTabAddBrandsComboBox.Location = new System.Drawing.Point(147, 35);
            this.modelTabAddBrandsComboBox.Name = "modelTabAddBrandsComboBox";
            this.modelTabAddBrandsComboBox.Size = new System.Drawing.Size(100, 21);
            this.modelTabAddBrandsComboBox.TabIndex = 1;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(147, 76);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 1;
            // 
            // modelsDataView
            // 
            this.modelsDataView.AllowUserToAddRows = false;
            this.modelsDataView.AllowUserToDeleteRows = false;
            this.modelsDataView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.modelsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelsDataView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.modelsDataView.Location = new System.Drawing.Point(387, 43);
            this.modelsDataView.Name = "modelsDataView";
            this.modelsDataView.ReadOnly = true;
            this.modelsDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.modelsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modelsDataView.Size = new System.Drawing.Size(339, 335);
            this.modelsDataView.TabIndex = 1;
            // 
            // carTab
            // 
            this.carTab.Controls.Add(this.deleteCarPanel);
            this.carTab.Controls.Add(this.addCarPanel);
            this.carTab.Controls.Add(this.carDataGridView);
            this.carTab.Location = new System.Drawing.Point(4, 22);
            this.carTab.Name = "carTab";
            this.carTab.Padding = new System.Windows.Forms.Padding(3);
            this.carTab.Size = new System.Drawing.Size(768, 400);
            this.carTab.TabIndex = 1;
            this.carTab.Text = "Edytuj Samochody";
            this.carTab.UseVisualStyleBackColor = true;
            this.carTab.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // deleteCarPanel
            // 
            this.deleteCarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteCarPanel.Controls.Add(this.deleteCarErrorLabel);
            this.deleteCarPanel.Controls.Add(this.carDeleteRegistrationComboBox);
            this.deleteCarPanel.Controls.Add(this.panelTitleDeleteCar);
            this.deleteCarPanel.Controls.Add(this.label8);
            this.deleteCarPanel.Controls.Add(this.label9);
            this.deleteCarPanel.Controls.Add(this.deleteCarModelComboBox);
            this.deleteCarPanel.Controls.Add(this.deleteCarBrandComboBox);
            this.deleteCarPanel.Controls.Add(this.deleteCarButton);
            this.deleteCarPanel.Controls.Add(this.label10);
            this.deleteCarPanel.Location = new System.Drawing.Point(251, 52);
            this.deleteCarPanel.Name = "deleteCarPanel";
            this.deleteCarPanel.Size = new System.Drawing.Size(199, 297);
            this.deleteCarPanel.TabIndex = 10;
            // 
            // panelTitleDeleteCar
            // 
            this.panelTitleDeleteCar.AutoSize = true;
            this.panelTitleDeleteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelTitleDeleteCar.Location = new System.Drawing.Point(56, 9);
            this.panelTitleDeleteCar.Name = "panelTitleDeleteCar";
            this.panelTitleDeleteCar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelTitleDeleteCar.Size = new System.Drawing.Size(94, 45);
            this.panelTitleDeleteCar.TabIndex = 9;
            this.panelTitleDeleteCar.Text = "Usuń \r\nSamochód";
            this.panelTitleDeleteCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Marka:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Model:";
            // 
            // deleteCarModelComboBox
            // 
            this.deleteCarModelComboBox.FormattingEnabled = true;
            this.deleteCarModelComboBox.Location = new System.Drawing.Point(79, 138);
            this.deleteCarModelComboBox.Name = "deleteCarModelComboBox";
            this.deleteCarModelComboBox.Size = new System.Drawing.Size(100, 21);
            this.deleteCarModelComboBox.TabIndex = 5;
            this.deleteCarModelComboBox.SelectedValueChanged += new System.EventHandler(this.deleteCarModelComboBox_SelectedValueChanged);
            // 
            // deleteCarBrandComboBox
            // 
            this.deleteCarBrandComboBox.FormattingEnabled = true;
            this.deleteCarBrandComboBox.Location = new System.Drawing.Point(79, 85);
            this.deleteCarBrandComboBox.Name = "deleteCarBrandComboBox";
            this.deleteCarBrandComboBox.Size = new System.Drawing.Size(100, 21);
            this.deleteCarBrandComboBox.TabIndex = 4;
            this.deleteCarBrandComboBox.SelectedValueChanged += new System.EventHandler(this.deleteCarBrandComboBox_SelectedValueChanged);
            // 
            // deleteCarButton
            // 
            this.deleteCarButton.Location = new System.Drawing.Point(51, 241);
            this.deleteCarButton.Name = "deleteCarButton";
            this.deleteCarButton.Size = new System.Drawing.Size(87, 30);
            this.deleteCarButton.TabIndex = 3;
            this.deleteCarButton.Text = "Usuń";
            this.deleteCarButton.UseVisualStyleBackColor = true;
            this.deleteCarButton.Click += new System.EventHandler(this.deleteCarButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Rejestracja:";
            // 
            // addCarPanel
            // 
            this.addCarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addCarPanel.Controls.Add(this.errorLabelCarAdd);
            this.addCarPanel.Controls.Add(this.panelTitleAddCar);
            this.addCarPanel.Controls.Add(this.label2);
            this.addCarPanel.Controls.Add(this.label3);
            this.addCarPanel.Controls.Add(this.addCarRegistrationTextBox);
            this.addCarPanel.Controls.Add(this.addCarModelComboBox);
            this.addCarPanel.Controls.Add(this.addCarBrandComboBox);
            this.addCarPanel.Controls.Add(this.addCarButton);
            this.addCarPanel.Controls.Add(this.label5);
            this.addCarPanel.Location = new System.Drawing.Point(22, 52);
            this.addCarPanel.Name = "addCarPanel";
            this.addCarPanel.Size = new System.Drawing.Size(199, 297);
            this.addCarPanel.TabIndex = 3;
            // 
            // panelTitleAddCar
            // 
            this.panelTitleAddCar.AutoSize = true;
            this.panelTitleAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelTitleAddCar.Location = new System.Drawing.Point(56, 9);
            this.panelTitleAddCar.Name = "panelTitleAddCar";
            this.panelTitleAddCar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelTitleAddCar.Size = new System.Drawing.Size(94, 45);
            this.panelTitleAddCar.TabIndex = 9;
            this.panelTitleAddCar.Text = "Dodaj \r\nSamochód";
            this.panelTitleAddCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Model:";
            // 
            // addCarRegistrationTextBox
            // 
            this.addCarRegistrationTextBox.Location = new System.Drawing.Point(79, 186);
            this.addCarRegistrationTextBox.Name = "addCarRegistrationTextBox";
            this.addCarRegistrationTextBox.Size = new System.Drawing.Size(100, 20);
            this.addCarRegistrationTextBox.TabIndex = 6;
            // 
            // addCarModelComboBox
            // 
            this.addCarModelComboBox.FormattingEnabled = true;
            this.addCarModelComboBox.Location = new System.Drawing.Point(79, 138);
            this.addCarModelComboBox.Name = "addCarModelComboBox";
            this.addCarModelComboBox.Size = new System.Drawing.Size(100, 21);
            this.addCarModelComboBox.TabIndex = 5;
            // 
            // addCarBrandComboBox
            // 
            this.addCarBrandComboBox.FormattingEnabled = true;
            this.addCarBrandComboBox.Location = new System.Drawing.Point(79, 85);
            this.addCarBrandComboBox.Name = "addCarBrandComboBox";
            this.addCarBrandComboBox.Size = new System.Drawing.Size(100, 21);
            this.addCarBrandComboBox.TabIndex = 4;
            this.addCarBrandComboBox.SelectedValueChanged += new System.EventHandler(this.addCarBrandComboBox_SelectedValueChanged);
            // 
            // addCarButton
            // 
            this.addCarButton.Location = new System.Drawing.Point(51, 241);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(87, 30);
            this.addCarButton.TabIndex = 3;
            this.addCarButton.Text = "Dodaj";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Rejestracja:";
            // 
            // carDataGridView
            // 
            this.carDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.carDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carDataGridView.Location = new System.Drawing.Point(482, 52);
            this.carDataGridView.Name = "carDataGridView";
            this.carDataGridView.Size = new System.Drawing.Size(264, 297);
            this.carDataGridView.TabIndex = 2;
            // 
            // carDeleteRegistrationComboBox
            // 
            this.carDeleteRegistrationComboBox.FormattingEnabled = true;
            this.carDeleteRegistrationComboBox.Location = new System.Drawing.Point(79, 186);
            this.carDeleteRegistrationComboBox.Name = "carDeleteRegistrationComboBox";
            this.carDeleteRegistrationComboBox.Size = new System.Drawing.Size(100, 21);
            this.carDeleteRegistrationComboBox.TabIndex = 10;
            // 
            // errorLabelCarAdd
            // 
            this.errorLabelCarAdd.AutoSize = true;
            this.errorLabelCarAdd.ForeColor = System.Drawing.Color.Red;
            this.errorLabelCarAdd.Location = new System.Drawing.Point(17, 225);
            this.errorLabelCarAdd.Name = "errorLabelCarAdd";
            this.errorLabelCarAdd.Size = new System.Drawing.Size(0, 13);
            this.errorLabelCarAdd.TabIndex = 10;
            // 
            // deleteCarErrorLabel
            // 
            this.deleteCarErrorLabel.AutoSize = true;
            this.deleteCarErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.deleteCarErrorLabel.Location = new System.Drawing.Point(13, 225);
            this.deleteCarErrorLabel.Name = "deleteCarErrorLabel";
            this.deleteCarErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.deleteCarErrorLabel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(86, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dodaj Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(86, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Usuń Model";
            // 
            // EditDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataBaseOptions);
            this.Name = "EditDataBase";
            this.Text = "Edytuj Bazę Danych";
            this.DataBaseOptions.ResumeLayout(false);
            this.brandTab.ResumeLayout(false);
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.DeletePanel.ResumeLayout(false);
            this.DeletePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandsDataView)).EndInit();
            this.modelTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataView)).EndInit();
            this.carTab.ResumeLayout(false);
            this.deleteCarPanel.ResumeLayout(false);
            this.deleteCarPanel.PerformLayout();
            this.addCarPanel.ResumeLayout(false);
            this.addCarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //Brand
        private System.Windows.Forms.TabControl DataBaseOptions;
        private System.Windows.Forms.TabPage brandTab;
        private System.Windows.Forms.TabPage modelTab;
        private System.Windows.Forms.TabPage carTab;
        private System.Windows.Forms.Button AddBrand;
        private System.Windows.Forms.DataGridView brandsDataView;
        private System.Windows.Forms.TextBox carBrandTextBox;
        private System.Windows.Forms.ComboBox brandsComboBox;
        private System.Windows.Forms.Panel DeletePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DeleteTitle;
        private System.Windows.Forms.Button DeleteBrand;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Label AddTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ErrorLabelDelete;
        private System.Windows.Forms.Label ErrorLabelAdd;
        
        //Model
        private System.Windows.Forms.DataGridView modelsDataView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox modelTabAddBrandsComboBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label modelAddText;
        private System.Windows.Forms.Label brandAddText;
        private System.Windows.Forms.Button addModelButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox modelsComboBox;
        private System.Windows.Forms.Button deleteModelButton;
        private System.Windows.Forms.Label modelDeleteText;
        private System.Windows.Forms.Label brandDeleteText;
        private System.Windows.Forms.ComboBox modelTabDeleteBrandsComboBox;
        private System.Windows.Forms.Label errorLabelModelDelete;
        private System.Windows.Forms.Label errorLabelModelAdd;

        //Car
        private System.Windows.Forms.DataGridView carDataGridView;
        private System.Windows.Forms.Panel addCarPanel;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addCarRegistrationTextBox;
        private System.Windows.Forms.ComboBox addCarModelComboBox;
        private System.Windows.Forms.ComboBox addCarBrandComboBox;
        private System.Windows.Forms.Label panelTitleAddCar;
        private System.Windows.Forms.Panel deleteCarPanel;
        private System.Windows.Forms.Label panelTitleDeleteCar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox deleteCarModelComboBox;
        private System.Windows.Forms.ComboBox deleteCarBrandComboBox;
        private System.Windows.Forms.Button deleteCarButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox carDeleteRegistrationComboBox;
        private System.Windows.Forms.Label errorLabelCarAdd;
        private System.Windows.Forms.Label deleteCarErrorLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}