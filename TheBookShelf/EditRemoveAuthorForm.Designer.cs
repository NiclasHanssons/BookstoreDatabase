namespace TheBookShelf
{
    partial class EditRemoveAuthorForm
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
            this.labelEditRemoveAuthorSelectAuthor = new System.Windows.Forms.Label();
            this.comboBoxEditRemoveAuthorSelectAuthor = new System.Windows.Forms.ComboBox();
            this.buttonEditRemoveAuthorRemove = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewEditRemoveAuthor = new System.Windows.Forms.DataGridView();
            this.buttonEditRemoveAuthorUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditRemoveAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEditRemoveAuthorSelectAuthor
            // 
            this.labelEditRemoveAuthorSelectAuthor.AutoSize = true;
            this.labelEditRemoveAuthorSelectAuthor.Location = new System.Drawing.Point(12, 423);
            this.labelEditRemoveAuthorSelectAuthor.Name = "labelEditRemoveAuthorSelectAuthor";
            this.labelEditRemoveAuthorSelectAuthor.Size = new System.Drawing.Size(61, 15);
            this.labelEditRemoveAuthorSelectAuthor.TabIndex = 0;
            this.labelEditRemoveAuthorSelectAuthor.Text = "Författare:";
            // 
            // comboBoxEditRemoveAuthorSelectAuthor
            // 
            this.comboBoxEditRemoveAuthorSelectAuthor.FormattingEnabled = true;
            this.comboBoxEditRemoveAuthorSelectAuthor.Location = new System.Drawing.Point(79, 420);
            this.comboBoxEditRemoveAuthorSelectAuthor.Name = "comboBoxEditRemoveAuthorSelectAuthor";
            this.comboBoxEditRemoveAuthorSelectAuthor.Size = new System.Drawing.Size(186, 23);
            this.comboBoxEditRemoveAuthorSelectAuthor.TabIndex = 1;
            // 
            // buttonEditRemoveAuthorRemove
            // 
            this.buttonEditRemoveAuthorRemove.Location = new System.Drawing.Point(271, 420);
            this.buttonEditRemoveAuthorRemove.Name = "buttonEditRemoveAuthorRemove";
            this.buttonEditRemoveAuthorRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonEditRemoveAuthorRemove.TabIndex = 2;
            this.buttonEditRemoveAuthorRemove.Text = "Ta bort";
            this.buttonEditRemoveAuthorRemove.UseVisualStyleBackColor = true;
            this.buttonEditRemoveAuthorRemove.Click += new System.EventHandler(this.ButtonEditRemoveAuthorRemove_Click);
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Förnamn";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Efternamn";
            this.LastName.Name = "LastName";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Födelsedatum";
            this.DateOfBirth.Name = "DateOfBirth";
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Kön";
            this.Sex.Name = "Sex";
            // 
            // Nationality
            // 
            this.Nationality.HeaderText = "Nationalitet";
            this.Nationality.Name = "Nationality";
            // 
            // dataGridViewEditRemoveAuthor
            // 
            this.dataGridViewEditRemoveAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEditRemoveAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditRemoveAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.DateOfBirth,
            this.Sex,
            this.Nationality});
            this.dataGridViewEditRemoveAuthor.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEditRemoveAuthor.Name = "dataGridViewEditRemoveAuthor";
            this.dataGridViewEditRemoveAuthor.RowHeadersVisible = false;
            this.dataGridViewEditRemoveAuthor.Size = new System.Drawing.Size(595, 399);
            this.dataGridViewEditRemoveAuthor.TabIndex = 3;
            this.dataGridViewEditRemoveAuthor.Text = "dataGridView1";
            // 
            // buttonEditRemoveAuthorUpdate
            // 
            this.buttonEditRemoveAuthorUpdate.Location = new System.Drawing.Point(352, 420);
            this.buttonEditRemoveAuthorUpdate.Name = "buttonEditRemoveAuthorUpdate";
            this.buttonEditRemoveAuthorUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonEditRemoveAuthorUpdate.TabIndex = 4;
            this.buttonEditRemoveAuthorUpdate.Text = "Uppdatera";
            this.buttonEditRemoveAuthorUpdate.UseVisualStyleBackColor = true;
            // 
            // EditRemoveAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 471);
            this.Controls.Add(this.buttonEditRemoveAuthorUpdate);
            this.Controls.Add(this.dataGridViewEditRemoveAuthor);
            this.Controls.Add(this.buttonEditRemoveAuthorRemove);
            this.Controls.Add(this.comboBoxEditRemoveAuthorSelectAuthor);
            this.Controls.Add(this.labelEditRemoveAuthorSelectAuthor);
            this.Name = "EditRemoveAuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Redigera & ta bort författare";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditRemoveAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditRemoveAuthorSelectAuthor;
        private System.Windows.Forms.ComboBox comboBoxEditRemoveAuthorSelectAuthor;
        private System.Windows.Forms.Button buttonEditRemoveAuthorRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridView dataGridViewEditRemoveAuthor;
        private System.Windows.Forms.Button buttonEditRemoveAuthorUpdate;
    }
}