using System;
using System.Linq;
using System.Windows.Forms;

namespace TheBookShelf
{
    public partial class EditRemoveAuthorForm : Form
    {
        TheBookShelfContext db;
        public event EventHandler UpdateTreeView;

        public void UpdateAuthorsInformation()
        {
            db = new TheBookShelfContext();

            var authors = db.Författares.ToList();

            comboBoxEditRemoveAuthorSelectAuthor.Items.Clear();
            dataGridViewEditRemoveAuthor.Rows.Clear();

            foreach (var author in authors)
            {
                comboBoxEditRemoveAuthorSelectAuthor.Items.Add(author);
            }

            foreach (var author in authors)
            {
                int rowIndex = dataGridViewEditRemoveAuthor.Rows.Add();
                dataGridViewEditRemoveAuthor.Rows[rowIndex].Cells["FirstName"].Value = author.Förnamn;
                dataGridViewEditRemoveAuthor.Rows[rowIndex].Cells["LastName"].Value = author.Efternamn;
                dataGridViewEditRemoveAuthor.Rows[rowIndex].Cells["DateOfBirth"].Value = author.Födelsedatum.ToString("yyyy-MM-dd");
                dataGridViewEditRemoveAuthor.Rows[rowIndex].Cells["Sex"].Value = author.Kön;
                dataGridViewEditRemoveAuthor.Rows[rowIndex].Cells["Nationality"].Value = author.Nationalitet;
            }
        }

        public EditRemoveAuthorForm(EventHandler updateTreeView)
        {
            InitializeComponent();
            UpdateTreeView = updateTreeView;

            UpdateAuthorsInformation();

        }

        private void ButtonEditRemoveAuthorRemove_Click(object sender, EventArgs e)
        {
            if (comboBoxEditRemoveAuthorSelectAuthor.SelectedItem == null) { return; }

            try
            {
                var authorToRemove = comboBoxEditRemoveAuthorSelectAuthor.SelectedItem as Författare;

                db.Remove(authorToRemove);

                comboBoxEditRemoveAuthorSelectAuthor.SelectedIndex = -1;
                db.SaveChanges();
                UpdateTreeView?.Invoke(this, null);

                comboBoxEditRemoveAuthorSelectAuthor.Items.Clear();
                dataGridViewEditRemoveAuthor.Rows.Clear();

                UpdateAuthorsInformation();
            }
            catch (Exception)
            {
                MessageBox.Show("Författaren har böcker kopplade till sig, vänligen ta bort dessa böcker först.", "Felaktig hantering av författare");
            }
        }

        private void buttonEditRemoveAuthorUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxEditRemoveAuthorSelectAuthor.SelectedItem == null) { return; }

            var authorToEdit = comboBoxEditRemoveAuthorSelectAuthor.SelectedItem as Författare;
            EditAuthorForm editAuthor = new EditAuthorForm(UpdateTreeView, authorToEdit);
            editAuthor.ShowDialog();
            UpdateAuthorsInformation();
        }


    }
}
