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
    public partial class EditBookForm : Form
    {
        TheBookShelfContext db;
        public event EventHandler UpdateTreeView;
        public Böcker BookToEdit;
        private List<Författare> AuthorToEdit;
        private List<FörfattareBöcker> AuthorBookToEdit;
        public List<int> authorIDintForRemove = new List<int>();
        public DataGridView DataGridUpdate;
        public ComboBox ComboBoxUpdate;

        public EditBookForm(EventHandler updateTreeView, Böcker bookToEdit, DataGridView dataGridUpdate, ComboBox comboBoxUpdate)
        {
            InitializeComponent();
            UpdateTreeView = updateTreeView;
            BookToEdit = bookToEdit;
            db = new TheBookShelfContext();
            DataGridUpdate = dataGridUpdate;
            ComboBoxUpdate = comboBoxUpdate;

            if (db.Database.CanConnect())
            {
                AuthorToEdit = db.Författares.ToList();
                AuthorBookToEdit = db.FörfattareBöckers.ToList();
                //var authors = db.Författares.ToList();
                var genreId = db.Genrers.ToList();
                var förlagId = db.Förlags.ToList();
                var översättareId = db.Översättares.ToList();
                //var authorsBooks = db.FörfattareBöckers.ToList();


                foreach (var author in AuthorToEdit)
                {
                    comboBoxAddFörfattare.Items.Add(author);
                }

                foreach (var genrer in genreId)
                {
                    comboBoxGenre.Items.Add(genrer.Namn);
                    if (bookToEdit.GenreId == genrer.Id)
                    {
                        comboBoxGenre.SelectedItem = genrer.Namn;
                    }
                }

                foreach (var förlag in förlagId)
                {
                    comboBoxFörlag.Items.Add(förlag.Namn);
                    if (bookToEdit.FörlagsId == förlag.Id)
                    {
                        comboBoxFörlag.SelectedItem = förlag.Namn;
                    }
                }

                foreach (var översättare in översättareId)
                {
                    comboBoxÖversättare.Items.Add($"{översättare.Förnamn} {översättare.Efternamn}");
                    if (bookToEdit.ÖversättareId == översättare.Id)
                    {
                        comboBoxÖversättare.SelectedItem = $"{översättare.Förnamn} {översättare.Efternamn}";
                    }
                }

                foreach (var author in AuthorBookToEdit)
                {
                    if (author.Isbn == bookToEdit.Isbn)
                    {
                        listBoxFörfattareBok.Items.Add($"{author.Författare}");
                    }
                }

                foreach (var author in listBoxFörfattareBok.Items)
                {
                    foreach (var authorToAdd in AuthorToEdit)
                    {
                        if (author.ToString() == $"{authorToAdd.Förnamn} {authorToAdd.Efternamn}")
                        {
                            authorIDintForRemove.Add(authorToAdd.Id);
                        }
                    }
                }

                textBoxIsbn.Text = bookToEdit.Isbn.ToString();
                textBoxTitel.Text = bookToEdit.Titel;
                dateTimePickerUtgivningsdatum.Value = bookToEdit.Utgivningsdatum;
                textBoxSidor.Text = bookToEdit.Sidor.ToString();
                textBoxFormat.Text = bookToEdit.Format;
                textBoxVikt.Text = bookToEdit.Vikt.ToString();
                textBoxPris.Text = bookToEdit.Pris.ToString();
                textBoxSpråk.Text = bookToEdit.Språk;
                comboBoxBetygAvNiclas.SelectedItem = bookToEdit.BetygAvNiclas.ToString();
                textBoxOriginaltitel.Text = bookToEdit.Originaltitel;
            }
            db.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBoxAddFörfattare.SelectedItem == null) { return; }

            if (listBoxFörfattareBok.Items.Contains(comboBoxAddFörfattare.SelectedItem.ToString()))
            {
                MessageBox.Show("Författaren är redan tillaggd.", "Felaktig inmatning");
            }

            else
            {
                listBoxFörfattareBok.Items.Add(comboBoxAddFörfattare.SelectedItem);
            }
        }

        private void buttonTaBort_Click(object sender, EventArgs e)
        {
            if (listBoxFörfattareBok.SelectedItem == null) { return; }

            if (listBoxFörfattareBok.SelectedItem.ToString().Length > 0)
            {
                listBoxFörfattareBok.Items.Remove(listBoxFörfattareBok.SelectedItem);
            }

            else
            {
                MessageBox.Show("Vänligen välj en författare att ta bort", "Ingen författare vald");
            }
        }

        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            if (textBoxIsbn.Text.IndexOf('0', 0, 1) == 0)
            {
                MessageBox.Show("ISBN kan inte börja med 0.", "Felaktig inmatning");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxIsbn.Text, "^[0-9]*$") || textBoxIsbn.Text.Length < 13)
            {
                MessageBox.Show($"ISBN får endast innehålla siffror och måste vara 13st siffror lång.", "Felaktig inmatning");
                return;
            }

            if (
                !System.Text.RegularExpressions.Regex.IsMatch(textBoxSidor.Text, "^[0-9]*$") ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBoxVikt.Text, "^[0-9]*$") ||
                !System.Text.RegularExpressions.Regex.IsMatch(textBoxPris.Text, "^[0-9]*$") ||
                textBoxPris.Text.Length == 0 ||
                textBoxSidor.Text.Length == 0 ||
                textBoxVikt.Text.Length == 0 ||
                Int32.Parse(textBoxSidor.Text) == 0 ||
                Int32.Parse(textBoxVikt.Text) == 0)
            {
                MessageBox.Show($"Vänligen använd siffror för sidor, vikt och pris.\n0 är inte ett giltligt värde.", "Felaktig inmatning");
                return;
            }

            if (comboBoxGenre.SelectedItem == null)
            {
                MessageBox.Show("Vänligen välj en genre för boken", "Felaktig inmatning");
            }

            if (comboBoxFörlag.SelectedItem == null)
            {
                MessageBox.Show("Vänligen välj ett förlag för boken", "Felaktig inmatning");
            }

            db = new TheBookShelfContext();
            //Listor för att ta fram rätt ID för att uppdatera bok
            var bookDbValues = db.Böckers.ToList();
            var genreIdDbValues = db.Genrers.ToList();
            var förlagIdDbValues = db.Förlags.ToList();
            var översättareIdDbValues = db.Översättares.ToList();

            //Variabler som skall matas in för att uppdatera bok
            var isbn = long.Parse(textBoxIsbn.Text);
            var titel = textBoxTitel.Text;
            var utgivningsdatum = dateTimePickerUtgivningsdatum;
            var pris = Int32.Parse(textBoxPris.Text);
            int genreId = 0;
            var sidor = Int32.Parse(textBoxSidor.Text);
            
            int? betygAvNiclas = null;
            if (comboBoxBetygAvNiclas.SelectedItem != null)
            {
                betygAvNiclas = Int32.Parse(comboBoxBetygAvNiclas.SelectedItem.ToString());
            }
            
            var förlagId = 0;
            var vikt = Int32.Parse(textBoxVikt.Text);
            int? översättareId = null;
            var format = textBoxFormat.Text;
            var originaltitel = textBoxOriginaltitel.Text;
            var språk = textBoxSpråk.Text;

            foreach (var genre in genreIdDbValues)
            {
                if (genre.Namn == comboBoxGenre.Text)
                {
                    genreId = genre.Id;
                }
            }

            foreach (var förlag in förlagIdDbValues)
            {
                if (förlag.Namn == comboBoxFörlag.Text)
                {
                    förlagId = förlag.Id;
                }
            }

            foreach (var översättare in översättareIdDbValues)
            {
                if ($"{översättare.Förnamn} {översättare.Efternamn}" == comboBoxÖversättare.Text)
                {
                    översättareId = översättare.Id;
                }
            }

            List<int> authorIDint = new List<int>();
            foreach (var author in listBoxFörfattareBok.Items)
            {
                foreach (var authorToAdd in AuthorToEdit)
                {
                    if (author.ToString() == $"{authorToAdd.Förnamn} {authorToAdd.Efternamn}")
                    {
                        authorIDint.Add(authorToAdd.Id);
                    }
                }
            }

            foreach (var book in bookDbValues)
            {
                if (BookToEdit.Isbn == book.Isbn)
                {
                    book.Isbn = isbn;
                    book.Titel = titel;
                    book.Utgivningsdatum = utgivningsdatum.Value;
                    book.Sidor = sidor;
                    book.Format = format;
                    book.GenreId = genreId;
                    book.FörlagsId = förlagId;
                    book.Vikt = vikt;
                    book.Pris = pris;
                    book.ÖversättareId = översättareId;
                    book.Språk = språk;
                    book.BetygAvNiclas = betygAvNiclas;
                }
            }
            db.SaveChanges();

            foreach (var authorBook in BookToEdit.FörfattareBöckers)
            {
                var FörfattareBöckerToRemove = new FörfattareBöcker { FörfattareId = authorBook.FörfattareId, Isbn = authorBook.Isbn };
                db.Remove(FörfattareBöckerToRemove);
            }
            db.SaveChanges();

            for (int i = 0; i < authorIDint.Count; i++)
            {
                var nyBokFörfattareBöcker = new FörfattareBöcker { FörfattareId = authorIDint[i], Isbn = isbn };
                db.Add(nyBokFörfattareBöcker);
            }
            db.SaveChanges();

            var books = db.Böckers.ToList();
            var genres = db.Genrers.ToList();
            var publishers = db.Förlags.ToList();
            var translators = db.Översättares.ToList();
            var authors = db.Författares.ToList();
            var authorBooks = db.FörfattareBöckers.ToList();

            DataGridUpdate.Rows.Clear();

            foreach (var book in books)
            {
                int rowIndex = DataGridUpdate.Rows.Add();
                DataGridUpdate.Rows[rowIndex].Cells["ISBN"].Value = book.Isbn;
                DataGridUpdate.Rows[rowIndex].Cells["Titel"].Value = book.Titel;
                DataGridUpdate.Rows[rowIndex].Cells["Utgivningsdatum"].Value = book.Utgivningsdatum.ToString("yyyy-MM-dd");
                DataGridUpdate.Rows[rowIndex].Cells["Pris"].Value = book.Pris;
                DataGridUpdate.Rows[rowIndex].Cells["Sidor"].Value = book.Sidor;
                DataGridUpdate.Rows[rowIndex].Cells["BetygAvNiclas"].Value = book.BetygAvNiclas;
                DataGridUpdate.Rows[rowIndex].Cells["Format"].Value = book.Format;
                DataGridUpdate.Rows[rowIndex].Cells["Vikt"].Value = book.Vikt;
                DataGridUpdate.Rows[rowIndex].Cells["Originaltitel"].Value = book.Originaltitel;
                DataGridUpdate.Rows[rowIndex].Cells["Språk"].Value = book.Språk;

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

                        DataGridUpdate.Rows[rowIndex].Cells["Författare"].Value = authorsOnSameBook;
                    }
                }

                foreach (var genre in genres)
                {
                    if (book.GenreId == genre.Id)
                    {
                        DataGridUpdate.Rows[rowIndex].Cells["GenreID"].Value = genre.Namn;
                    }
                }

                foreach (var förlag in publishers)
                {
                    if (book.FörlagsId == förlag.Id)
                    {
                        DataGridUpdate.Rows[rowIndex].Cells["FörlagsId"].Value = förlag.Namn;
                    }
                }

                foreach (var översättare in translators)
                {
                    if (book.ÖversättareId == översättare.Id)
                    {
                        DataGridUpdate.Rows[rowIndex].Cells["ÖversättareId"].Value = $"{översättare.Förnamn} {översättare.Efternamn}";
                    }
                }
            }

            ComboBoxUpdate.Items.Clear();

            foreach (var book in books)
            {
                ComboBoxUpdate.Items.Add(book);
            }
            ComboBoxUpdate.Text = "";
            ComboBoxUpdate.SelectedIndex = -1;
            UpdateTreeView?.Invoke(this, null);

            MessageBox.Show($"Information om boken: {BookToEdit.Titel} med ISBN: {BookToEdit.Isbn} är uppdaterad.", "Bok uppdaterad");
            db.Dispose();
            this.Close();
        }

        private void buttonRemoveTranslator_Click(object sender, EventArgs e)
        {
            comboBoxÖversättare.SelectedItem = null;
        }

        private void buttonRemoveGrade_Click(object sender, EventArgs e)
        {
            comboBoxBetygAvNiclas.SelectedItem = null;
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

