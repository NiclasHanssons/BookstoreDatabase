using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheBookShelf
{
    public partial class EditRemoveBookForm : Form
    {
        TheBookShelfContext db;
        public event EventHandler UpdateTreeView;

        public void UpdateBooksInformation()
        {
            db = new TheBookShelfContext();

            var books = db.Böckers.ToList();
            var genres = db.Genrers.ToList();
            var publishers = db.Förlags.ToList();
            var translators = db.Översättares.ToList();
            var authors = db.Författares.ToList();
            var authorBooks = db.FörfattareBöckers.ToList();
            
            dataGridViewBooksForEdit.Rows.Clear();
            comboBoxBookToRemove.Items.Clear();

            foreach (var book in books)
            {
                comboBoxBookToRemove.Items.Add(book);
            }

            foreach (var book in books)
            {
                int rowIndex = dataGridViewBooksForEdit.Rows.Add();
                dataGridViewBooksForEdit.Rows[rowIndex].Cells["ISBN"].Value = book.Isbn;
                dataGridViewBooksForEdit.Rows[rowIndex].Cells["Titel"].Value = book.Titel;
                dataGridViewBooksForEdit.Rows[rowIndex].Cells["Utgivningsdatum"].Value = book.Utgivningsdatum.ToString("yyyy-MM-dd");
                dataGridViewBooksForEdit.Rows[rowIndex].Cells["Pris"].Value = book.Pris;
                dataGridViewBooksForEdit.Rows[rowIndex].Cells["Sidor"].Value = book.Sidor;
                dataGridViewBooksForEdit.Rows[rowIndex].Cells["BetygAvNiclas"].Value = book.BetygAvNiclas;
                dataGridViewBooksForEdit.Rows[rowIndex].Cells["Format"].Value = book.Format;
                dataGridViewBooksForEdit.Rows[rowIndex].Cells["Vikt"].Value = book.Vikt;
                dataGridViewBooksForEdit.Rows[rowIndex].Cells["Originaltitel"].Value = book.Originaltitel;
                dataGridViewBooksForEdit.Rows[rowIndex].Cells["Språk"].Value = book.Språk;

                string authorsOnSameBook = "";

                foreach (var author in authorBooks)
                {
                    if (author.Isbn == book.Isbn)
                    {
                        if (authorsOnSameBook.Length == 0)
                        {
                            authorsOnSameBook += $"{author.Författare.Förnamn} {author.Författare.Efternamn}";
                        }

                        else
                        {
                            authorsOnSameBook += $", {author.Författare.Förnamn} {author.Författare.Efternamn}";
                        }

                        dataGridViewBooksForEdit.Rows[rowIndex].Cells["Författare"].Value = authorsOnSameBook;
                    }
                }

                foreach (var genre in genres)
                {
                    if (book.GenreId == genre.Id)
                    {
                        dataGridViewBooksForEdit.Rows[rowIndex].Cells["GenreID"].Value = genre.Namn;
                    }
                }

                foreach (var förlag in publishers)
                {
                    if (book.FörlagsId == förlag.Id)
                    {
                        dataGridViewBooksForEdit.Rows[rowIndex].Cells["FörlagsId"].Value = förlag.Namn;
                    }
                }

                foreach (var översättare in translators)
                {
                    if (book.ÖversättareId == översättare.Id)
                    {
                        dataGridViewBooksForEdit.Rows[rowIndex].Cells["ÖversättareId"].Value = $"{översättare.Förnamn} {översättare.Efternamn}";
                    }
                }
            }
        }

        public EditRemoveBookForm(EventHandler updateTreeView)
        {
            InitializeComponent();
            UpdateTreeView = updateTreeView;

            UpdateBooksInformation();
        }

        private void buttonRemoveBook_Click(object sender, EventArgs e)
        {
            if (comboBoxBookToRemove.SelectedItem == null) { return; }

            try
            {
                var bookToRemove = comboBoxBookToRemove.SelectedItem as Böcker;

                db.Remove(bookToRemove);
                db.SaveChanges();

                comboBoxBookToRemove.SelectedIndex = -1;

                UpdateTreeView?.Invoke(this, null);

                comboBoxBookToRemove.Items.Clear();
                dataGridViewBooksForEdit.Rows.Clear();

                UpdateBooksInformation();
            }
            catch (Exception)
            {
                MessageBox.Show("Du kan inte ta bort en bok som finns i lager hos en butik. Vänligen hantera lagersaldot först", "Inte möjligt att ta bort bok");
            }
        }

        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            if (comboBoxBookToRemove.SelectedItem == null) { return; }

            var bookToEdit = comboBoxBookToRemove.SelectedItem as Böcker;
            EditBookForm editBook = new EditBookForm(UpdateTreeView, bookToEdit);
            editBook.ShowDialog();
            UpdateBooksInformation();
        }
    }
}
