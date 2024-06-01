namespace RentCarDocument
{
    partial class InitializeApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitializeApplicationForm));
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.folderPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startApplicationButton = new System.Windows.Forms.Button();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectFolderButton.Location = new System.Drawing.Point(165, 244);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(103, 26);
            this.selectFolderButton.TabIndex = 3;
            this.selectFolderButton.Text = "Wybierz Folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // folderPathTextBox
            // 
            this.folderPathTextBox.Location = new System.Drawing.Point(60, 218);
            this.folderPathTextBox.Name = "folderPathTextBox";
            this.folderPathTextBox.Size = new System.Drawing.Size(208, 20);
            this.folderPathTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Folder zapisu dokumentów:";
            // 
            // startApplicationButton
            // 
            this.startApplicationButton.Location = new System.Drawing.Point(136, 308);
            this.startApplicationButton.Name = "startApplicationButton";
            this.startApplicationButton.Size = new System.Drawing.Size(132, 37);
            this.startApplicationButton.TabIndex = 5;
            this.startApplicationButton.Text = "Uruchom Aplikacje";
            this.startApplicationButton.UseVisualStyleBackColor = true;
            this.startApplicationButton.Click += new System.EventHandler(this.startApplicationButton_Click);
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(147, 88);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(118, 20);
            this.serverTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Serwer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Id użytkownika:";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(147, 123);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(118, 20);
            this.userTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hasło:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(60, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Zaloguj do aplikacji";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(147, 159);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(118, 20);
            this.passwordTextBox.TabIndex = 13;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // InitializeApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 367);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverTextBox);
            this.Controls.Add(this.startApplicationButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderPathTextBox);
            this.Controls.Add(this.selectFolderButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InitializeApplicationForm";
            this.Text = "Inicjacja aplikacji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.TextBox folderPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startApplicationButton;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}