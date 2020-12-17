namespace TheBookShelf
{
    partial class DataGridViewBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewUcBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUcBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Titel
            // 
            this.Titel.HeaderText = "Titel";
            this.Titel.Name = "Titel";
            this.Titel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Författare
            // 
            this.Författare.HeaderText = "Författare";
            this.Författare.Name = "Författare";
            this.Författare.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Utgivningsdatum
            // 
            this.Utgivningsdatum.HeaderText = "Utgivningsdatum";
            this.Utgivningsdatum.Name = "Utgivningsdatum";
            this.Utgivningsdatum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Pris
            // 
            this.Pris.HeaderText = "Pris";
            this.Pris.Name = "Pris";
            this.Pris.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GenreID
            // 
            this.GenreID.HeaderText = "GenreID";
            this.GenreID.Name = "GenreID";
            this.GenreID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Sidor
            // 
            this.Sidor.HeaderText = "Sidor";
            this.Sidor.Name = "Sidor";
            this.Sidor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BetygAvNiclas
            // 
            this.BetygAvNiclas.HeaderText = "Betyg av Niclas";
            this.BetygAvNiclas.Name = "BetygAvNiclas";
            this.BetygAvNiclas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FörlagsID
            // 
            this.FörlagsID.HeaderText = "FörlagsID";
            this.FörlagsID.Name = "FörlagsID";
            this.FörlagsID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Vikt
            // 
            this.Vikt.HeaderText = "Vikt";
            this.Vikt.Name = "Vikt";
            this.Vikt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ÖversättareID
            // 
            this.ÖversättareID.HeaderText = "ÖversättareID";
            this.ÖversättareID.Name = "ÖversättareID";
            this.ÖversättareID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Format
            // 
            this.Format.HeaderText = "Format";
            this.Format.Name = "Format";
            this.Format.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Originaltitel
            // 
            this.Originaltitel.HeaderText = "Originaltitel";
            this.Originaltitel.Name = "Originaltitel";
            this.Originaltitel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Språk
            // 
            this.Språk.HeaderText = "Språk";
            this.Språk.Name = "Språk";
            this.Språk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridViewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 
            // dataGridViewUcBooks
            // 
            this.dataGridViewUcBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUcBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
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
            this.dataGridViewUcBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUcBooks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUcBooks.Name = "dataGridViewUcBooks";
            this.dataGridViewUcBooks.RowHeadersVisible = false;
            this.dataGridViewUcBooks.Size = new System.Drawing.Size(739, 310);
            this.dataGridViewUcBooks.TabIndex = 0;
            this.dataGridViewUcBooks.Text = "dataGridView1";
            this.Controls.Add(this.dataGridViewUcBooks);
            this.Name = "DataGridViewBooks";
            this.Size = new System.Drawing.Size(739, 310);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUcBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUcBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
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
