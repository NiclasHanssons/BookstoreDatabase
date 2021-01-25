using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheBookShelf
{
    public partial class AddNewBookForm : Form
    {
        TheBookShelfContext db;
        public event EventHandler UpdateTreeView;

        public AddNewBookForm(EventHandler updateTreeView)
        {
            InitializeComponent();
            UpdateTreeView = updateTreeView;
            db = new TheBookShelfContext();

            if (db.Database.CanConnect())
            {
                var stores = db.Butiker
                       .Include(stores => stores.LagerSaldos)
                       .ThenInclude(LagerSaldos => LagerSaldos.IsbnSaldo)
                       .ToList();

                var authorsBooks = db.FörfattareBöckers.ToList();

                var books = db.Böckers
                    .Include(books => books.LagerSaldos)
                    .ToList();

                var stocks = db.LagerSaldos.ToList();

                foreach (var store in stores)
                {
                    comboBoxSelectStore.Items.Add(store);
                    comboBoxSelectStoreRemove.Items.Add(store);
                }

                foreach (var book in books)
                {
                    comboBoxAddNewBook.Items.Add(book);
                }
            }

            else
            {
                Debug.WriteLine("Connection failed!");
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (comboBoxAddNewBook.SelectedItem == null) { return; }

            var lagerBooks = db.LagerSaldos.ToList();
            var book = comboBoxAddNewBook.SelectedItem as Böcker;
            var store = comboBoxSelectStore.SelectedItem as Butiker;
            var lagerSaldo = new LagerSaldo { Isbn = book.Isbn, ButikId = store.Id, Antal = 1 };

            //FEL, KOLLAR INTE RÄTT!
            foreach (var bookInStore in lagerBooks)
            {
                if (bookInStore.ButikId == store.Id)
                {
                    if (bookInStore.IsbnSaldo.Isbn == book.Isbn)
                    {
                        MessageBox.Show("Bok finns redan tillaggd i butiken.", "Boken finns redan");
                        return;
                    }
                }
            }

            db.Entry(lagerSaldo).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;

            db.Add(lagerSaldo);
            db.SaveChanges();
            UpdateTreeView?.Invoke(this, null);
        }

        private void AddNewBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }

        private void comboBoxRemoveBook_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxRemoveBook.Items.Clear();

            var storeRemoveBook = comboBoxSelectStoreRemove.SelectedItem as Butiker;

            foreach (var book in storeRemoveBook.LagerSaldos)
            {
                comboBoxRemoveBook.Items.Add(book.IsbnSaldo);
            }
        }

        private void buttonRemoveBook_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectStoreRemove.SelectedItem == null) { return; }
            if (comboBoxRemoveBook.SelectedItem == null) { return; }

            var book = comboBoxRemoveBook.SelectedItem as Böcker;
            var store = comboBoxSelectStoreRemove.SelectedItem as Butiker;

            foreach (var item in book.LagerSaldos)
            {
                if (store.Id == item.ButikId)
                {
                    db.Remove(item);
                }
            }
            comboBoxRemoveBook.SelectedIndex = -1;
            comboBoxRemoveBook.Items.Clear();
            db.SaveChanges();
            UpdateTreeView?.Invoke(this, null);
        }
    }
}
