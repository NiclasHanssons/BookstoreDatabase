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
            this.buttonLäggTill = new System.Windows.Forms.Button();
            this.listBoxFörfattareBok = new System.Windows.Forms.ListBox();
            this.labelOriginaltitel = new System.Windows.Forms.Label();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.textBoxOriginaltitel = new System.Windows.Forms.TextBox();
            this.buttonTaBort = new System.Windows.Forms.Button();
            this.buttonRemoveTranslator = new System.Windows.Forms.Button();
            this.buttonRemoveGrade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIsbn
            // 
            this.labelIsbn.AutoSize = true;
            this.labelIsbn.Location = new System.Drawing.Point(12, 15);
            this.labelIsbn.Name = "labelIsbn";
            this.labelIsbn.Size = new System.Drawing.Size(35, 15);
            this.labelIsbn.TabIndex = 0;
            this.labelIsbn.Text = "ISBN:";
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Location = new System.Drawing.Point(12, 44);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(32, 15);
            this.labelTitel.TabIndex = 2;
            this.labelTitel.Text = "Titel:";
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Location = new System.Drawing.Point(138, 41);
            this.textBoxTitel.MaxLength = 100;
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(200, 23);
            this.textBoxTitel.TabIndex = 3;
            // 
            // labelUtgivningsdatum
            // 
            this.labelUtgivningsdatum.AutoSize = true;
            this.labelUtgivningsdatum.Location = new System.Drawing.Point(12, 73);
            this.labelUtgivningsdatum.Name = "labelUtgivningsdatum";
            this.labelUtgivningsdatum.Size = new System.Drawing.Size(102, 15);
            this.labelUtgivningsdatum.TabIndex = 4;
            this.labelUtgivningsdatum.Text = "Utgivningsdatum:";
            // 
            // dateTimePickerUtgivningsdatum
            // 
            this.dateTimePickerUtgivningsdatum.Location = new System.Drawing.Point(138, 70);
            this.dateTimePickerUtgivningsdatum.MaxDate = new System.DateTime(2021, 1, 22, 0, 0, 0, 0);
            this.dateTimePickerUtgivningsdatum.Name = "dateTimePickerUtgivningsdatum";
            this.dateTimePickerUtgivningsdatum.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerUtgivningsdatum.TabIndex = 5;
            this.dateTimePickerUtgivningsdatum.Value = new System.DateTime(2021, 1, 22, 0, 0, 0, 0);
            // 
            // labelPris
            // 
            this.labelPris.AutoSize = true;
            this.labelPris.Location = new System.Drawing.Point(416, 102);
            this.labelPris.Name = "labelPris";
            this.labelPris.Size = new System.Drawing.Size(57, 15);
            this.labelPris.TabIndex = 6;
            this.labelPris.Text = "Pris (sek):";
            // 
            // textBoxPris
            // 
            this.textBoxPris.Location = new System.Drawing.Point(531, 99);
            this.textBoxPris.MaxLength = 9;
            this.textBoxPris.Name = "textBoxPris";
            this.textBoxPris.Size = new System.Drawing.Size(200, 23);
            this.textBoxPris.TabIndex = 7;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(416, 15);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(41, 15);
            this.labelGenre.TabIndex = 8;
            this.labelGenre.Text = "Genre:";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(531, 12);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(200, 23);
            this.comboBoxGenre.TabIndex = 9;
            // 
            // labelSidor
            // 
            this.labelSidor.AutoSize = true;
            this.labelSidor.Location = new System.Drawing.Point(12, 102);
            this.labelSidor.Name = "labelSidor";
            this.labelSidor.Size = new System.Drawing.Size(37, 15);
            this.labelSidor.TabIndex = 10;
            this.labelSidor.Text = "Sidor:";
            // 
            // textBoxSidor
            // 
            this.textBoxSidor.Location = new System.Drawing.Point(138, 99);
            this.textBoxSidor.MaxLength = 9;
            this.textBoxSidor.Name = "textBoxSidor";
            this.textBoxSidor.Size = new System.Drawing.Size(200, 23);
            this.textBoxSidor.TabIndex = 11;
            // 
            // labelBetygAvNiclas
            // 
            this.labelBetygAvNiclas.AutoSize = true;
            this.labelBetygAvNiclas.Location = new System.Drawing.Point(416, 219);
            this.labelBetygAvNiclas.Name = "labelBetygAvNiclas";
            this.labelBetygAvNiclas.Size = new System.Drawing.Size(90, 15);
            this.labelBetygAvNiclas.TabIndex = 12;
            this.labelBetygAvNiclas.Text = "Betyg av Niclas:";
            // 
            // labelFörlag
            // 
            this.labelFörlag.AutoSize = true;
            this.labelFörlag.Location = new System.Drawing.Point(416, 44);
            this.labelFörlag.Name = "labelFörlag";
            this.labelFörlag.Size = new System.Drawing.Size(43, 15);
            this.labelFörlag.TabIndex = 14;
            this.labelFörlag.Text = "Förlag:";
            // 
            // comboBoxFörlag
            // 
            this.comboBoxFörlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFörlag.FormattingEnabled = true;
            this.comboBoxFörlag.Location = new System.Drawing.Point(531, 41);
            this.comboBoxFörlag.Name = "comboBoxFörlag";
            this.comboBoxFörlag.Size = new System.Drawing.Size(200, 23);
            this.comboBoxFörlag.TabIndex = 15;
            // 
            // labelVikt
            // 
            this.labelVikt.AutoSize = true;
            this.labelVikt.Location = new System.Drawing.Point(416, 73);
            this.labelVikt.Name = "labelVikt";
            this.labelVikt.Size = new System.Drawing.Size(48, 15);
            this.labelVikt.TabIndex = 16;
            this.labelVikt.Text = "Vikt (g):";
            // 
            // textBoxVikt
            // 
            this.textBoxVikt.Location = new System.Drawing.Point(531, 70);
            this.textBoxVikt.MaxLength = 9;
            this.textBoxVikt.Name = "textBoxVikt";
            this.textBoxVikt.Size = new System.Drawing.Size(200, 23);
            this.textBoxVikt.TabIndex = 17;
            // 
            // labelÖversättare
            // 
            this.labelÖversättare.AutoSize = true;
            this.labelÖversättare.Location = new System.Drawing.Point(416, 131);
            this.labelÖversättare.Name = "labelÖversättare";
            this.labelÖversättare.Size = new System.Drawing.Size(70, 15);
            this.labelÖversättare.TabIndex = 18;
            this.labelÖversättare.Text = "Översättare:";
            // 
            // comboBoxÖversättare
            // 
            this.comboBoxÖversättare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxÖversättare.FormattingEnabled = true;
            this.comboBoxÖversättare.Location = new System.Drawing.Point(531, 128);
            this.comboBoxÖversättare.Name = "comboBoxÖversättare";
            this.comboBoxÖversättare.Size = new System.Drawing.Size(200, 23);
            this.comboBoxÖversättare.TabIndex = 19;
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(12, 131);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(48, 15);
            this.labelFormat.TabIndex = 20;
            this.labelFormat.Text = "Format:";
            // 
            // labelSpråk
            // 
            this.labelSpråk.AutoSize = true;
            this.labelSpråk.Location = new System.Drawing.Point(416, 160);
            this.labelSpråk.Name = "labelSpråk";
            this.labelSpråk.Size = new System.Drawing.Size(39, 15);
            this.labelSpråk.TabIndex = 22;
            this.labelSpråk.Text = "Språk:";
            // 
            // textBoxSpråk
            // 
            this.textBoxSpråk.Location = new System.Drawing.Point(531, 157);
            this.textBoxSpråk.MaxLength = 30;
            this.textBoxSpråk.Name = "textBoxSpråk";
            this.textBoxSpråk.Size = new System.Drawing.Size(200, 23);
            this.textBoxSpråk.TabIndex = 23;
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(555, 245);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(85, 23);
            this.buttonAbort.TabIndex = 24;
            this.buttonAbort.Text = "Avbryt";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // buttonUpdateBook
            // 
            this.buttonUpdateBook.Location = new System.Drawing.Point(646, 245);
            this.buttonUpdateBook.Name = "buttonUpdateBook";
            this.buttonUpdateBook.Size = new System.Drawing.Size(85, 23);
            this.buttonUpdateBook.TabIndex = 25;
            this.buttonUpdateBook.Text = "Uppdatera";
            this.buttonUpdateBook.UseVisualStyleBackColor = true;
            this.buttonUpdateBook.Click += new System.EventHandler(this.buttonUpdateBook_Click);
            // 
            // comboBoxBetygAvNiclas
            // 
            this.comboBoxBetygAvNiclas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBetygAvNiclas.FormattingEnabled = true;
            this.comboBoxBetygAvNiclas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxBetygAvNiclas.Location = new System.Drawing.Point(531, 216);
            this.comboBoxBetygAvNiclas.Name = "comboBoxBetygAvNiclas";
            this.comboBoxBetygAvNiclas.Size = new System.Drawing.Size(200, 23);
            this.comboBoxBetygAvNiclas.TabIndex = 26;
            // 
            // labelFörfattare
            // 
            this.labelFörfattare.AutoSize = true;
            this.labelFörfattare.Location = new System.Drawing.Point(12, 160);
            this.labelFörfattare.Name = "labelFörfattare";
            this.labelFörfattare.Size = new System.Drawing.Size(61, 15);
            this.labelFörfattare.TabIndex = 27;
            this.labelFörfattare.Text = "Författare:";
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.Location = new System.Drawing.Point(138, 128);
            this.textBoxFormat.MaxLength = 20;
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.Size = new System.Drawing.Size(200, 23);
            this.textBoxFormat.TabIndex = 29;
            // 
            // comboBoxAddFörfattare
            // 
            this.comboBoxAddFörfattare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddFörfattare.FormattingEnabled = true;
            this.comboBoxAddFörfattare.Location = new System.Drawing.Point(138, 157);
            this.comboBoxAddFörfattare.Name = "comboBoxAddFörfattare";
            this.comboBoxAddFörfattare.Size = new System.Drawing.Size(200, 23);
            this.comboBoxAddFörfattare.TabIndex = 30;
            // 
            // buttonLäggTill
            // 
            this.buttonLäggTill.Location = new System.Drawing.Point(344, 157);
            this.buttonLäggTill.Name = "buttonLäggTill";
            this.buttonLäggTill.Size = new System.Drawing.Size(60, 23);
            this.buttonLäggTill.TabIndex = 32;
            this.buttonLäggTill.Text = "Lägg till";
            this.buttonLäggTill.UseVisualStyleBackColor = true;
            this.buttonLäggTill.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxFörfattareBok
            // 
            this.listBoxFörfattareBok.FormattingEnabled = true;
            this.listBoxFörfattareBok.ItemHeight = 15;
            this.listBoxFörfattareBok.Location = new System.Drawing.Point(138, 186);
            this.listBoxFörfattareBok.Name = "listBoxFörfattareBok";
            this.listBoxFörfattareBok.Size = new System.Drawing.Size(200, 49);
            this.listBoxFörfattareBok.TabIndex = 33;
            // 
            // labelOriginaltitel
            // 
            this.labelOriginaltitel.AutoSize = true;
            this.labelOriginaltitel.Location = new System.Drawing.Point(416, 190);
            this.labelOriginaltitel.Name = "labelOriginaltitel";
            this.labelOriginaltitel.Size = new System.Drawing.Size(72, 15);
            this.labelOriginaltitel.TabIndex = 34;
            this.labelOriginaltitel.Text = "Originaltitel:";
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Location = new System.Drawing.Point(138, 12);
            this.textBoxIsbn.MaxLength = 13;
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.ReadOnly = true;
            this.textBoxIsbn.Size = new System.Drawing.Size(200, 23);
            this.textBoxIsbn.TabIndex = 1;
            // 
            // textBoxOriginaltitel
            // 
            this.textBoxOriginaltitel.Location = new System.Drawing.Point(531, 186);
            this.textBoxOriginaltitel.MaxLength = 100;
            this.textBoxOriginaltitel.Name = "textBoxOriginaltitel";
            this.textBoxOriginaltitel.Size = new System.Drawing.Size(200, 23);
            this.textBoxOriginaltitel.TabIndex = 35;
            // 
            // buttonTaBort
            // 
            this.buttonTaBort.Location = new System.Drawing.Point(344, 186);
            this.buttonTaBort.Name = "buttonTaBort";
            this.buttonTaBort.Size = new System.Drawing.Size(60, 23);
            this.buttonTaBort.TabIndex = 36;
            this.buttonTaBort.Text = "Ta bort";
            this.buttonTaBort.UseVisualStyleBackColor = true;
            this.buttonTaBort.Click += new System.EventHandler(this.buttonTaBort_Click);
            // 
            // buttonRemoveTranslator
            // 
            this.buttonRemoveTranslator.Location = new System.Drawing.Point(737, 128);
            this.buttonRemoveTranslator.Name = "buttonRemoveTranslator";
            this.buttonRemoveTranslator.Size = new System.Drawing.Size(26, 23);
            this.buttonRemoveTranslator.TabIndex = 37;
            this.buttonRemoveTranslator.Text = "X";
            this.buttonRemoveTranslator.UseVisualStyleBackColor = true;
            this.buttonRemoveTranslator.Click += new System.EventHandler(this.buttonRemoveTranslator_Click);
            // 
            // buttonRemoveGrade
            // 
            this.buttonRemoveGrade.Location = new System.Drawing.Point(737, 216);
            this.buttonRemoveGrade.Name = "buttonRemoveGrade";
            this.buttonRemoveGrade.Size = new System.Drawing.Size(26, 23);
            this.buttonRemoveGrade.TabIndex = 38;
            this.buttonRemoveGrade.Text = "X";
            this.buttonRemoveGrade.UseVisualStyleBackColor = true;
            this.buttonRemoveGrade.Click += new System.EventHandler(this.buttonRemoveGrade_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(115, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(115, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(115, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(115, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(115, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(115, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(508, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 23);
            this.label7.TabIndex = 39;
            this.label7.Text = "*";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(508, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 23);
            this.label8.TabIndex = 39;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(508, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 23);
            this.label9.TabIndex = 39;
            this.label9.Text = "*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(508, 99);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 23);
            this.label10.TabIndex = 39;
            this.label10.Text = "*";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(508, 157);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 23);
            this.label12.TabIndex = 39;
            this.label12.Text = "*";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 278);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemoveGrade);
            this.Controls.Add(this.buttonRemoveTranslator);
            this.Controls.Add(this.buttonTaBort);
            this.Controls.Add(this.textBoxOriginaltitel);
            this.Controls.Add(this.textBoxIsbn);
            this.Controls.Add(this.labelOriginaltitel);
            this.Controls.Add(this.listBoxFörfattareBok);
            this.Controls.Add(this.buttonLäggTill);
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
            this.MaximumSize = new System.Drawing.Size(792, 317);
            this.MinimumSize = new System.Drawing.Size(792, 317);
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
        private System.Windows.Forms.Button buttonLäggTill;
        private System.Windows.Forms.ListBox listBoxFörfattareBok;
        private System.Windows.Forms.Label labelOriginaltitel;
        private System.Windows.Forms.TextBox textBoxIsbn;
        private System.Windows.Forms.TextBox textBoxOriginaltitel;
        private System.Windows.Forms.Button buttonTaBort;
        private System.Windows.Forms.Button buttonRemoveTranslator;
        private System.Windows.Forms.Button buttonRemoveGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
    }
}