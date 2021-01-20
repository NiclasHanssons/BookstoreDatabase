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

        public EditBookForm(EventHandler updateTreeView, Böcker bookToEdit)
        {
            InitializeComponent();
            UpdateTreeView = updateTreeView;
            BookToEdit = bookToEdit;
            db = new TheBookShelfContext();

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
            db = new TheBookShelfContext();
            //Listor för att ta fram rätt ID för att uppdatera bok
            var bookDbValues = db.Böckers.ToList();
            //var authorsDbValues = db.Författares.ToList();
            //var authorsBooks = db.FörfattareBöckers.ToList();
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
            var betygAvNiclas = Int32.Parse(comboBoxBetygAvNiclas.SelectedItem.ToString());
            var förlagId = 0;
            var vikt = Int32.Parse(textBoxVikt.Text);
            var översättareId = 0;
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
                //db.Entry(authorBook).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                db.Remove(FörfattareBöckerToRemove);
            }

            db.SaveChanges();


            for (int i = 0; i < authorIDint.Count; i++)
            {
                var nyBokFörfattareBöcker = new FörfattareBöcker { FörfattareId = authorIDint[i], Isbn = isbn };
                db.Add(nyBokFörfattareBöcker);
            }
            db.SaveChanges();

            UpdateTreeView?.Invoke(this, null);
        }
    }
}

