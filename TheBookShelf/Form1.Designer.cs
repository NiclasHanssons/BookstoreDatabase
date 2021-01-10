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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
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
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1664, 1011);
            this.splitContainer1.SplitterDistance = 269;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
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
            this.splitContainer2.Size = new System.Drawing.Size(1391, 1011);
            this.splitContainer2.SplitterDistance = 389;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.Text = "splitContainer2";
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(361, 204);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 13;
            this.Remove.Text = "Ta bort";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(361, 174);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Lägg till";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(361, 144);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 23);
            this.textBoxAmount.TabIndex = 11;
            // 
            // labelAntal
            // 
            this.labelAntal.AutoSize = true;
            this.labelAntal.Location = new System.Drawing.Point(317, 148);
            this.labelAntal.Name = "labelAntal";
            this.labelAntal.Size = new System.Drawing.Size(38, 15);
            this.labelAntal.TabIndex = 10;
            this.labelAntal.Text = "Antal:";
            // 
            // comboBoxBookForLagersaldo
            // 
            this.comboBoxBookForLagersaldo.FormattingEnabled = true;
            this.comboBoxBookForLagersaldo.Location = new System.Drawing.Point(57, 145);
            this.comboBoxBookForLagersaldo.Name = "comboBoxBookForLagersaldo";
            this.comboBoxBookForLagersaldo.Size = new System.Drawing.Size(237, 23);
            this.comboBoxBookForLagersaldo.TabIndex = 9;
            // 
            // labelBooksListBox
            // 
            this.labelBooksListBox.AutoSize = true;
            this.labelBooksListBox.Location = new System.Drawing.Point(21, 148);
            this.labelBooksListBox.Name = "labelBooksListBox";
            this.labelBooksListBox.Size = new System.Drawing.Size(30, 15);
            this.labelBooksListBox.TabIndex = 8;
            this.labelBooksListBox.Text = "Bok:";
            // 
            // textBoxButikID
            // 
            this.textBoxButikID.Location = new System.Drawing.Point(57, 27);
            this.textBoxButikID.Name = "textBoxButikID";
            this.textBoxButikID.Size = new System.Drawing.Size(48, 23);
            this.textBoxButikID.TabIndex = 7;
            // 
            // labelButikID
            // 
            this.labelButikID.AutoSize = true;
            this.labelButikID.Location = new System.Drawing.Point(3, 30);
            this.labelButikID.Name = "labelButikID";
            this.labelButikID.Size = new System.Drawing.Size(48, 15);
            this.labelButikID.TabIndex = 6;
            this.labelButikID.Text = "ButikID:";
            // 
            // labelLand
            // 
            this.labelLand.AutoSize = true;
            this.labelLand.Location = new System.Drawing.Point(15, 117);
            this.labelLand.Name = "labelLand";
            this.labelLand.Size = new System.Drawing.Size(36, 15);
            this.labelLand.TabIndex = 5;
            this.labelLand.Text = "Land:";
            // 
            // labelStad
            // 
            this.labelStad.AutoSize = true;
            this.labelStad.Location = new System.Drawing.Point(18, 88);
            this.labelStad.Name = "labelStad";
            this.labelStad.Size = new System.Drawing.Size(33, 15);
            this.labelStad.TabIndex = 4;
            this.labelStad.Text = "Stad:";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(6, 59);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(45, 15);
            this.labelAdress.TabIndex = 3;
            this.labelAdress.Text = "Adress:";
            // 
            // textBoxLand
            // 
            this.textBoxLand.Location = new System.Drawing.Point(57, 114);
            this.textBoxLand.Name = "textBoxLand";
            this.textBoxLand.Size = new System.Drawing.Size(236, 23);
            this.textBoxLand.TabIndex = 2;
            // 
            // textBoxStad
            // 
            this.textBoxStad.Location = new System.Drawing.Point(57, 85);
            this.textBoxStad.Name = "textBoxStad";
            this.textBoxStad.Size = new System.Drawing.Size(236, 23);
            this.textBoxStad.TabIndex = 1;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(57, 56);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(236, 23);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 1011);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
    }
}

