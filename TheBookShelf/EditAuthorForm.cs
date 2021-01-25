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
    public partial class EditAuthorForm : Form
    {
        TheBookShelfContext db;
        public event EventHandler UpdateTreeView;
        public Författare AuthorToEdit;
        public DataGridView DataGridUpdate;
        public ComboBox ComboBoxUpdate;

        public EditAuthorForm(EventHandler updateTreeView, Författare authorForEdit, DataGridView dataGridUpdate, ComboBox comboBoxUpdate)
        {
            InitializeComponent();
            UpdateTreeView = updateTreeView;
            AuthorToEdit = authorForEdit;
            db = new TheBookShelfContext();
            DataGridUpdate = dataGridUpdate;
            ComboBoxUpdate = comboBoxUpdate;

            textBoxFirstname.Text = authorForEdit.Förnamn;
            textBoxLastname.Text = authorForEdit.Efternamn;
            comboBoxSex.SelectedItem = authorForEdit.Kön;
            dateTimePickerFödelsedatum.Value = authorForEdit.Födelsedatum;
            textBoxNationality.Text = authorForEdit.Nationalitet;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxFirstname.Text.Length > 0 && textBoxLastname.Text.Length > 0 && comboBoxSex.Text.Length > 0 && textBoxNationality.Text.Length > 0)
            {
                var authors = db.Författares.ToList();
                var firstName = textBoxFirstname;
                var lastName = textBoxLastname;
                var birthdate = dateTimePickerFödelsedatum;
                var sex = comboBoxSex;
                var nationality = textBoxNationality;

                foreach (var author in authors)
                {
                    if (author.Id == AuthorToEdit.Id)
                    {
                        author.Förnamn = textBoxFirstname.Text;
                        author.Efternamn = textBoxLastname.Text;
                        author.Födelsedatum = dateTimePickerFödelsedatum.Value;
                        author.Kön = sex.Text;
                        author.Nationalitet = textBoxNationality.Text;
                    }
                }

                db.SaveChanges();

                ComboBoxUpdate.Items.Clear();
                foreach (var author in authors)
                {
                    ComboBoxUpdate.Items.Add(author);
                }

                DataGridUpdate.Rows.Clear();

                foreach (var author in authors)
                {
                    int rowIndex = DataGridUpdate.Rows.Add();
                    DataGridUpdate.Rows[rowIndex].Cells["FirstName"].Value = author.Förnamn;
                    DataGridUpdate.Rows[rowIndex].Cells["LastName"].Value = author.Efternamn;
                    DataGridUpdate.Rows[rowIndex].Cells["DateOfBirth"].Value = author.Födelsedatum.ToString("yyyy-MM-dd");
                    DataGridUpdate.Rows[rowIndex].Cells["Sex"].Value = author.Kön;
                    DataGridUpdate.Rows[rowIndex].Cells["Nationality"].Value = author.Nationalitet;
                }
                UpdateTreeView?.Invoke(this, null);

                MessageBox.Show($"Information om {firstName.Text} {lastName.Text} är uppdaterad.", "Författare uppdaterad");
                this.Close();
            }

            else
            {
                MessageBox.Show("Vänligen fyll i alla uppgifter.", "Personuppgifter saknas");
            }
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
