namespace WindowsFormsApp1
{
    partial class Form1
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
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.btnFillCountries = new System.Windows.Forms.Button();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbCountries
            // 
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(16, 16);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(416, 21);
            this.cmbCountries.TabIndex = 0;
            this.cmbCountries.SelectedIndexChanged += new System.EventHandler(this.cmbCountries_SelectedIndexChanged);
            // 
            // btnFillCountries
            // 
            this.btnFillCountries.Location = new System.Drawing.Point(448, 16);
            this.btnFillCountries.Name = "btnFillCountries";
            this.btnFillCountries.Size = new System.Drawing.Size(75, 23);
            this.btnFillCountries.TabIndex = 1;
            this.btnFillCountries.Text = "FillCountries";
            this.btnFillCountries.UseVisualStyleBackColor = true;
            this.btnFillCountries.Click += new System.EventHandler(this.btnFillCountries_Click);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(16, 72);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(416, 21);
            this.cmbCustomers.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.btnFillCountries);
            this.Controls.Add(this.cmbCountries);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.Button btnFillCountries;
        private System.Windows.Forms.ComboBox cmbCustomers;
    }
}

