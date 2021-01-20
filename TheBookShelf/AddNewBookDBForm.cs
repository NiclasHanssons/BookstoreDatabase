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
    public partial class AddNewBookDBForm : Form
    {
        TheBookShelfContext db;
        public event EventHandler UpdateTreeView;

        public AddNewBookDBForm(EventHandler updateTreeView)
        {
            InitializeComponent();
            UpdateTreeView = updateTreeView;
            db = new TheBookShelfContext();

            if (db.Database.CanConnect())
            {
                var authors = db.Författares.ToList();
                var genreId = db.Genrers.ToList();
                var förlagId = db.Förlags.ToList();
                var översättareId = db.Översättares.ToList();

                foreach (var author in authors)
                {
                    comboBoxAddAuthor.Items.Add(author);
                }

                foreach (var genrer in genreId)
                {
                    comboBoxGenreID.Items.Add(genrer.Namn);
                }

                foreach (var förlag in förlagId)
                {
                    comboBoxFörlagsID.Items.Add(förlag.Namn);
                }

                foreach (var översättare in översättareId)
                {
                    comboBoxÖversättareID.Items.Add($"{översättare.Förnamn} {översättare.Efternamn}");
                }
            }
        }

        private void buttonLäggTill_Click(object sender, EventArgs e)
        {
            //Listor för att ta fram rätt ID för att skapa ny bok
            var authorsDbValues = db.Författares.ToList();
            var genreIdDbValues = db.Genrers.ToList();
            var förlagIdDbValues = db.Förlags.ToList();
            var översättareIdDbValues = db.Översättares.ToList();

            //Variabler som skall matas in i ny bok
            var isbn = long.Parse(textBoxIsbn.Text);
            var titel = textBoxTitel;
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
                if (genre.Namn == comboBoxGenreID.Text)
                {
                    genreId = genre.Id;
                }
            }

            foreach (var förlag in förlagIdDbValues)
            {
                if (förlag.Namn == comboBoxFörlagsID.Text)
                {
                    förlagId = förlag.Id;
                }
            }

            foreach (var översättare in översättareIdDbValues)
            {
                if ($"{översättare.Förnamn} {översättare.Efternamn}" == comboBoxÖversättareID.Text)
                {
                    översättareId = översättare.Id;
                }
            }

            List<int> authorIDint = new List<int>();
            foreach (var author in listBoxFörfattare.Items)
            {
                foreach (var authorToAdd in authorsDbValues)
                {
                    if (author.ToString() == $"{authorToAdd.Förnamn} {authorToAdd.Efternamn}")
                    {
                        authorIDint.Add(authorToAdd.Id);
                    }
                }
            }

            var nyBok = new Böcker
            {
                Isbn = isbn,
                Titel = titel.Text,
                Utgivningsdatum = utgivningsdatum.Value,
                Pris = pris,
                GenreId = genreId,
                Sidor = sidor,
                BetygAvNiclas = betygAvNiclas,
                FörlagsId = förlagId,
                Vikt = vikt,
                ÖversättareId = översättareId,
                Format = format,
                Originaltitel = originaltitel,
                Språk = språk
            };

            db.Add(nyBok);
            db.SaveChanges();
            
            for (int i = 0; i < authorIDint.Count; i++)
            {
                var nyBokFörfattareBöcker = new FörfattareBöcker { FörfattareId = authorIDint[i], Isbn = isbn };
                db.Add(nyBokFörfattareBöcker);
            }

            db.SaveChanges();

            UpdateTreeView?.Invoke(this, null);
        }

        private void buttonLäggTillFörfattare_Click(object sender, EventArgs e)
        {
            if (listBoxFörfattare.Items.Contains(comboBoxAddAuthor.SelectedItem))
            {
                MessageBox.Show("Författaren är redan tillaggd.", "Felaktig inmatning");
            }

            else
            {
                listBoxFörfattare.Items.Add(comboBoxAddAuthor.SelectedItem);
            }
        }
    }
}
