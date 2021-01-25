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
            this.dateTimePickerFödelsedatum.Location = new System.Drawing.Point(117, 95);
            this.dateTimePickerFödelsedatum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerFödelsedatum.MaxDate = new System.DateTime(2021, 1, 22, 0, 0, 0, 0);
            this.dateTimePickerFödelsedatum.MaximumSize = new System.Drawing.Size(265, 23);
            this.dateTimePickerFödelsedatum.MinimumSize = new System.Drawing.Size(265, 23);
            this.dateTimePickerFödelsedatum.Name = "dateTimePickerFödelsedatum";
            this.dateTimePickerFödelsedatum.Size = new System.Drawing.Size(265, 23);
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
            this.comboBoxSex.Location = new System.Drawing.Point(117, 135);
            this.comboBoxSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(265, 28);
            this.comboBoxSex.TabIndex = 12;
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(194, 215);
            this.buttonAbort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(86, 31);
            this.buttonAbort.TabIndex = 11;
            this.buttonAbort.Text = "Avbryt";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(286, 215);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(96, 31);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Uppdatera";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxNationality
            // 
            this.textBoxNationality.Location = new System.Drawing.Point(117, 176);
            this.textBoxNationality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNationality.MaxLength = 30;
            this.textBoxNationality.Name = "textBoxNationality";
            this.textBoxNationality.Size = new System.Drawing.Size(265, 27);
            this.textBoxNationality.TabIndex = 9;
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(117, 56);
            this.textBoxLastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLastname.MaxLength = 100;
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(265, 27);
            this.textBoxLastname.TabIndex = 6;
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(117, 16);
            this.textBoxFirstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFirstname.MaxLength = 100;
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(265, 27);
            this.textBoxFirstname.TabIndex = 5;
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Location = new System.Drawing.Point(11, 180);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(91, 20);
            this.labelNationality.TabIndex = 4;
            this.labelNationality.Text = "Nationalitet:";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(11, 140);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(38, 20);
            this.labelSex.TabIndex = 3;
            this.labelSex.Text = "Kön:";
            // 
            // labelFödelsedatum
            // 
            this.labelFödelsedatum.AutoSize = true;
            this.labelFödelsedatum.Location = new System.Drawing.Point(11, 100);
            this.labelFödelsedatum.Name = "labelFödelsedatum";
            this.labelFödelsedatum.Size = new System.Drawing.Size(106, 20);
            this.labelFödelsedatum.TabIndex = 2;
            this.labelFödelsedatum.Text = "Födelsedatum:";
            // 
            // labelEfternamn
            // 
            this.labelEfternamn.AutoSize = true;
            this.labelEfternamn.Location = new System.Drawing.Point(11, 60);
            this.labelEfternamn.Name = "labelEfternamn";
            this.labelEfternamn.Size = new System.Drawing.Size(80, 20);
            this.labelEfternamn.TabIndex = 1;
            this.labelEfternamn.Text = "Efternamn:";
            // 
            // labelFörnamn
            // 
            this.labelFörnamn.AutoSize = true;
            this.labelFörnamn.Location = new System.Drawing.Point(11, 20);
            this.labelFörnamn.Name = "labelFörnamn";
            this.labelFörnamn.Size = new System.Drawing.Size(70, 20);
            this.labelFörnamn.TabIndex = 0;
            this.labelFörnamn.Text = "Förnamn:";
            // 
            // EditAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 257);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(425, 304);
            this.MinimumSize = new System.Drawing.Size(425, 304);
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