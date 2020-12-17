using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TheBookShelf
{
    
    
    public partial class DataGridViewBooks : UserControl
    {
        public DataGridView dataGridViewBooksPanel2;
        public DataGridViewBooks()
        {
            InitializeComponent();

            dataGridViewBooksPanel2 = dataGridViewUcBooks;
        }
    }
}
