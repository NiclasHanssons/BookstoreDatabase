namespace TheBookShelf
{
    partial class AddNewBookForm
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
            this.comboBoxAddNewBook = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectStore = new System.Windows.Forms.ComboBox();
            this.labelAddNewBook = new System.Windows.Forms.Label();
            this.labelSelectStore = new System.Windows.Forms.Label();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.comboBoxSelectStoreRemove = new System.Windows.Forms.ComboBox();
            this.comboBoxRemoveBook = new System.Windows.Forms.ComboBox();
            this.buttonRemoveBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAddNewBook
            // 
            this.comboBoxAddNewBook.FormattingEnabled = true;
            this.comboBoxAddNewBook.Location = new System.Drawing.Point(263, 27);
            this.comboBoxAddNewBook.Name = "comboBoxAddNewBook";
            this.comboBoxAddNewBook.Size = new System.Drawing.Size(245, 23);
            this.comboBoxAddNewBook.TabIndex = 0;
            // 
            // comboBoxSelectStore
            // 
            this.comboBoxSelectStore.FormattingEnabled = true;
            this.comboBoxSelectStore.Location = new System.Drawing.Point(12, 27);
            this.comboBoxSelectStore.Name = "comboBoxSelectStore";
            this.comboBoxSelectStore.Size = new System.Drawing.Size(245, 23);
            this.comboBoxSelectStore.TabIndex = 1;
            // 
            // labelAddNewBook
            // 
            this.labelAddNewBook.AutoSize = true;
            this.labelAddNewBook.Location = new System.Drawing.Point(263, 9);
            this.labelAddNewBook.Name = "labelAddNewBook";
            this.labelAddNewBook.Size = new System.Drawing.Size(27, 15);
            this.labelAddNewBook.TabIndex = 2;
            this.labelAddNewBook.Text = "Bok";
            // 
            // labelSelectStore
            // 
            this.labelSelectStore.AutoSize = true;
            this.labelSelectStore.Location = new System.Drawing.Point(12, 9);
            this.labelSelectStore.Name = "labelSelectStore";
            this.labelSelectStore.Size = new System.Drawing.Size(34, 15);
            this.labelSelectStore.TabIndex = 3;
            this.labelSelectStore.Text = "Butik";
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(520, 27);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(121, 23);
            this.buttonAddBook.TabIndex = 4;
            this.buttonAddBook.Text = "Lägg till bok";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // comboBoxSelectStoreRemove
            // 
            this.comboBoxSelectStoreRemove.FormattingEnabled = true;
            this.comboBoxSelectStoreRemove.Location = new System.Drawing.Point(12, 57);
            this.comboBoxSelectStoreRemove.Name = "comboBoxSelectStoreRemove";
            this.comboBoxSelectStoreRemove.Size = new System.Drawing.Size(245, 23);
            this.comboBoxSelectStoreRemove.TabIndex = 5;
            // 
            // comboBoxRemoveBook
            // 
            this.comboBoxRemoveBook.FormattingEnabled = true;
            this.comboBoxRemoveBook.Location = new System.Drawing.Point(263, 56);
            this.comboBoxRemoveBook.Name = "comboBoxRemoveBook";
            this.comboBoxRemoveBook.Size = new System.Drawing.Size(245, 23);
            this.comboBoxRemoveBook.TabIndex = 6;
            this.comboBoxRemoveBook.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxRemoveBook_MouseClick);
            // 
            // buttonRemoveBook
            // 
            this.buttonRemoveBook.Location = new System.Drawing.Point(520, 55);
            this.buttonRemoveBook.Name = "buttonRemoveBook";
            this.buttonRemoveBook.Size = new System.Drawing.Size(121, 23);
            this.buttonRemoveBook.TabIndex = 7;
            this.buttonRemoveBook.Text = "Ta bort bok";
            this.buttonRemoveBook.UseVisualStyleBackColor = true;
            this.buttonRemoveBook.Click += new System.EventHandler(this.buttonRemoveBook_Click);
            // 
            // AddNewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 97);
            this.Controls.Add(this.buttonRemoveBook);
            this.Controls.Add(this.comboBoxRemoveBook);
            this.Controls.Add(this.comboBoxSelectStoreRemove);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.labelSelectStore);
            this.Controls.Add(this.labelAddNewBook);
            this.Controls.Add(this.comboBoxSelectStore);
            this.Controls.Add(this.comboBoxAddNewBook);
            this.Name = "AddNewBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lägg till & ta bort bok";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddNewBookForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAddNewBook;
        private System.Windows.Forms.ComboBox comboBoxSelectStore;
        private System.Windows.Forms.Label labelAddNewBook;
        private System.Windows.Forms.Label labelSelectStore;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.ComboBox comboBoxSelectStoreRemove;
        private System.Windows.Forms.ComboBox comboBoxRemoveBook;
        private System.Windows.Forms.Button buttonRemoveBook;
    }
}