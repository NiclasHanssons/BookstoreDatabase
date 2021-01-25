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

            dateTimePickerUtgivningsdatum.MaxDate = DateTime.Today;
            dateTimePickerUtgivningsdatum.Value = DateTime.Today;

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

            if (textBoxTitel.Text == "" || textBoxFormat.Text == "" || textBoxSpråk.Text == "")
            {
                MessageBox.Show($"Vänligen se över att alla fält har korrekt information.", "Felaktig inmatning");
                return;
            }

            if (comboBoxGenreID.SelectedItem == null)
            {
                MessageBox.Show("Vänligen välj en genre för boken", "Felaktig inmatning");
                return;
            }

            if (comboBoxFörlagsID.SelectedItem == null)
            {
                MessageBox.Show("Vänligen välj ett förlag för boken", "Felaktig inmatning");
                return;
            }

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
            var förlagId = 0;
            var vikt = Int32.Parse(textBoxVikt.Text);
            int? översättareId = null;
            var format = textBoxFormat.Text;
            var originaltitel = textBoxOriginaltitel.Text;
            var språk = textBoxSpråk.Text;
            int? betygAvNiclas = null;

            if (comboBoxBetygAvNiclas.Text.Length > 0)
            {
                betygAvNiclas = Int32.Parse(comboBoxBetygAvNiclas.SelectedItem.ToString());
            }

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
            MessageBox.Show($"Bok: {nyBok.Titel} med ISBN: {nyBok.Isbn} är tillaggd i databasen.", "Bok tillaggd");
        }

        private void buttonLäggTillFörfattare_Click(object sender, EventArgs e)
        {
            if (comboBoxAddAuthor.SelectedItem == null) { return; }

            if (listBoxFörfattare.Items.Contains(comboBoxAddAuthor.SelectedItem))
            {
                MessageBox.Show("Författaren är redan tillaggd.", "Felaktig inmatning");
            }

            else
            {
                listBoxFörfattare.Items.Add(comboBoxAddAuthor.SelectedItem);
            }
        }

        private void buttonTaBortFörfattare_Click(object sender, EventArgs e)
        {
            if (listBoxFörfattare.SelectedItem == null) { return; }

            if (listBoxFörfattare.SelectedItem.ToString().Length > 0)
            {
                listBoxFörfattare.Items.Remove(listBoxFörfattare.SelectedItem);
            }
        }

        private void buttonRemoveTranslator_Click(object sender, EventArgs e)
        {
            comboBoxÖversättareID.SelectedItem = null;
        }

        private void buttonRemoveGrade_Click(object sender, EventArgs e)
        {
            comboBoxBetygAvNiclas.SelectedItem = null;
        }

        private void buttonRensa_Click(object sender, EventArgs e)
        {
            textBoxIsbn.Clear();
            textBoxTitel.Clear();
            textBoxFormat.Clear();
            textBoxOriginaltitel.Clear();
            textBoxPris.Clear();
            textBoxSidor.Clear();
            textBoxSpråk.Clear();
            textBoxVikt.Clear();
            comboBoxBetygAvNiclas.SelectedItem = null;
            comboBoxÖversättareID.SelectedItem = null;
            comboBoxGenreID.SelectedItem = null;
            comboBoxFörlagsID.SelectedItem = null;
            listBoxFörfattare.Items.Clear();
            comboBoxAddAuthor.SelectedItem = null;
            dateTimePickerUtgivningsdatum.Value = DateTime.Today;
        }
    }
}
