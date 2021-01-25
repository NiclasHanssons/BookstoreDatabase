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
    public partial class AddAuthorForm : Form
    {
        TheBookShelfContext db;
        public event EventHandler UpdateTreeView;

        public AddAuthorForm(EventHandler updateTreeView)
        {
            InitializeComponent();
            UpdateTreeView = updateTreeView;
            db = new TheBookShelfContext();
            dateTimePickerBirthdate.MaxDate = DateTime.Today;
            dateTimePickerBirthdate.Value = DateTime.Today;
        }

        private void buttonFormAddAuthorAdd_Click(object sender, EventArgs e)
        {
            if (textBoxAddAuthorFirstName.Text.Length > 0 && textBoxAddAuthorLastName.Text.Length > 0 && comboBoxSex.Text.Length > 0 && textBoxAddAuthorNationality.Text.Length > 0)
            {
                var authors = db.Författares.ToList();
                var firstName = textBoxAddAuthorFirstName;
                var lastName = textBoxAddAuthorLastName;
                var birthdate = dateTimePickerBirthdate;
                var sex = comboBoxSex;
                var nationality = textBoxAddAuthorNationality;

                var newAuthor = new Författare { Förnamn = firstName.Text, Efternamn = lastName.Text, Födelsedatum = birthdate.Value, Kön = sex.Text, Nationalitet = nationality.Text };

                db.Add(newAuthor);
                db.SaveChanges();
                UpdateTreeView?.Invoke(this, null);

                MessageBox.Show($"{firstName.Text} {lastName.Text} är tillaggd som författare.", "Ny författare tillaggd");
                textBoxAddAuthorFirstName.Clear();
                textBoxAddAuthorLastName.Clear();
                dateTimePickerBirthdate.ResetText();
                comboBoxSex.SelectedIndex = -1;
                textBoxAddAuthorNationality.Clear();
            }

            else
            {
                MessageBox.Show("Vänligen fyll i alla uppgifter.", "Personuppgifter saknas");
            }
        }

        private void buttonFormAddAuthorClear_Click(object sender, EventArgs e)
        {
            textBoxAddAuthorFirstName.Clear();
            textBoxAddAuthorLastName.Clear();
            comboBoxSex.SelectedIndex = -1;
            textBoxAddAuthorNationality.Clear();
            dateTimePickerBirthdate.Value = DateTime.Today;
        }
    }
}
