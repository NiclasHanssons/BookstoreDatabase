using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Diagnostics;

namespace TheBookShelf
{
    public partial class UserControlTreeView : UserControl
    {
        public DataGridView gridView;
        public TextBox adressBox;
        public TextBox stadBox;
        public TextBox landBox;
        public TextBox butikIdBox;
        public ComboBox comboBookAddRemove;

        public void UpdateTreeView()
        {
            treeViewUcButiker.Nodes.Clear();
            treeViewFörfattare.Nodes.Clear();
            treeViewBöcker.Nodes.Clear();

            using var db = new TheBookShelfContext();
            if (db.Database.CanConnect())
            {
                var stores = db.Butiker
                    .Include(stores => stores.LagerSaldos)
                    .ThenInclude(LagerSaldos => LagerSaldos.IsbnSaldo)
                    .ToList();

                var books = db.Böckers.ToList();
                var stocks = db.LagerSaldos.ToList();
                var authors = db.Författares.ToList();
                var authorsBooks = db.FörfattareBöckers.ToList();

                foreach (var store in stores)
                {
                    TreeNode storeNode = new TreeNode()
                    {
                        Text = $"{store.Namn} ({store.LagerSaldos.Count} titlar)",
                        Tag = store
                    };

                    foreach (var book in store.LagerSaldos)
                    {
                        storeNode.Nodes.Add($"{book.IsbnSaldo.Titel} ({book.Antal} st)");
                        Tag = book;
                    }

                    treeViewUcButiker.Nodes.Add(storeNode);
                }

                foreach (var author in authors)
                {
                    TreeNode authorNode = new TreeNode()
                    {
                        Text = $"{author.Förnamn} {author.Efternamn}",
                        Tag = author
                    };

                    foreach (var authorBok in authorsBooks)
                    {
                        if (authorBok.FörfattareId == author.Id)
                        {
                            authorNode.Nodes.Add(authorBok.IsbnFörfattare.Titel);
                        }
                    }

                    treeViewFörfattare.Nodes.Add(authorNode);
                }

                foreach (var book in books)
                {
                    TreeNode bookNode = new TreeNode()
                    {
                        Text = $"{book.Titel}",
                        Tag = book
                    };

                    treeViewBöcker.Nodes.Add(bookNode);
                }
            }

            else
            {
                Debug.WriteLine("Connection failed!");
            }
        }

        public UserControlTreeView(DataGridView dataGridView, TextBox adress, TextBox stad, TextBox land, TextBox butikId, ComboBox bookAddRemove, Form1 form1)
        {
            InitializeComponent();

            comboBookAddRemove = bookAddRemove;
            gridView = dataGridView;
            adressBox = adress;
            stadBox = stad;
            landBox = land;
            butikIdBox = butikId;

            form1.UpdateTreeView += Form1_UpdateTreeView;
        }

        private void Form1_UpdateTreeView(object sender, EventArgs e)
        {
            UpdateTreeView();
        }

        private void TreeViewUcButiker_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Node.Tag is Butiker butiker)
            {
                adressBox.Text = butiker.Adress;
                stadBox.Text = butiker.Stad;
                landBox.Text = butiker.Land;
                butikIdBox.Text = butiker.Id.ToString();

                using var db = new TheBookShelfContext();
                if (db.Database.CanConnect())
                {
                    var stores = db.Butiker
                        .Include(stores => stores.LagerSaldos)
                        .ThenInclude(LagerSaldos => LagerSaldos.IsbnSaldo)
                        .ToList();

                    var books = db.Böckers
                        .Include(books => books.LagerSaldos)
                        .ToList();

                    var authorsBooks = db.FörfattareBöckers.ToList();
                    var stocks = db.LagerSaldos.ToList();
                    var authors = db.Författares.ToList();
                    var genres = db.Genrers.ToList();
                    var publishers = db.Förlags.ToList();
                    var translators = db.Översättares.ToList();

                    gridView.Rows.Clear();
                    comboBookAddRemove.Items.Clear();

                    foreach (var book in butiker.LagerSaldos)
                    {
                        comboBookAddRemove.Items.Add(book.IsbnSaldo);
                    }

                    foreach (var book in butiker.LagerSaldos)
                    {
                        string authorsOnSameBook = "";
                        int rowIndex = gridView.Rows.Add();

                        foreach (var author in authorsBooks)
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

                                gridView.Rows[rowIndex].Cells["Författare"].Value = authorsOnSameBook;
                            }
                        }

                        gridView.Rows[rowIndex].Cells["ISBN"].Value = book.IsbnSaldo.Isbn;
                        gridView.Rows[rowIndex].Cells["Titel"].Value = book.IsbnSaldo.Titel;
                        gridView.Rows[rowIndex].Cells["Utgivningsdatum"].Value = book.IsbnSaldo.Utgivningsdatum.ToString("yyyy-MM-dd");
                        gridView.Rows[rowIndex].Cells["Pris"].Value = book.IsbnSaldo.Pris;
                        gridView.Rows[rowIndex].Cells["Sidor"].Value = book.IsbnSaldo.Sidor;
                        gridView.Rows[rowIndex].Cells["BetygAvNiclas"].Value = book.IsbnSaldo.BetygAvNiclas;
                        gridView.Rows[rowIndex].Cells["Format"].Value = book.IsbnSaldo.Format;
                        gridView.Rows[rowIndex].Cells["Vikt"].Value = book.IsbnSaldo.Vikt;
                        gridView.Rows[rowIndex].Cells["Originaltitel"].Value = book.IsbnSaldo.Originaltitel;
                        gridView.Rows[rowIndex].Cells["Språk"].Value = book.IsbnSaldo.Språk;

                        foreach (var genre in genres)
                        {
                            if (book.IsbnSaldo.GenreId == genre.Id)
                            {
                                gridView.Rows[rowIndex].Cells["GenreID"].Value = genre.Namn;
                            }
                        }

                        foreach (var förlag in publishers)
                        {
                            if (book.IsbnSaldo.FörlagsId == förlag.Id)
                            {
                                gridView.Rows[rowIndex].Cells["FörlagsId"].Value = förlag.Namn;
                            }
                        }

                        foreach (var översättare in translators)
                        {
                            if (book.IsbnSaldo.ÖversättareId == översättare.Id)
                            {
                                gridView.Rows[rowIndex].Cells["ÖversättareId"].Value = $"{översättare.Förnamn} {översättare.Efternamn}";
                            }
                        }
                    }
                }
            }
        }

        private void UserControlTreeView_Load(object sender, EventArgs e)
        {
            UpdateTreeView();
        }
    }
}
