using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
namespace TheBookShelf
{
    public partial class Form1 : Form
    {
        public int numberOfBook;
        public UserControlTreeView treeView;

        public Form1()
        {
            InitializeComponent();

            DataGridViewBooks dataGridViewBooks = new DataGridViewBooks();
            splitContainer2.Panel2.Controls.Add(dataGridViewBooks);
            dataGridViewBooks.Dock = DockStyle.Fill;

            treeView = new UserControlTreeView(dataGridViewBooks.dataGridViewBooksPanel2, textBoxAdress, textBoxStad, textBoxLand, textBoxButikID, comboBoxBookForLagersaldo);
            splitContainer1.Panel1.Controls.Add(treeView);
            treeView.Dock = DockStyle.Fill;

            using var db = new TheBookShelfContext();
            if (db.Database.CanConnect())
            {
                var books = db.Böckers.ToList();

                foreach (var book in books)
                {
                    comboBoxBookForLagersaldo.Items.Add(book);
                }
            }

            else
            {
                Debug.WriteLine("Connection failed!");
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var db = new TheBookShelfContext())
            {
                if (db.Database.CanConnect())
                {
                    var book = comboBoxBookForLagersaldo.SelectedItem as Böcker;

                    foreach (var bookSaldo in db.LagerSaldos)
                    {

                        if (bookSaldo.ButikId == int.Parse(textBoxButikID.Text) && book.Isbn == bookSaldo.Isbn)
                        {
                            bookSaldo.Antal += int.Parse(textBoxAmount.Text);
                        }
                    }

                    db.SaveChanges();
                }

                else
                {
                    Debug.WriteLine("Connection failed!");
                }
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            using (var db = new TheBookShelfContext())
            {
                if (db.Database.CanConnect())
                {
                    var book = comboBoxBookForLagersaldo.SelectedItem as Böcker;

                    foreach (var bookSaldo in db.LagerSaldos)
                    {

                        if (bookSaldo.ButikId == int.Parse(textBoxButikID.Text) && book.Isbn == bookSaldo.Isbn)
                        {
                            if (bookSaldo.Antal == int.Parse(textBoxAmount.Text) || bookSaldo.Antal > int.Parse(textBoxAmount.Text))
                            {
                                bookSaldo.Antal -= int.Parse(textBoxAmount.Text);
                            }
                        }
                    }

                    db.SaveChanges();
                }

                else
                {
                    Debug.WriteLine("Connection failed!");
                }
            }
        }
    }
}

