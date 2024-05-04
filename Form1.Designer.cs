namespace RentCarDocument
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.EditDataBaseButton = new System.Windows.Forms.Button();
            this.GenerateAgreementButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditDataBaseButton
            // 
            this.EditDataBaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditDataBaseButton.Location = new System.Drawing.Point(133, 207);
            this.EditDataBaseButton.Name = "EditDataBaseButton";
            this.EditDataBaseButton.Size = new System.Drawing.Size(239, 103);
            this.EditDataBaseButton.TabIndex = 0;
            this.EditDataBaseButton.Text = "Edytuj Bazę Danych";
            this.EditDataBaseButton.UseVisualStyleBackColor = true;
            this.EditDataBaseButton.Click += new System.EventHandler(this.EditDataBaseButton_Click);
            // 
            // GenerateAgreementButton
            // 
            this.GenerateAgreementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GenerateAgreementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GenerateAgreementButton.Location = new System.Drawing.Point(474, 207);
            this.GenerateAgreementButton.Name = "GenerateAgreementButton";
            this.GenerateAgreementButton.Size = new System.Drawing.Size(239, 103);
            this.GenerateAgreementButton.TabIndex = 1;
            this.GenerateAgreementButton.Text = "Generuj Umowę";
            this.GenerateAgreementButton.UseVisualStyleBackColor = true;
            this.GenerateAgreementButton.Click += new System.EventHandler(this.GenerateAgreementButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(126, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Witaj!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateAgreementButton);
            this.Controls.Add(this.EditDataBaseButton);
            this.Name = "MainForm";
            this.Text = "4T-RentCar Generator Umów";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditDataBaseButton;
        private System.Windows.Forms.Button GenerateAgreementButton;
        private System.Windows.Forms.Label label1;
    }
}

