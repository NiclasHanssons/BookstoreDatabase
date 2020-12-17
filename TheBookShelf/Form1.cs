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

            treeView = new UserControlTreeView(dataGridViewBooks.dataGridViewBooksPanel2, textBoxAdress, textBoxStad, textBoxLand, textBoxButikID);
            splitContainer1.Panel1.Controls.Add(treeView);
            treeView.Dock = DockStyle.Fill;

            
        }
    }
}

