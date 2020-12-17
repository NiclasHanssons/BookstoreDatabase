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
        DataGridView gridView;
        TextBox adressBox;
        TextBox stadBox;
        TextBox landBox;
        TextBox butikIdBox;

        public UserControlTreeView(DataGridView dataGridView, TextBox adress, TextBox stad, TextBox land, TextBox butikId)
        {
            InitializeComponent();

            gridView = dataGridView;
            adressBox = adress;
            stadBox = stad;
            landBox = land;
            butikIdBox = butikId;

            using (var db = new TheBookShelfContext())
            {
                if (db.Database.CanConnect())
                {
                    var stores = db.Butikers
                        .Include(stores => stores.LagerSaldos)
                        .ThenInclude(LagerSaldos => LagerSaldos.IsbnSaldo)
                        .ToList();

                    var books = db.Böckers.ToList();
                    var stocks = db.LagerSaldos.ToList();
                    var authors = db.Författares.ToList();

                    var authorsBooks = db.FörfattareBöckers.ToList();


                    //var publishers = db.Förlags.ToList();
                    //var genrers = db.Genrers.ToList();
                    //var customers = db.Kunders.ToList();
                    //var translators = db.Översättares.ToList();

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
                        //foreach (var book in authorsBooks)
                        //{
                        //    authorNode.Nodes.Add(book);
                        //}

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
        }

        private void treeViewUcButiker_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Node.Tag is Butiker Butiker)
            {
                adressBox.Text = Butiker.Adress;
                stadBox.Text = Butiker.Stad;
                landBox.Text = Butiker.Land;
                butikIdBox.Text = Butiker.Id.ToString();

                using (var db = new TheBookShelfContext())
                {
                    if (db.Database.CanConnect())
                    {
                        var stores = db.Butikers
                            .Include(stores => stores.LagerSaldos)
                            .ThenInclude(LagerSaldos => LagerSaldos.IsbnSaldo)
                            .ToList();

                        var authorsBooks = db.FörfattareBöckers.ToList();

                        var books = db.Böckers
                            .Include(books => books.LagerSaldos)
                            .ToList();

                        var stocks = db.LagerSaldos.ToList();
                        var authors = db.Författares.ToList();
                        var publishers = db.Förlags.ToList();
                        var genrers = db.Genrers.ToList();
                        var customers = db.Kunders.ToList();
                        var translators = db.Översättares.ToList();

                        gridView.Rows.Clear();
                        foreach (var book in Butiker.LagerSaldos)
                        {
                            int rowIndex = gridView.Rows.Add();

                            foreach (var author in authorsBooks)
                            {
                                if (book.Isbn == author.Isbn)
                                {
                                    gridView.Rows[rowIndex].Cells["Författare"].Value = $"{author.Författare.Förnamn} {author.Författare.Efternamn}";
                                }
                            }

                            gridView.Rows[rowIndex].Cells["ISBN"].Value = book.IsbnSaldo.Isbn;
                            gridView.Rows[rowIndex].Cells["Titel"].Value = book.IsbnSaldo.Titel;
                            gridView.Rows[rowIndex].Cells["Utgivningsdatum"].Value = book.IsbnSaldo.Utgivningsdatum.ToString("yyyy-MM-dd");
                            gridView.Rows[rowIndex].Cells["Pris"].Value = book.IsbnSaldo.Pris;
                            gridView.Rows[rowIndex].Cells["GenreId"].Value = book.IsbnSaldo.GenreId;
                            gridView.Rows[rowIndex].Cells["Sidor"].Value = book.IsbnSaldo.Sidor;
                            gridView.Rows[rowIndex].Cells["BetygAvNiclas"].Value = book.IsbnSaldo.BetygAvNiclas;
                            gridView.Rows[rowIndex].Cells["Format"].Value = book.IsbnSaldo.Format;
                            gridView.Rows[rowIndex].Cells["Vikt"].Value = book.IsbnSaldo.Vikt;
                            gridView.Rows[rowIndex].Cells["FörlagsId"].Value = book.IsbnSaldo.FörlagsId;
                            gridView.Rows[rowIndex].Cells["ÖversättareId"].Value = book.IsbnSaldo.ÖversättareId;
                            gridView.Rows[rowIndex].Cells["Originaltitel"].Value = book.IsbnSaldo.Originaltitel;
                            gridView.Rows[rowIndex].Cells["Språk"].Value = book.IsbnSaldo.Språk;
                        }
                    }
                }
            }
        }
    }
}
