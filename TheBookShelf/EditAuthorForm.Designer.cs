namespace TheBookShelf
{
    partial class EditAuthorForm
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
            this.dateTimePickerFödelsedatum = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxNationality = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelFödelsedatum = new System.Windows.Forms.Label();
            this.labelEfternamn = new System.Windows.Forms.Label();
            this.labelFörnamn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerFödelsedatum
            // 
            this.dateTimePickerFödelsedatum.Location = new System.Drawing.Point(102, 71);
            this.dateTimePickerFödelsedatum.MaxDate = new System.DateTime(2021, 1, 22, 0, 0, 0, 0);
            this.dateTimePickerFödelsedatum.MaximumSize = new System.Drawing.Size(232, 23);
            this.dateTimePickerFödelsedatum.MinimumSize = new System.Drawing.Size(232, 23);
            this.dateTimePickerFödelsedatum.Name = "dateTimePickerFödelsedatum";
            this.dateTimePickerFödelsedatum.Size = new System.Drawing.Size(232, 23);
            this.dateTimePickerFödelsedatum.TabIndex = 13;
            this.dateTimePickerFödelsedatum.Value = new System.DateTime(2021, 1, 22, 0, 0, 0, 0);
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Kvinna",
            "Man",
            "Ickebinär"});
            this.comboBoxSex.Location = new System.Drawing.Point(102, 101);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(232, 23);
            this.comboBoxSex.TabIndex = 12;
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(178, 161);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(75, 23);
            this.buttonAbort.TabIndex = 11;
            this.buttonAbort.Text = "Avbryt";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(259, 161);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Uppdatera";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxNationality
            // 
            this.textBoxNationality.Location = new System.Drawing.Point(102, 132);
            this.textBoxNationality.MaxLength = 30;
            this.textBoxNationality.Name = "textBoxNationality";
            this.textBoxNationality.Size = new System.Drawing.Size(232, 23);
            this.textBoxNationality.TabIndex = 9;
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(102, 42);
            this.textBoxLastname.MaxLength = 100;
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(232, 23);
            this.textBoxLastname.TabIndex = 6;
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(102, 12);
            this.textBoxFirstname.MaxLength = 100;
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(232, 23);
            this.textBoxFirstname.TabIndex = 5;
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Location = new System.Drawing.Point(10, 135);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(72, 15);
            this.labelNationality.TabIndex = 4;
            this.labelNationality.Text = "Nationalitet:";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(10, 105);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(31, 15);
            this.labelSex.TabIndex = 3;
            this.labelSex.Text = "Kön:";
            // 
            // labelFödelsedatum
            // 
            this.labelFödelsedatum.AutoSize = true;
            this.labelFödelsedatum.Location = new System.Drawing.Point(10, 75);
            this.labelFödelsedatum.Name = "labelFödelsedatum";
            this.labelFödelsedatum.Size = new System.Drawing.Size(85, 15);
            this.labelFödelsedatum.TabIndex = 2;
            this.labelFödelsedatum.Text = "Födelsedatum:";
            // 
            // labelEfternamn
            // 
            this.labelEfternamn.AutoSize = true;
            this.labelEfternamn.Location = new System.Drawing.Point(10, 45);
            this.labelEfternamn.Name = "labelEfternamn";
            this.labelEfternamn.Size = new System.Drawing.Size(65, 15);
            this.labelEfternamn.TabIndex = 1;
            this.labelEfternamn.Text = "Efternamn:";
            // 
            // labelFörnamn
            // 
            this.labelFörnamn.AutoSize = true;
            this.labelFörnamn.Location = new System.Drawing.Point(10, 15);
            this.labelFörnamn.Name = "labelFörnamn";
            this.labelFörnamn.Size = new System.Drawing.Size(58, 15);
            this.labelFörnamn.TabIndex = 0;
            this.labelFörnamn.Text = "Förnamn:";
            // 
            // EditAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 201);
            this.Controls.Add(this.labelFörnamn);
            this.Controls.Add(this.labelEfternamn);
            this.Controls.Add(this.labelFödelsedatum);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelNationality);
            this.Controls.Add(this.textBoxFirstname);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.textBoxNationality);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.dateTimePickerFödelsedatum);
            this.MaximumSize = new System.Drawing.Size(374, 240);
            this.MinimumSize = new System.Drawing.Size(374, 240);
            this.Name = "EditAuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Uppdatera Författare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFödelsedatum;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxNationality;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelFödelsedatum;
        private System.Windows.Forms.Label labelEfternamn;
        private System.Windows.Forms.Label labelFörnamn;
    }
}