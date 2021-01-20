namespace TheBookShelf
{
    partial class EditBookForm
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
            this.labelIsbn = new System.Windows.Forms.Label();
            this.labelTitel = new System.Windows.Forms.Label();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.labelUtgivningsdatum = new System.Windows.Forms.Label();
            this.dateTimePickerUtgivningsdatum = new System.Windows.Forms.DateTimePicker();
            this.labelPris = new System.Windows.Forms.Label();
            this.textBoxPris = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.labelSidor = new System.Windows.Forms.Label();
            this.textBoxSidor = new System.Windows.Forms.TextBox();
            this.labelBetygAvNiclas = new System.Windows.Forms.Label();
            this.labelFörlag = new System.Windows.Forms.Label();
            this.comboBoxFörlag = new System.Windows.Forms.ComboBox();
            this.labelVikt = new System.Windows.Forms.Label();
            this.textBoxVikt = new System.Windows.Forms.TextBox();
            this.labelÖversättare = new System.Windows.Forms.Label();
            this.comboBoxÖversättare = new System.Windows.Forms.ComboBox();
            this.labelFormat = new System.Windows.Forms.Label();
            this.labelSpråk = new System.Windows.Forms.Label();
            this.textBoxSpråk = new System.Windows.Forms.TextBox();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.buttonUpdateBook = new System.Windows.Forms.Button();
            this.comboBoxBetygAvNiclas = new System.Windows.Forms.ComboBox();
            this.labelFörfattare = new System.Windows.Forms.Label();
            this.textBoxFormat = new System.Windows.Forms.TextBox();
            this.comboBoxAddFörfattare = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxFörfattareBok = new System.Windows.Forms.ListBox();
            this.labelOriginaltitel = new System.Windows.Forms.Label();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.textBoxOriginaltitel = new System.Windows.Forms.TextBox();
            this.buttonTaBort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIsbn
            // 
            this.labelIsbn.AutoSize = true;
            this.labelIsbn.Location = new System.Drawing.Point(12, 18);
            this.labelIsbn.Name = "labelIsbn";
            this.labelIsbn.Size = new System.Drawing.Size(35, 15);
            this.labelIsbn.TabIndex = 0;
            this.labelIsbn.Text = "ISBN:";
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Location = new System.Drawing.Point(12, 47);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(32, 15);
            this.labelTitel.TabIndex = 2;
            this.labelTitel.Text = "Titel:";
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Location = new System.Drawing.Point(120, 44);
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(200, 23);
            this.textBoxTitel.TabIndex = 3;
            // 
            // labelUtgivningsdatum
            // 
            this.labelUtgivningsdatum.AutoSize = true;
            this.labelUtgivningsdatum.Location = new System.Drawing.Point(12, 79);
            this.labelUtgivningsdatum.Name = "labelUtgivningsdatum";
            this.labelUtgivningsdatum.Size = new System.Drawing.Size(102, 15);
            this.labelUtgivningsdatum.TabIndex = 4;
            this.labelUtgivningsdatum.Text = "Utgivningsdatum:";
            // 
            // dateTimePickerUtgivningsdatum
            // 
            this.dateTimePickerUtgivningsdatum.Location = new System.Drawing.Point(120, 73);
            this.dateTimePickerUtgivningsdatum.Name = "dateTimePickerUtgivningsdatum";
            this.dateTimePickerUtgivningsdatum.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerUtgivningsdatum.TabIndex = 5;
            // 
            // labelPris
            // 
            this.labelPris.AutoSize = true;
            this.labelPris.Location = new System.Drawing.Point(392, 105);
            this.labelPris.Name = "labelPris";
            this.labelPris.Size = new System.Drawing.Size(29, 15);
            this.labelPris.TabIndex = 6;
            this.labelPris.Text = "Pris:";
            // 
            // textBoxPris
            // 
            this.textBoxPris.Location = new System.Drawing.Point(488, 102);
            this.textBoxPris.Name = "textBoxPris";
            this.textBoxPris.Size = new System.Drawing.Size(200, 23);
            this.textBoxPris.TabIndex = 7;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(392, 18);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(41, 15);
            this.labelGenre.TabIndex = 8;
            this.labelGenre.Text = "Genre:";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(488, 15);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(200, 23);
            this.comboBoxGenre.TabIndex = 9;
            // 
            // labelSidor
            // 
            this.labelSidor.AutoSize = true;
            this.labelSidor.Location = new System.Drawing.Point(14, 105);
            this.labelSidor.Name = "labelSidor";
            this.labelSidor.Size = new System.Drawing.Size(37, 15);
            this.labelSidor.TabIndex = 10;
            this.labelSidor.Text = "Sidor:";
            // 
            // textBoxSidor
            // 
            this.textBoxSidor.Location = new System.Drawing.Point(120, 102);
            this.textBoxSidor.Name = "textBoxSidor";
            this.textBoxSidor.Size = new System.Drawing.Size(200, 23);
            this.textBoxSidor.TabIndex = 11;
            // 
            // labelBetygAvNiclas
            // 
            this.labelBetygAvNiclas.AutoSize = true;
            this.labelBetygAvNiclas.Location = new System.Drawing.Point(392, 222);
            this.labelBetygAvNiclas.Name = "labelBetygAvNiclas";
            this.labelBetygAvNiclas.Size = new System.Drawing.Size(90, 15);
            this.labelBetygAvNiclas.TabIndex = 12;
            this.labelBetygAvNiclas.Text = "Betyg av Niclas:";
            // 
            // labelFörlag
            // 
            this.labelFörlag.AutoSize = true;
            this.labelFörlag.Location = new System.Drawing.Point(392, 47);
            this.labelFörlag.Name = "labelFörlag";
            this.labelFörlag.Size = new System.Drawing.Size(43, 15);
            this.labelFörlag.TabIndex = 14;
            this.labelFörlag.Text = "Förlag:";
            // 
            // comboBoxFörlag
            // 
            this.comboBoxFörlag.FormattingEnabled = true;
            this.comboBoxFörlag.Location = new System.Drawing.Point(488, 44);
            this.comboBoxFörlag.Name = "comboBoxFörlag";
            this.comboBoxFörlag.Size = new System.Drawing.Size(200, 23);
            this.comboBoxFörlag.TabIndex = 15;
            // 
            // labelVikt
            // 
            this.labelVikt.AutoSize = true;
            this.labelVikt.Location = new System.Drawing.Point(392, 76);
            this.labelVikt.Name = "labelVikt";
            this.labelVikt.Size = new System.Drawing.Size(30, 15);
            this.labelVikt.TabIndex = 16;
            this.labelVikt.Text = "Vikt:";
            // 
            // textBoxVikt
            // 
            this.textBoxVikt.Location = new System.Drawing.Point(488, 73);
            this.textBoxVikt.Name = "textBoxVikt";
            this.textBoxVikt.Size = new System.Drawing.Size(200, 23);
            this.textBoxVikt.TabIndex = 17;
            // 
            // labelÖversättare
            // 
            this.labelÖversättare.AutoSize = true;
            this.labelÖversättare.Location = new System.Drawing.Point(392, 134);
            this.labelÖversättare.Name = "labelÖversättare";
            this.labelÖversättare.Size = new System.Drawing.Size(70, 15);
            this.labelÖversättare.TabIndex = 18;
            this.labelÖversättare.Text = "Översättare:";
            // 
            // comboBoxÖversättare
            // 
            this.comboBoxÖversättare.FormattingEnabled = true;
            this.comboBoxÖversättare.Location = new System.Drawing.Point(488, 131);
            this.comboBoxÖversättare.Name = "comboBoxÖversättare";
            this.comboBoxÖversättare.Size = new System.Drawing.Size(200, 23);
            this.comboBoxÖversättare.TabIndex = 19;
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(12, 134);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(48, 15);
            this.labelFormat.TabIndex = 20;
            this.labelFormat.Text = "Format:";
            // 
            // labelSpråk
            // 
            this.labelSpråk.AutoSize = true;
            this.labelSpråk.Location = new System.Drawing.Point(392, 163);
            this.labelSpråk.Name = "labelSpråk";
            this.labelSpråk.Size = new System.Drawing.Size(39, 15);
            this.labelSpråk.TabIndex = 22;
            this.labelSpråk.Text = "Språk:";
            // 
            // textBoxSpråk
            // 
            this.textBoxSpråk.Location = new System.Drawing.Point(488, 160);
            this.textBoxSpråk.Name = "textBoxSpråk";
            this.textBoxSpråk.Size = new System.Drawing.Size(200, 23);
            this.textBoxSpråk.TabIndex = 23;
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(512, 248);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(85, 23);
            this.buttonAbort.TabIndex = 24;
            this.buttonAbort.Text = "Avbryt";
            this.buttonAbort.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateBook
            // 
            this.buttonUpdateBook.Location = new System.Drawing.Point(603, 248);
            this.buttonUpdateBook.Name = "buttonUpdateBook";
            this.buttonUpdateBook.Size = new System.Drawing.Size(85, 23);
            this.buttonUpdateBook.TabIndex = 25;
            this.buttonUpdateBook.Text = "Uppdatera";
            this.buttonUpdateBook.UseVisualStyleBackColor = true;
            this.buttonUpdateBook.Click += new System.EventHandler(this.buttonUpdateBook_Click);
            // 
            // comboBoxBetygAvNiclas
            // 
            this.comboBoxBetygAvNiclas.FormattingEnabled = true;
            this.comboBoxBetygAvNiclas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxBetygAvNiclas.Location = new System.Drawing.Point(488, 219);
            this.comboBoxBetygAvNiclas.Name = "comboBoxBetygAvNiclas";
            this.comboBoxBetygAvNiclas.Size = new System.Drawing.Size(200, 23);
            this.comboBoxBetygAvNiclas.TabIndex = 26;
            // 
            // labelFörfattare
            // 
            this.labelFörfattare.AutoSize = true;
            this.labelFörfattare.Location = new System.Drawing.Point(12, 163);
            this.labelFörfattare.Name = "labelFörfattare";
            this.labelFörfattare.Size = new System.Drawing.Size(61, 15);
            this.labelFörfattare.TabIndex = 27;
            this.labelFörfattare.Text = "Författare:";
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.Location = new System.Drawing.Point(120, 131);
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.Size = new System.Drawing.Size(200, 23);
            this.textBoxFormat.TabIndex = 29;
            // 
            // comboBoxAddFörfattare
            // 
            this.comboBoxAddFörfattare.FormattingEnabled = true;
            this.comboBoxAddFörfattare.Location = new System.Drawing.Point(120, 160);
            this.comboBoxAddFörfattare.Name = "comboBoxAddFörfattare";
            this.comboBoxAddFörfattare.Size = new System.Drawing.Size(200, 23);
            this.comboBoxAddFörfattare.TabIndex = 30;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(326, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Lägg till";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxFörfattareBok
            // 
            this.listBoxFörfattareBok.FormattingEnabled = true;
            this.listBoxFörfattareBok.ItemHeight = 15;
            this.listBoxFörfattareBok.Location = new System.Drawing.Point(120, 189);
            this.listBoxFörfattareBok.Name = "listBoxFörfattareBok";
            this.listBoxFörfattareBok.Size = new System.Drawing.Size(200, 49);
            this.listBoxFörfattareBok.TabIndex = 33;
            // 
            // labelOriginaltitel
            // 
            this.labelOriginaltitel.AutoSize = true;
            this.labelOriginaltitel.Location = new System.Drawing.Point(392, 193);
            this.labelOriginaltitel.Name = "labelOriginaltitel";
            this.labelOriginaltitel.Size = new System.Drawing.Size(72, 15);
            this.labelOriginaltitel.TabIndex = 34;
            this.labelOriginaltitel.Text = "Originaltitel:";
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Location = new System.Drawing.Point(120, 15);
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(200, 23);
            this.textBoxIsbn.TabIndex = 1;
            // 
            // textBoxOriginaltitel
            // 
            this.textBoxOriginaltitel.Location = new System.Drawing.Point(488, 190);
            this.textBoxOriginaltitel.Name = "textBoxOriginaltitel";
            this.textBoxOriginaltitel.Size = new System.Drawing.Size(200, 23);
            this.textBoxOriginaltitel.TabIndex = 35;
            // 
            // buttonTaBort
            // 
            this.buttonTaBort.Location = new System.Drawing.Point(326, 189);
            this.buttonTaBort.Name = "buttonTaBort";
            this.buttonTaBort.Size = new System.Drawing.Size(60, 23);
            this.buttonTaBort.TabIndex = 36;
            this.buttonTaBort.Text = "Ta bort";
            this.buttonTaBort.UseVisualStyleBackColor = true;
            this.buttonTaBort.Click += new System.EventHandler(this.buttonTaBort_Click);
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 278);
            this.Controls.Add(this.buttonTaBort);
            this.Controls.Add(this.textBoxOriginaltitel);
            this.Controls.Add(this.textBoxIsbn);
            this.Controls.Add(this.labelOriginaltitel);
            this.Controls.Add(this.listBoxFörfattareBok);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxAddFörfattare);
            this.Controls.Add(this.textBoxFormat);
            this.Controls.Add(this.labelFörfattare);
            this.Controls.Add(this.comboBoxBetygAvNiclas);
            this.Controls.Add(this.buttonUpdateBook);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.textBoxSpråk);
            this.Controls.Add(this.labelSpråk);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.comboBoxÖversättare);
            this.Controls.Add(this.labelÖversättare);
            this.Controls.Add(this.textBoxVikt);
            this.Controls.Add(this.labelVikt);
            this.Controls.Add(this.comboBoxFörlag);
            this.Controls.Add(this.labelFörlag);
            this.Controls.Add(this.labelBetygAvNiclas);
            this.Controls.Add(this.textBoxSidor);
            this.Controls.Add(this.labelSidor);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.textBoxPris);
            this.Controls.Add(this.labelPris);
            this.Controls.Add(this.dateTimePickerUtgivningsdatum);
            this.Controls.Add(this.labelUtgivningsdatum);
            this.Controls.Add(this.textBoxTitel);
            this.Controls.Add(this.labelTitel);
            this.Controls.Add(this.labelIsbn);
            this.Name = "EditBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Uppdatera bok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIsbn;
        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.TextBox textBoxTitel;
        private System.Windows.Forms.Label labelUtgivningsdatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerUtgivningsdatum;
        private System.Windows.Forms.Label labelPris;
        private System.Windows.Forms.TextBox textBoxPris;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Label labelSidor;
        private System.Windows.Forms.TextBox textBoxSidor;
        private System.Windows.Forms.Label labelBetygAvNiclas;
        private System.Windows.Forms.Label labelFörlag;
        private System.Windows.Forms.ComboBox comboBoxFörlag;
        private System.Windows.Forms.Label labelVikt;
        private System.Windows.Forms.TextBox textBoxVikt;
        private System.Windows.Forms.Label labelÖversättare;
        private System.Windows.Forms.ComboBox comboBoxÖversättare;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.Label labelSpråk;
        private System.Windows.Forms.TextBox textBoxSpråk;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.Button buttonUpdateBook;
        private System.Windows.Forms.ComboBox comboBoxBetygAvNiclas;
        private System.Windows.Forms.Label labelFörfattare;
        private System.Windows.Forms.TextBox textBoxFormat;
        private System.Windows.Forms.ComboBox comboBoxAddFörfattare;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxFörfattareBok;
        private System.Windows.Forms.Label labelOriginaltitel;
        private System.Windows.Forms.TextBox textBoxIsbn;
        private System.Windows.Forms.TextBox textBoxOriginaltitel;
        private System.Windows.Forms.Button buttonTaBort;
    }
}