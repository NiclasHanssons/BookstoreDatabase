namespace TheBookShelf
{
    partial class AddAuthorForm
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
            this.labelAddAuthorFirstName = new System.Windows.Forms.Label();
            this.labelAddAuthorLastName = new System.Windows.Forms.Label();
            this.labelAddAuthorDateOfBirth = new System.Windows.Forms.Label();
            this.labelAddAuthorSex = new System.Windows.Forms.Label();
            this.labelAddAuthorNationality = new System.Windows.Forms.Label();
            this.textBoxAddAuthorFirstName = new System.Windows.Forms.TextBox();
            this.textBoxAddAuthorLastName = new System.Windows.Forms.TextBox();
            this.textBoxAddAuthorNationality = new System.Windows.Forms.TextBox();
            this.buttonFormAddAuthorAdd = new System.Windows.Forms.Button();
            this.buttonFormAddAuthorClear = new System.Windows.Forms.Button();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBirthdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelAddAuthorFirstName
            // 
            this.labelAddAuthorFirstName.AutoSize = true;
            this.labelAddAuthorFirstName.Location = new System.Drawing.Point(13, 16);
            this.labelAddAuthorFirstName.Name = "labelAddAuthorFirstName";
            this.labelAddAuthorFirstName.Size = new System.Drawing.Size(58, 15);
            this.labelAddAuthorFirstName.TabIndex = 0;
            this.labelAddAuthorFirstName.Text = "Förnamn:";
            // 
            // labelAddAuthorLastName
            // 
            this.labelAddAuthorLastName.AutoSize = true;
            this.labelAddAuthorLastName.Location = new System.Drawing.Point(13, 46);
            this.labelAddAuthorLastName.Name = "labelAddAuthorLastName";
            this.labelAddAuthorLastName.Size = new System.Drawing.Size(65, 15);
            this.labelAddAuthorLastName.TabIndex = 1;
            this.labelAddAuthorLastName.Text = "Efternamn:";
            // 
            // labelAddAuthorDateOfBirth
            // 
            this.labelAddAuthorDateOfBirth.AutoSize = true;
            this.labelAddAuthorDateOfBirth.Location = new System.Drawing.Point(13, 76);
            this.labelAddAuthorDateOfBirth.Name = "labelAddAuthorDateOfBirth";
            this.labelAddAuthorDateOfBirth.Size = new System.Drawing.Size(85, 15);
            this.labelAddAuthorDateOfBirth.TabIndex = 2;
            this.labelAddAuthorDateOfBirth.Text = "Födelsedatum:";
            // 
            // labelAddAuthorSex
            // 
            this.labelAddAuthorSex.AutoSize = true;
            this.labelAddAuthorSex.Location = new System.Drawing.Point(13, 106);
            this.labelAddAuthorSex.Name = "labelAddAuthorSex";
            this.labelAddAuthorSex.Size = new System.Drawing.Size(31, 15);
            this.labelAddAuthorSex.TabIndex = 3;
            this.labelAddAuthorSex.Text = "Kön:";
            // 
            // labelAddAuthorNationality
            // 
            this.labelAddAuthorNationality.AutoSize = true;
            this.labelAddAuthorNationality.Location = new System.Drawing.Point(13, 136);
            this.labelAddAuthorNationality.Name = "labelAddAuthorNationality";
            this.labelAddAuthorNationality.Size = new System.Drawing.Size(72, 15);
            this.labelAddAuthorNationality.TabIndex = 4;
            this.labelAddAuthorNationality.Text = "Nationalitet:";
            // 
            // textBoxAddAuthorFirstName
            // 
            this.textBoxAddAuthorFirstName.Location = new System.Drawing.Point(105, 13);
            this.textBoxAddAuthorFirstName.Name = "textBoxAddAuthorFirstName";
            this.textBoxAddAuthorFirstName.Size = new System.Drawing.Size(232, 23);
            this.textBoxAddAuthorFirstName.TabIndex = 5;
            // 
            // textBoxAddAuthorLastName
            // 
            this.textBoxAddAuthorLastName.Location = new System.Drawing.Point(105, 43);
            this.textBoxAddAuthorLastName.Name = "textBoxAddAuthorLastName";
            this.textBoxAddAuthorLastName.Size = new System.Drawing.Size(232, 23);
            this.textBoxAddAuthorLastName.TabIndex = 6;
            // 
            // textBoxAddAuthorNationality
            // 
            this.textBoxAddAuthorNationality.Location = new System.Drawing.Point(105, 133);
            this.textBoxAddAuthorNationality.Name = "textBoxAddAuthorNationality";
            this.textBoxAddAuthorNationality.Size = new System.Drawing.Size(232, 23);
            this.textBoxAddAuthorNationality.TabIndex = 9;
            // 
            // buttonFormAddAuthorAdd
            // 
            this.buttonFormAddAuthorAdd.Location = new System.Drawing.Point(262, 162);
            this.buttonFormAddAuthorAdd.Name = "buttonFormAddAuthorAdd";
            this.buttonFormAddAuthorAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonFormAddAuthorAdd.TabIndex = 10;
            this.buttonFormAddAuthorAdd.Text = "Lägg till";
            this.buttonFormAddAuthorAdd.UseVisualStyleBackColor = true;
            this.buttonFormAddAuthorAdd.Click += new System.EventHandler(this.buttonFormAddAuthorAdd_Click);
            // 
            // buttonFormAddAuthorClear
            // 
            this.buttonFormAddAuthorClear.Location = new System.Drawing.Point(181, 162);
            this.buttonFormAddAuthorClear.Name = "buttonFormAddAuthorClear";
            this.buttonFormAddAuthorClear.Size = new System.Drawing.Size(75, 23);
            this.buttonFormAddAuthorClear.TabIndex = 11;
            this.buttonFormAddAuthorClear.Text = "Rensa";
            this.buttonFormAddAuthorClear.UseVisualStyleBackColor = true;
            this.buttonFormAddAuthorClear.Click += new System.EventHandler(this.buttonFormAddAuthorClear_Click);
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Kvinna",
            "Man"});
            this.comboBoxSex.Location = new System.Drawing.Point(105, 102);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(232, 23);
            this.comboBoxSex.TabIndex = 12;
            // 
            // dateTimePickerBirthdate
            // 
            this.dateTimePickerBirthdate.Location = new System.Drawing.Point(105, 72);
            this.dateTimePickerBirthdate.MaxDate = new System.DateTime(2021, 1, 15, 0, 0, 0, 0);
            this.dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            this.dateTimePickerBirthdate.Size = new System.Drawing.Size(232, 23);
            this.dateTimePickerBirthdate.TabIndex = 13;
            this.dateTimePickerBirthdate.Value = new System.DateTime(2021, 1, 15, 0, 0, 0, 0);
            // 
            // AddAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 201);
            this.Controls.Add(this.dateTimePickerBirthdate);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.buttonFormAddAuthorClear);
            this.Controls.Add(this.buttonFormAddAuthorAdd);
            this.Controls.Add(this.textBoxAddAuthorNationality);
            this.Controls.Add(this.textBoxAddAuthorLastName);
            this.Controls.Add(this.textBoxAddAuthorFirstName);
            this.Controls.Add(this.labelAddAuthorNationality);
            this.Controls.Add(this.labelAddAuthorSex);
            this.Controls.Add(this.labelAddAuthorDateOfBirth);
            this.Controls.Add(this.labelAddAuthorLastName);
            this.Controls.Add(this.labelAddAuthorFirstName);
            this.Name = "AddAuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lägg till författare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddAuthorFirstName;
        private System.Windows.Forms.Label labelAddAuthorLastName;
        private System.Windows.Forms.Label labelAddAuthorDateOfBirth;
        private System.Windows.Forms.Label labelAddAuthorSex;
        private System.Windows.Forms.Label labelAddAuthorNationality;
        private System.Windows.Forms.TextBox textBoxAddAuthorFirstName;
        private System.Windows.Forms.TextBox textBoxAddAuthorLastName;
        private System.Windows.Forms.TextBox textBoxAddAuthorNationality;
        private System.Windows.Forms.Button buttonFormAddAuthorAdd;
        private System.Windows.Forms.Button buttonFormAddAuthorClear;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthdate;
    }
}