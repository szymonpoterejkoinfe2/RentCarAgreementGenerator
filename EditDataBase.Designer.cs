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
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.DataBaseOptions.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.DeletePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandsDataView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataBaseOptions
            // 
            this.DataBaseOptions.Controls.Add(this.tabPage1);
            this.DataBaseOptions.Controls.Add(this.tabPage2);
            this.DataBaseOptions.Controls.Add(this.tabPage3);
            this.DataBaseOptions.Location = new System.Drawing.Point(12, 12);
            this.DataBaseOptions.Name = "DataBaseOptions";
            this.DataBaseOptions.SelectedIndex = 0;
            this.DataBaseOptions.Size = new System.Drawing.Size(776, 426);
            this.DataBaseOptions.TabIndex = 5;
            this.DataBaseOptions.SelectedIndexChanged += new System.EventHandler(this.DataBaseOptions_SelectedIndexChanged);
            this.DataBaseOptions.TabIndexChanged += new System.EventHandler(this.DataBaseOptions_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddPanel);
            this.tabPage1.Controls.Add(this.DeletePanel);
            this.tabPage1.Controls.Add(this.brandsDataView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Edytuj Marki";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            this.AddPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AddPanel_Paint);
            // 
            // ErrorLabelAdd
            // 
            this.ErrorLabelAdd.AutoSize = true;
            this.ErrorLabelAdd.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabelAdd.Location = new System.Drawing.Point(17, 82);
            this.ErrorLabelAdd.Name = "ErrorLabelAdd";
            this.ErrorLabelAdd.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabelAdd.TabIndex = 10;
            this.ErrorLabelAdd.Click += new System.EventHandler(this.ErrorLabelAdd_Click);
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
            this.AddTitle.Click += new System.EventHandler(this.AddTitle_Click);
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
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // carBrandTextBox
            // 
            this.carBrandTextBox.Location = new System.Drawing.Point(153, 43);
            this.carBrandTextBox.Name = "carBrandTextBox";
            this.carBrandTextBox.Size = new System.Drawing.Size(100, 20);
            this.carBrandTextBox.TabIndex = 1;
            this.carBrandTextBox.TextChanged += new System.EventHandler(this.carBrandTextBox_TextChanged);
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
            this.DeletePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DeletePanel_Paint);
            // 
            // ErrorLabelDelete
            // 
            this.ErrorLabelDelete.AutoSize = true;
            this.ErrorLabelDelete.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabelDelete.Location = new System.Drawing.Point(17, 76);
            this.ErrorLabelDelete.Name = "ErrorLabelDelete";
            this.ErrorLabelDelete.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabelDelete.TabIndex = 9;
            this.ErrorLabelDelete.Click += new System.EventHandler(this.ErrorLabelDelete_Click);
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
            this.DeleteTitle.Click += new System.EventHandler(this.DeleteTitle_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // brandsComboBox
            // 
            this.brandsComboBox.FormattingEnabled = true;
            this.brandsComboBox.Location = new System.Drawing.Point(153, 42);
            this.brandsComboBox.Name = "brandsComboBox";
            this.brandsComboBox.Size = new System.Drawing.Size(100, 21);
            this.brandsComboBox.TabIndex = 5;
            this.brandsComboBox.SelectedIndexChanged += new System.EventHandler(this.brandsComboBox_SelectedIndexChanged);
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
            this.brandsDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brandsDataView_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edytuj Modele";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(74, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 140);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(52, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(52, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(427, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(267, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edytuj Samochody";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Location = new System.Drawing.Point(74, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 140);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 95);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 26);
            this.button2.TabIndex = 4;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(52, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Model:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(52, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Marka:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(147, 23);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(147, 59);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
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
            this.tabPage1.ResumeLayout(false);
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.DeletePanel.ResumeLayout(false);
            this.DeletePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandsDataView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl DataBaseOptions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}