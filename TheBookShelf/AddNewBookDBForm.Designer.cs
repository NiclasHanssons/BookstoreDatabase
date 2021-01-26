namespace TheBookShelf
{
    partial class AddNewBookDBForm
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
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.labelTitel = new System.Windows.Forms.Label();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.labelUtgivningsdatum = new System.Windows.Forms.Label();
            this.dateTimePickerUtgivningsdatum = new System.Windows.Forms.DateTimePicker();
            this.labelPris = new System.Windows.Forms.Label();
            this.textBoxPris = new System.Windows.Forms.TextBox();
            this.labelGenreID = new System.Windows.Forms.Label();
            this.comboBoxGenreID = new System.Windows.Forms.ComboBox();
            this.labelSidor = new System.Windows.Forms.Label();
            this.textBoxSidor = new System.Windows.Forms.TextBox();
            this.labelBetygAvNiclas = new System.Windows.Forms.Label();
            this.labelFörlagsID = new System.Windows.Forms.Label();
            this.comboBoxFörlagsID = new System.Windows.Forms.ComboBox();
            this.labelVikt = new System.Windows.Forms.Label();
            this.textBoxVikt = new System.Windows.Forms.TextBox();
            this.labelÖversättareID = new System.Windows.Forms.Label();
            this.comboBoxÖversättareID = new System.Windows.Forms.ComboBox();
            this.labelFormat = new System.Windows.Forms.Label();
            this.labelSpråk = new System.Windows.Forms.Label();
            this.textBoxSpråk = new System.Windows.Forms.TextBox();
            this.buttonRensa = new System.Windows.Forms.Button();
            this.buttonLäggTill = new System.Windows.Forms.Button();
            this.comboBoxBetygAvNiclas = new System.Windows.Forms.ComboBox();
            this.labelFörfattare = new System.Windows.Forms.Label();
            this.textBoxFormat = new System.Windows.Forms.TextBox();
            this.comboBoxAddAuthor = new System.Windows.Forms.ComboBox();
            this.buttonLäggTillFörfattare = new System.Windows.Forms.Button();
            this.listBoxFörfattare = new System.Windows.Forms.ListBox();
            this.labelOriginaltitel = new System.Windows.Forms.Label();
            this.textBoxOriginaltitel = new System.Windows.Forms.TextBox();
            this.buttonTaBortFörfattare = new System.Windows.Forms.Button();
            this.buttonRemoveTranslator = new System.Windows.Forms.Button();
            this.buttonRemoveGrade = new System.Windows.Forms.Button();
            this.label1Star = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // labelIsbn
            // 
            this.labelIsbn.AutoSize = true;
            this.labelIsbn.Location = new System.Drawing.Point(14, 20);
            this.labelIsbn.Name = "labelIsbn";
            this.labelIsbn.Size = new System.Drawing.Size(44, 20);
            this.labelIsbn.TabIndex = 0;
            this.labelIsbn.Text = "ISBN:";
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Location = new System.Drawing.Point(158, 16);
            this.textBoxIsbn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxIsbn.MaxLength = 13;
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(228, 27);
            this.textBoxIsbn.TabIndex = 1;
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Location = new System.Drawing.Point(14, 59);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(41, 20);
            this.labelTitel.TabIndex = 2;
            this.labelTitel.Text = "Titel:";
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Location = new System.Drawing.Point(158, 55);
            this.textBoxTitel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTitel.MaxLength = 100;
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(228, 27);
            this.textBoxTitel.TabIndex = 3;
            // 
            // labelUtgivningsdatum
            // 
            this.labelUtgivningsdatum.AutoSize = true;
            this.labelUtgivningsdatum.Location = new System.Drawing.Point(11, 97);
            this.labelUtgivningsdatum.Name = "labelUtgivningsdatum";
            this.labelUtgivningsdatum.Size = new System.Drawing.Size(125, 20);
            this.labelUtgivningsdatum.TabIndex = 4;
            this.labelUtgivningsdatum.Text = "Utgivningsdatum:";
            // 
            // dateTimePickerUtgivningsdatum
            // 
            this.dateTimePickerUtgivningsdatum.Location = new System.Drawing.Point(158, 93);
            this.dateTimePickerUtgivningsdatum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerUtgivningsdatum.MaxDate = new System.DateTime(2021, 1, 22, 0, 0, 0, 0);
            this.dateTimePickerUtgivningsdatum.Name = "dateTimePickerUtgivningsdatum";
            this.dateTimePickerUtgivningsdatum.Size = new System.Drawing.Size(228, 27);
            this.dateTimePickerUtgivningsdatum.TabIndex = 5;
            this.dateTimePickerUtgivningsdatum.Value = new System.DateTime(2021, 1, 22, 0, 0, 0, 0);
            // 
            // labelPris
            // 
            this.labelPris.AutoSize = true;
            this.labelPris.Location = new System.Drawing.Point(475, 136);
            this.labelPris.Name = "labelPris";
            this.labelPris.Size = new System.Drawing.Size(70, 20);
            this.labelPris.TabIndex = 6;
            this.labelPris.Text = "Pris (sek):";
            // 
            // textBoxPris
            // 
            this.textBoxPris.Location = new System.Drawing.Point(607, 132);
            this.textBoxPris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPris.MaxLength = 6;
            this.textBoxPris.Name = "textBoxPris";
            this.textBoxPris.Size = new System.Drawing.Size(228, 27);
            this.textBoxPris.TabIndex = 7;
            // 
            // labelGenreID
            // 
            this.labelGenreID.AutoSize = true;
            this.labelGenreID.Location = new System.Drawing.Point(475, 20);
            this.labelGenreID.Name = "labelGenreID";
            this.labelGenreID.Size = new System.Drawing.Size(51, 20);
            this.labelGenreID.TabIndex = 8;
            this.labelGenreID.Text = "Genre:";
            // 
            // comboBoxGenreID
            // 
            this.comboBoxGenreID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenreID.FormattingEnabled = true;
            this.comboBoxGenreID.Location = new System.Drawing.Point(607, 16);
            this.comboBoxGenreID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxGenreID.Name = "comboBoxGenreID";
            this.comboBoxGenreID.Size = new System.Drawing.Size(228, 28);
            this.comboBoxGenreID.TabIndex = 9;
            // 
            // labelSidor
            // 
            this.labelSidor.AutoSize = true;
            this.labelSidor.Location = new System.Drawing.Point(14, 136);
            this.labelSidor.Name = "labelSidor";
            this.labelSidor.Size = new System.Drawing.Size(47, 20);
            this.labelSidor.TabIndex = 10;
            this.labelSidor.Text = "Sidor:";
            // 
            // textBoxSidor
            // 
            this.textBoxSidor.Location = new System.Drawing.Point(158, 132);
            this.textBoxSidor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSidor.MaxLength = 6;
            this.textBoxSidor.Name = "textBoxSidor";
            this.textBoxSidor.Size = new System.Drawing.Size(228, 27);
            this.textBoxSidor.TabIndex = 11;
            // 
            // labelBetygAvNiclas
            // 
            this.labelBetygAvNiclas.AutoSize = true;
            this.labelBetygAvNiclas.Location = new System.Drawing.Point(475, 292);
            this.labelBetygAvNiclas.Name = "labelBetygAvNiclas";
            this.labelBetygAvNiclas.Size = new System.Drawing.Size(113, 20);
            this.labelBetygAvNiclas.TabIndex = 12;
            this.labelBetygAvNiclas.Text = "Betyg av Niclas:";
            // 
            // labelFörlagsID
            // 
            this.labelFörlagsID.AutoSize = true;
            this.labelFörlagsID.Location = new System.Drawing.Point(475, 59);
            this.labelFörlagsID.Name = "labelFörlagsID";
            this.labelFörlagsID.Size = new System.Drawing.Size(54, 20);
            this.labelFörlagsID.TabIndex = 14;
            this.labelFörlagsID.Text = "Förlag:";
            // 
            // comboBoxFörlagsID
            // 
            this.comboBoxFörlagsID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFörlagsID.FormattingEnabled = true;
            this.comboBoxFörlagsID.Location = new System.Drawing.Point(607, 55);
            this.comboBoxFörlagsID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxFörlagsID.Name = "comboBoxFörlagsID";
            this.comboBoxFörlagsID.Size = new System.Drawing.Size(228, 28);
            this.comboBoxFörlagsID.TabIndex = 15;
            // 
            // labelVikt
            // 
            this.labelVikt.AutoSize = true;
            this.labelVikt.Location = new System.Drawing.Point(475, 97);
            this.labelVikt.Name = "labelVikt";
            this.labelVikt.Size = new System.Drawing.Size(60, 20);
            this.labelVikt.TabIndex = 16;
            this.labelVikt.Text = "Vikt (g):";
            // 
            // textBoxVikt
            // 
            this.textBoxVikt.Location = new System.Drawing.Point(607, 93);
            this.textBoxVikt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxVikt.MaxLength = 6;
            this.textBoxVikt.Name = "textBoxVikt";
            this.textBoxVikt.Size = new System.Drawing.Size(228, 27);
            this.textBoxVikt.TabIndex = 17;
            // 
            // labelÖversättareID
            // 
            this.labelÖversättareID.AutoSize = true;
            this.labelÖversättareID.Location = new System.Drawing.Point(475, 175);
            this.labelÖversättareID.Name = "labelÖversättareID";
            this.labelÖversättareID.Size = new System.Drawing.Size(88, 20);
            this.labelÖversättareID.TabIndex = 18;
            this.labelÖversättareID.Text = "Översättare:";
            // 
            // comboBoxÖversättareID
            // 
            this.comboBoxÖversättareID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxÖversättareID.FormattingEnabled = true;
            this.comboBoxÖversättareID.Location = new System.Drawing.Point(607, 171);
            this.comboBoxÖversättareID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxÖversättareID.Name = "comboBoxÖversättareID";
            this.comboBoxÖversättareID.Size = new System.Drawing.Size(228, 28);
            this.comboBoxÖversättareID.TabIndex = 19;
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(14, 175);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(59, 20);
            this.labelFormat.TabIndex = 20;
            this.labelFormat.Text = "Format:";
            // 
            // labelSpråk
            // 
            this.labelSpråk.AutoSize = true;
            this.labelSpråk.Location = new System.Drawing.Point(475, 213);
            this.labelSpråk.Name = "labelSpråk";
            this.labelSpråk.Size = new System.Drawing.Size(49, 20);
            this.labelSpråk.TabIndex = 22;
            this.labelSpråk.Text = "Språk:";
            // 
            // textBoxSpråk
            // 
            this.textBoxSpråk.Location = new System.Drawing.Point(607, 209);
            this.textBoxSpråk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSpråk.MaxLength = 30;
            this.textBoxSpråk.Name = "textBoxSpråk";
            this.textBoxSpråk.Size = new System.Drawing.Size(228, 27);
            this.textBoxSpråk.TabIndex = 23;
            // 
            // buttonRensa
            // 
            this.buttonRensa.Location = new System.Drawing.Point(634, 327);
            this.buttonRensa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRensa.Name = "buttonRensa";
            this.buttonRensa.Size = new System.Drawing.Size(97, 31);
            this.buttonRensa.TabIndex = 24;
            this.buttonRensa.Text = "Rensa";
            this.buttonRensa.UseVisualStyleBackColor = true;
            this.buttonRensa.Click += new System.EventHandler(this.buttonRensa_Click);
            // 
            // buttonLäggTill
            // 
            this.buttonLäggTill.Location = new System.Drawing.Point(738, 327);
            this.buttonLäggTill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLäggTill.Name = "buttonLäggTill";
            this.buttonLäggTill.Size = new System.Drawing.Size(97, 31);
            this.buttonLäggTill.TabIndex = 25;
            this.buttonLäggTill.Text = "Lägg till bok";
            this.buttonLäggTill.UseVisualStyleBackColor = true;
            this.buttonLäggTill.Click += new System.EventHandler(this.buttonLäggTill_Click);
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
            this.comboBoxBetygAvNiclas.Location = new System.Drawing.Point(607, 288);
            this.comboBoxBetygAvNiclas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxBetygAvNiclas.Name = "comboBoxBetygAvNiclas";
            this.comboBoxBetygAvNiclas.Size = new System.Drawing.Size(228, 28);
            this.comboBoxBetygAvNiclas.TabIndex = 26;
            // 
            // labelFörfattare
            // 
            this.labelFörfattare.AutoSize = true;
            this.labelFörfattare.Location = new System.Drawing.Point(14, 213);
            this.labelFörfattare.Name = "labelFörfattare";
            this.labelFörfattare.Size = new System.Drawing.Size(77, 20);
            this.labelFörfattare.TabIndex = 27;
            this.labelFörfattare.Text = "Författare:";
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.Location = new System.Drawing.Point(158, 171);
            this.textBoxFormat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFormat.MaxLength = 20;
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.Size = new System.Drawing.Size(228, 27);
            this.textBoxFormat.TabIndex = 29;
            // 
            // comboBoxAddAuthor
            // 
            this.comboBoxAddAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddAuthor.FormattingEnabled = true;
            this.comboBoxAddAuthor.Location = new System.Drawing.Point(158, 209);
            this.comboBoxAddAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxAddAuthor.Name = "comboBoxAddAuthor";
            this.comboBoxAddAuthor.Size = new System.Drawing.Size(228, 28);
            this.comboBoxAddAuthor.TabIndex = 30;
            // 
            // buttonLäggTillFörfattare
            // 
            this.buttonLäggTillFörfattare.Location = new System.Drawing.Point(393, 209);
            this.buttonLäggTillFörfattare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLäggTillFörfattare.Name = "buttonLäggTillFörfattare";
            this.buttonLäggTillFörfattare.Size = new System.Drawing.Size(76, 31);
            this.buttonLäggTillFörfattare.TabIndex = 32;
            this.buttonLäggTillFörfattare.Text = "Lägg till";
            this.buttonLäggTillFörfattare.UseVisualStyleBackColor = true;
            this.buttonLäggTillFörfattare.Click += new System.EventHandler(this.buttonLäggTillFörfattare_Click);
            // 
            // listBoxFörfattare
            // 
            this.listBoxFörfattare.FormattingEnabled = true;
            this.listBoxFörfattare.ItemHeight = 20;
            this.listBoxFörfattare.Location = new System.Drawing.Point(158, 248);
            this.listBoxFörfattare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxFörfattare.Name = "listBoxFörfattare";
            this.listBoxFörfattare.Size = new System.Drawing.Size(228, 64);
            this.listBoxFörfattare.TabIndex = 33;
            // 
            // labelOriginaltitel
            // 
            this.labelOriginaltitel.AutoSize = true;
            this.labelOriginaltitel.Location = new System.Drawing.Point(475, 253);
            this.labelOriginaltitel.Name = "labelOriginaltitel";
            this.labelOriginaltitel.Size = new System.Drawing.Size(91, 20);
            this.labelOriginaltitel.TabIndex = 34;
            this.labelOriginaltitel.Text = "Originaltitel:";
            // 
            // textBoxOriginaltitel
            // 
            this.textBoxOriginaltitel.Location = new System.Drawing.Point(607, 249);
            this.textBoxOriginaltitel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxOriginaltitel.MaxLength = 100;
            this.textBoxOriginaltitel.Name = "textBoxOriginaltitel";
            this.textBoxOriginaltitel.Size = new System.Drawing.Size(228, 27);
            this.textBoxOriginaltitel.TabIndex = 35;
            // 
            // buttonTaBortFörfattare
            // 
            this.buttonTaBortFörfattare.Location = new System.Drawing.Point(393, 248);
            this.buttonTaBortFörfattare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTaBortFörfattare.Name = "buttonTaBortFörfattare";
            this.buttonTaBortFörfattare.Size = new System.Drawing.Size(76, 31);
            this.buttonTaBortFörfattare.TabIndex = 36;
            this.buttonTaBortFörfattare.Text = "Ta bort";
            this.buttonTaBortFörfattare.UseVisualStyleBackColor = true;
            this.buttonTaBortFörfattare.Click += new System.EventHandler(this.buttonTaBortFörfattare_Click);
            // 
            // buttonRemoveTranslator
            // 
            this.buttonRemoveTranslator.Location = new System.Drawing.Point(842, 171);
            this.buttonRemoveTranslator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRemoveTranslator.Name = "buttonRemoveTranslator";
            this.buttonRemoveTranslator.Size = new System.Drawing.Size(30, 31);
            this.buttonRemoveTranslator.TabIndex = 37;
            this.buttonRemoveTranslator.Text = "X";
            this.buttonRemoveTranslator.UseVisualStyleBackColor = true;
            this.buttonRemoveTranslator.Click += new System.EventHandler(this.buttonRemoveTranslator_Click);
            // 
            // buttonRemoveGrade
            // 
            this.buttonRemoveGrade.Location = new System.Drawing.Point(842, 288);
            this.buttonRemoveGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRemoveGrade.Name = "buttonRemoveGrade";
            this.buttonRemoveGrade.Size = new System.Drawing.Size(30, 31);
            this.buttonRemoveGrade.TabIndex = 38;
            this.buttonRemoveGrade.Text = "X";
            this.buttonRemoveGrade.UseVisualStyleBackColor = true;
            this.buttonRemoveGrade.Click += new System.EventHandler(this.buttonRemoveGrade_Click);
            // 
            // label1Star
            // 
            this.label1Star.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1Star.ForeColor = System.Drawing.Color.Red;
            this.label1Star.Location = new System.Drawing.Point(131, 16);
            this.label1Star.Margin = new System.Windows.Forms.Padding(0);
            this.label1Star.Name = "label1Star";
            this.label1Star.Size = new System.Drawing.Size(23, 31);
            this.label1Star.TabIndex = 39;
            this.label1Star.Text = "*";
            this.label1Star.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(131, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 31);
            this.label1.TabIndex = 39;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(131, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 31);
            this.label2.TabIndex = 39;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(131, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 31);
            this.label3.TabIndex = 39;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(131, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 31);
            this.label4.TabIndex = 39;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(131, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 31);
            this.label5.TabIndex = 39;
            this.label5.Text = "*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(581, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 31);
            this.label6.TabIndex = 39;
            this.label6.Text = "*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(581, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 31);
            this.label7.TabIndex = 39;
            this.label7.Text = "*";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(581, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 31);
            this.label8.TabIndex = 39;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(581, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 31);
            this.label9.TabIndex = 39;
            this.label9.Text = "*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(581, 209);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 31);
            this.label10.TabIndex = 39;
            this.label10.Text = "*";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddNewBookDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 371);
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
            this.Controls.Add(this.label1Star);
            this.Controls.Add(this.buttonRemoveGrade);
            this.Controls.Add(this.buttonRemoveTranslator);
            this.Controls.Add(this.buttonTaBortFörfattare);
            this.Controls.Add(this.textBoxOriginaltitel);
            this.Controls.Add(this.labelOriginaltitel);
            this.Controls.Add(this.listBoxFörfattare);
            this.Controls.Add(this.buttonLäggTillFörfattare);
            this.Controls.Add(this.comboBoxAddAuthor);
            this.Controls.Add(this.textBoxFormat);
            this.Controls.Add(this.labelFörfattare);
            this.Controls.Add(this.comboBoxBetygAvNiclas);
            this.Controls.Add(this.buttonLäggTill);
            this.Controls.Add(this.buttonRensa);
            this.Controls.Add(this.textBoxSpråk);
            this.Controls.Add(this.labelSpråk);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.comboBoxÖversättareID);
            this.Controls.Add(this.labelÖversättareID);
            this.Controls.Add(this.textBoxVikt);
            this.Controls.Add(this.labelVikt);
            this.Controls.Add(this.comboBoxFörlagsID);
            this.Controls.Add(this.labelFörlagsID);
            this.Controls.Add(this.labelBetygAvNiclas);
            this.Controls.Add(this.textBoxSidor);
            this.Controls.Add(this.labelSidor);
            this.Controls.Add(this.comboBoxGenreID);
            this.Controls.Add(this.labelGenreID);
            this.Controls.Add(this.textBoxPris);
            this.Controls.Add(this.labelPris);
            this.Controls.Add(this.dateTimePickerUtgivningsdatum);
            this.Controls.Add(this.labelUtgivningsdatum);
            this.Controls.Add(this.textBoxTitel);
            this.Controls.Add(this.labelTitel);
            this.Controls.Add(this.textBoxIsbn);
            this.Controls.Add(this.labelIsbn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(903, 418);
            this.MinimumSize = new System.Drawing.Size(903, 418);
            this.Name = "AddNewBookDBForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lägg till ny bok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIsbn;
        private System.Windows.Forms.TextBox textBoxIsbn;
        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.TextBox textBoxTitel;
        private System.Windows.Forms.Label labelUtgivningsdatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerUtgivningsdatum;
        private System.Windows.Forms.Label labelPris;
        private System.Windows.Forms.TextBox textBoxPris;
        private System.Windows.Forms.Label labelGenreID;
        private System.Windows.Forms.ComboBox comboBoxGenreID;
        private System.Windows.Forms.Label labelSidor;
        private System.Windows.Forms.TextBox textBoxSidor;
        private System.Windows.Forms.Label labelBetygAvNiclas;
        private System.Windows.Forms.Label labelFörlagsID;
        private System.Windows.Forms.ComboBox comboBoxFörlagsID;
        private System.Windows.Forms.Label labelVikt;
        private System.Windows.Forms.TextBox textBoxVikt;
        private System.Windows.Forms.Label labelÖversättareID;
        private System.Windows.Forms.ComboBox comboBoxÖversättareID;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.Label labelSpråk;
        private System.Windows.Forms.TextBox textBoxSpråk;
        private System.Windows.Forms.Button buttonRensa;
        private System.Windows.Forms.Button buttonLäggTill;
        private System.Windows.Forms.ComboBox comboBoxBetygAvNiclas;
        private System.Windows.Forms.Label labelFörfattare;
        private System.Windows.Forms.TextBox textBoxFormat;
        private System.Windows.Forms.ComboBox comboBoxAddAuthor;
        private System.Windows.Forms.Button buttonLäggTillFörfattare;
        private System.Windows.Forms.ListBox listBoxFörfattare;
        private System.Windows.Forms.Label labelOriginaltitel;
        private System.Windows.Forms.TextBox textBoxOriginaltitel;
        private System.Windows.Forms.Button buttonTaBortFörfattare;
        private System.Windows.Forms.Button buttonRemoveTranslator;
        private System.Windows.Forms.Button buttonRemoveGrade;
        private System.Windows.Forms.Label label1Star;
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
    }
}