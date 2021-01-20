namespace TheBookShelf
{
    partial class EditRemoveBookForm
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
            this.labelBok = new System.Windows.Forms.Label();
            this.comboBoxBookToRemove = new System.Windows.Forms.ComboBox();
            this.buttonRemoveBook = new System.Windows.Forms.Button();
            this.buttonUpdateBook = new System.Windows.Forms.Button();
            this.Isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Författare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utgivningsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BetygAvNiclas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FörlagsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vikt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÖversättareID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Originaltitel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Språk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBooksForEdit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksForEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBok
            // 
            this.labelBok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBok.AutoSize = true;
            this.labelBok.Location = new System.Drawing.Point(12, 400);
            this.labelBok.Name = "labelBok";
            this.labelBok.Size = new System.Drawing.Size(30, 15);
            this.labelBok.TabIndex = 1;
            this.labelBok.Text = "Bok:";
            // 
            // comboBoxBookToRemove
            // 
            this.comboBoxBookToRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxBookToRemove.FormattingEnabled = true;
            this.comboBoxBookToRemove.Location = new System.Drawing.Point(48, 396);
            this.comboBoxBookToRemove.Name = "comboBoxBookToRemove";
            this.comboBoxBookToRemove.Size = new System.Drawing.Size(186, 23);
            this.comboBoxBookToRemove.TabIndex = 2;
            // 
            // buttonRemoveBook
            // 
            this.buttonRemoveBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveBook.Location = new System.Drawing.Point(241, 396);
            this.buttonRemoveBook.Name = "buttonRemoveBook";
            this.buttonRemoveBook.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveBook.TabIndex = 3;
            this.buttonRemoveBook.Text = "Ta bort";
            this.buttonRemoveBook.UseVisualStyleBackColor = true;
            this.buttonRemoveBook.Click += new System.EventHandler(this.buttonRemoveBook_Click);
            // 
            // buttonUpdateBook
            // 
            this.buttonUpdateBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpdateBook.Location = new System.Drawing.Point(322, 396);
            this.buttonUpdateBook.Name = "buttonUpdateBook";
            this.buttonUpdateBook.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateBook.TabIndex = 4;
            this.buttonUpdateBook.Text = "Uppdatera";
            this.buttonUpdateBook.UseVisualStyleBackColor = true;
            this.buttonUpdateBook.Click += new System.EventHandler(this.buttonUpdateBook_Click);
            // 
            // Isbn
            // 
            this.Isbn.HeaderText = "ISBN";
            this.Isbn.Name = "Isbn";
            this.Isbn.ReadOnly = true;
            this.Isbn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Titel
            // 
            this.Titel.HeaderText = "Titel";
            this.Titel.Name = "Titel";
            this.Titel.ReadOnly = true;
            this.Titel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Författare
            // 
            this.Författare.HeaderText = "Författare";
            this.Författare.Name = "Författare";
            this.Författare.ReadOnly = true;
            this.Författare.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Utgivningsdatum
            // 
            this.Utgivningsdatum.HeaderText = "Utgivningsdatum";
            this.Utgivningsdatum.Name = "Utgivningsdatum";
            this.Utgivningsdatum.ReadOnly = true;
            this.Utgivningsdatum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Pris
            // 
            this.Pris.HeaderText = "Pris";
            this.Pris.Name = "Pris";
            this.Pris.ReadOnly = true;
            this.Pris.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GenreID
            // 
            this.GenreID.HeaderText = "Genre";
            this.GenreID.Name = "GenreID";
            this.GenreID.ReadOnly = true;
            this.GenreID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Sidor
            // 
            this.Sidor.HeaderText = "Sidor";
            this.Sidor.Name = "Sidor";
            this.Sidor.ReadOnly = true;
            this.Sidor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BetygAvNiclas
            // 
            this.BetygAvNiclas.HeaderText = "Betyg av Niclas";
            this.BetygAvNiclas.Name = "BetygAvNiclas";
            this.BetygAvNiclas.ReadOnly = true;
            this.BetygAvNiclas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FörlagsID
            // 
            this.FörlagsID.HeaderText = "Förlag";
            this.FörlagsID.Name = "FörlagsID";
            this.FörlagsID.ReadOnly = true;
            this.FörlagsID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Vikt
            // 
            this.Vikt.HeaderText = "Vikt";
            this.Vikt.Name = "Vikt";
            this.Vikt.ReadOnly = true;
            this.Vikt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ÖversättareID
            // 
            this.ÖversättareID.HeaderText = "Översättare";
            this.ÖversättareID.Name = "ÖversättareID";
            this.ÖversättareID.ReadOnly = true;
            this.ÖversättareID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Format
            // 
            this.Format.HeaderText = "Format";
            this.Format.Name = "Format";
            this.Format.ReadOnly = true;
            this.Format.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Originaltitel
            // 
            this.Originaltitel.HeaderText = "Originaltitel";
            this.Originaltitel.Name = "Originaltitel";
            this.Originaltitel.ReadOnly = true;
            this.Originaltitel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Språk
            // 
            this.Språk.HeaderText = "Språk";
            this.Språk.Name = "Språk";
            this.Språk.ReadOnly = true;
            this.Språk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewBooksForEdit
            // 
            this.dataGridViewBooksForEdit.AllowUserToAddRows = false;
            this.dataGridViewBooksForEdit.AllowUserToDeleteRows = false;
            this.dataGridViewBooksForEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBooksForEdit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooksForEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooksForEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Isbn,
            this.Titel,
            this.Författare,
            this.Utgivningsdatum,
            this.Pris,
            this.GenreID,
            this.Sidor,
            this.BetygAvNiclas,
            this.FörlagsID,
            this.Vikt,
            this.ÖversättareID,
            this.Format,
            this.Originaltitel,
            this.Språk});
            this.dataGridViewBooksForEdit.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBooksForEdit.Name = "dataGridViewBooksForEdit";
            this.dataGridViewBooksForEdit.ReadOnly = true;
            this.dataGridViewBooksForEdit.RowHeadersVisible = false;
            this.dataGridViewBooksForEdit.Size = new System.Drawing.Size(1250, 370);
            this.dataGridViewBooksForEdit.TabIndex = 0;
            this.dataGridViewBooksForEdit.Text = "dataGridView1";
            // 
            // EditRemoveBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 431);
            this.Controls.Add(this.buttonUpdateBook);
            this.Controls.Add(this.buttonRemoveBook);
            this.Controls.Add(this.comboBoxBookToRemove);
            this.Controls.Add(this.labelBok);
            this.Controls.Add(this.dataGridViewBooksForEdit);
            this.Name = "EditRemoveBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Redigera & ta bort bok";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksForEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooksForEdit;
        private System.Windows.Forms.Label labelBok;
        private System.Windows.Forms.ComboBox comboBoxBookToRemove;
        private System.Windows.Forms.Button buttonRemoveBook;
        private System.Windows.Forms.Button buttonUpdateBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Författare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utgivningsdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pris;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BetygAvNiclas;
        private System.Windows.Forms.DataGridViewTextBoxColumn FörlagsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vikt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÖversättareID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Format;
        private System.Windows.Forms.DataGridViewTextBoxColumn Originaltitel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Språk;
    }
}