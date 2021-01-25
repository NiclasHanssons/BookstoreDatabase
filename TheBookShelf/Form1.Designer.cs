namespace TheBookShelf
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonAddBookToDB = new System.Windows.Forms.Button();
            this.labelDatabas = new System.Windows.Forms.Label();
            this.labelButik = new System.Windows.Forms.Label();
            this.labelUpdateBookStock = new System.Windows.Forms.Label();
            this.buttonEditRemoveBook = new System.Windows.Forms.Button();
            this.buttonEditRemoveAuthor = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelAntal = new System.Windows.Forms.Label();
            this.comboBoxBookForLagersaldo = new System.Windows.Forms.ComboBox();
            this.labelBooksListBox = new System.Windows.Forms.Label();
            this.textBoxButikID = new System.Windows.Forms.TextBox();
            this.labelButikID = new System.Windows.Forms.Label();
            this.labelLand = new System.Windows.Forms.Label();
            this.labelStad = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.textBoxLand = new System.Windows.Forms.TextBox();
            this.textBoxStad = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1902, 1055);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonAddBookToDB);
            this.splitContainer2.Panel1.Controls.Add(this.labelDatabas);
            this.splitContainer2.Panel1.Controls.Add(this.labelButik);
            this.splitContainer2.Panel1.Controls.Add(this.labelUpdateBookStock);
            this.splitContainer2.Panel1.Controls.Add(this.buttonEditRemoveBook);
            this.splitContainer2.Panel1.Controls.Add(this.buttonEditRemoveAuthor);
            this.splitContainer2.Panel1.Controls.Add(this.buttonAddBook);
            this.splitContainer2.Panel1.Controls.Add(this.buttonAddAuthor);
            this.splitContainer2.Panel1.Controls.Add(this.Remove);
            this.splitContainer2.Panel1.Controls.Add(this.buttonAdd);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxAmount);
            this.splitContainer2.Panel1.Controls.Add(this.labelAntal);
            this.splitContainer2.Panel1.Controls.Add(this.comboBoxBookForLagersaldo);
            this.splitContainer2.Panel1.Controls.Add(this.labelBooksListBox);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxButikID);
            this.splitContainer2.Panel1.Controls.Add(this.labelButikID);
            this.splitContainer2.Panel1.Controls.Add(this.labelLand);
            this.splitContainer2.Panel1.Controls.Add(this.labelStad);
            this.splitContainer2.Panel1.Controls.Add(this.labelAdress);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxLand);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxStad);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxAdress);
            this.splitContainer2.Size = new System.Drawing.Size(1591, 1055);
            this.splitContainer2.SplitterDistance = 404;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.Text = "splitContainer2";
            // 
            // buttonAddBookToDB
            // 
            this.buttonAddBookToDB.Location = new System.Drawing.Point(819, 179);
            this.buttonAddBookToDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddBookToDB.Name = "buttonAddBookToDB";
            this.buttonAddBookToDB.Size = new System.Drawing.Size(202, 49);
            this.buttonAddBookToDB.TabIndex = 21;
            this.buttonAddBookToDB.Text = "Lägg till bok";
            this.buttonAddBookToDB.UseVisualStyleBackColor = true;
            this.buttonAddBookToDB.Click += new System.EventHandler(this.buttonAddBookToDB_Click);
            // 
            // labelDatabas
            // 
            this.labelDatabas.AutoSize = true;
            this.labelDatabas.Location = new System.Drawing.Point(819, 40);
            this.labelDatabas.Name = "labelDatabas";
            this.labelDatabas.Size = new System.Drawing.Size(64, 20);
            this.labelDatabas.TabIndex = 20;
            this.labelDatabas.Text = "Databas";
            // 
            // labelButik
            // 
            this.labelButik.AutoSize = true;
            this.labelButik.Location = new System.Drawing.Point(610, 40);
            this.labelButik.Name = "labelButik";
            this.labelButik.Size = new System.Drawing.Size(55, 20);
            this.labelButik.TabIndex = 19;
            this.labelButik.Text = "Butiker";
            // 
            // labelUpdateBookStock
            // 
            this.labelUpdateBookStock.AutoSize = true;
            this.labelUpdateBookStock.Location = new System.Drawing.Point(413, 168);
            this.labelUpdateBookStock.Name = "labelUpdateBookStock";
            this.labelUpdateBookStock.Size = new System.Drawing.Size(154, 20);
            this.labelUpdateBookStock.TabIndex = 18;
            this.labelUpdateBookStock.Text = "Uppdatera lagersaldo";
            // 
            // buttonEditRemoveBook
            // 
            this.buttonEditRemoveBook.Location = new System.Drawing.Point(819, 236);
            this.buttonEditRemoveBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditRemoveBook.Name = "buttonEditRemoveBook";
            this.buttonEditRemoveBook.Size = new System.Drawing.Size(202, 49);
            this.buttonEditRemoveBook.TabIndex = 17;
            this.buttonEditRemoveBook.Text = "Redigera/Ta bort bok";
            this.buttonEditRemoveBook.UseVisualStyleBackColor = true;
            this.buttonEditRemoveBook.Click += new System.EventHandler(this.buttonEditRemoveBook_Click);
            // 
            // buttonEditRemoveAuthor
            // 
            this.buttonEditRemoveAuthor.Location = new System.Drawing.Point(819, 121);
            this.buttonEditRemoveAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditRemoveAuthor.Name = "buttonEditRemoveAuthor";
            this.buttonEditRemoveAuthor.Size = new System.Drawing.Size(202, 49);
            this.buttonEditRemoveAuthor.TabIndex = 16;
            this.buttonEditRemoveAuthor.Text = "Redigera/Ta bort författare";
            this.buttonEditRemoveAuthor.UseVisualStyleBackColor = true;
            this.buttonEditRemoveAuthor.Click += new System.EventHandler(this.ButtonEditRemoveAuthor_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddBook.Location = new System.Drawing.Point(610, 65);
            this.buttonAddBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(202, 49);
            this.buttonAddBook.TabIndex = 15;
            this.buttonAddBook.Text = "Lägg till/ta bort bok";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(819, 64);
            this.buttonAddAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(202, 49);
            this.buttonAddAuthor.TabIndex = 14;
            this.buttonAddAuthor.Text = "Lägg till författare";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.ButtonAddAuthor_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(413, 272);
            this.Remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(136, 31);
            this.Remove.TabIndex = 13;
            this.Remove.Text = "Ta bort";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(413, 232);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(136, 31);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Lägg till";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(413, 192);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(135, 27);
            this.textBoxAmount.TabIndex = 11;
            // 
            // labelAntal
            // 
            this.labelAntal.AutoSize = true;
            this.labelAntal.Location = new System.Drawing.Point(362, 197);
            this.labelAntal.Name = "labelAntal";
            this.labelAntal.Size = new System.Drawing.Size(47, 20);
            this.labelAntal.TabIndex = 10;
            this.labelAntal.Text = "Antal:";
            // 
            // comboBoxBookForLagersaldo
            // 
            this.comboBoxBookForLagersaldo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBookForLagersaldo.FormattingEnabled = true;
            this.comboBoxBookForLagersaldo.Location = new System.Drawing.Point(65, 193);
            this.comboBoxBookForLagersaldo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxBookForLagersaldo.Name = "comboBoxBookForLagersaldo";
            this.comboBoxBookForLagersaldo.Size = new System.Drawing.Size(270, 28);
            this.comboBoxBookForLagersaldo.TabIndex = 9;
            // 
            // labelBooksListBox
            // 
            this.labelBooksListBox.AutoSize = true;
            this.labelBooksListBox.Location = new System.Drawing.Point(24, 197);
            this.labelBooksListBox.Name = "labelBooksListBox";
            this.labelBooksListBox.Size = new System.Drawing.Size(37, 20);
            this.labelBooksListBox.TabIndex = 8;
            this.labelBooksListBox.Text = "Bok:";
            // 
            // textBoxButikID
            // 
            this.textBoxButikID.Location = new System.Drawing.Point(65, 36);
            this.textBoxButikID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxButikID.Name = "textBoxButikID";
            this.textBoxButikID.ReadOnly = true;
            this.textBoxButikID.Size = new System.Drawing.Size(54, 27);
            this.textBoxButikID.TabIndex = 7;
            // 
            // labelButikID
            // 
            this.labelButikID.AutoSize = true;
            this.labelButikID.Location = new System.Drawing.Point(3, 40);
            this.labelButikID.Name = "labelButikID";
            this.labelButikID.Size = new System.Drawing.Size(60, 20);
            this.labelButikID.TabIndex = 6;
            this.labelButikID.Text = "ButikID:";
            // 
            // labelLand
            // 
            this.labelLand.AutoSize = true;
            this.labelLand.Location = new System.Drawing.Point(17, 156);
            this.labelLand.Name = "labelLand";
            this.labelLand.Size = new System.Drawing.Size(44, 20);
            this.labelLand.TabIndex = 5;
            this.labelLand.Text = "Land:";
            // 
            // labelStad
            // 
            this.labelStad.AutoSize = true;
            this.labelStad.Location = new System.Drawing.Point(21, 117);
            this.labelStad.Name = "labelStad";
            this.labelStad.Size = new System.Drawing.Size(42, 20);
            this.labelStad.TabIndex = 4;
            this.labelStad.Text = "Stad:";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(7, 79);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(56, 20);
            this.labelAdress.TabIndex = 3;
            this.labelAdress.Text = "Adress:";
            // 
            // textBoxLand
            // 
            this.textBoxLand.Location = new System.Drawing.Point(65, 152);
            this.textBoxLand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLand.Name = "textBoxLand";
            this.textBoxLand.ReadOnly = true;
            this.textBoxLand.Size = new System.Drawing.Size(269, 27);
            this.textBoxLand.TabIndex = 2;
            // 
            // textBoxStad
            // 
            this.textBoxStad.Location = new System.Drawing.Point(65, 113);
            this.textBoxStad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStad.Name = "textBoxStad";
            this.textBoxStad.ReadOnly = true;
            this.textBoxStad.Size = new System.Drawing.Size(269, 27);
            this.textBoxStad.TabIndex = 1;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(65, 75);
            this.textBoxAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.ReadOnly = true;
            this.textBoxAdress.Size = new System.Drawing.Size(269, 27);
            this.textBoxAdress.TabIndex = 0;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1055);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1917, 1040);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Bookshelf";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label labelLand;
        private System.Windows.Forms.Label labelStad;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.TextBox textBoxLand;
        private System.Windows.Forms.TextBox textBoxStad;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxButikID;
        private System.Windows.Forms.Label labelButikID;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Label labelBooksListBox;
        private System.Windows.Forms.ComboBox comboBoxBookForLagersaldo;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelAntal;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Button buttonEditRemoveBook;
        private System.Windows.Forms.Button buttonEditRemoveAuthor;
        private System.Windows.Forms.Label labelUpdateBookStock;
        private System.Windows.Forms.Button buttonAddBookToDB;
        private System.Windows.Forms.Label labelDatabas;
        private System.Windows.Forms.Label labelButik;
    }
}

