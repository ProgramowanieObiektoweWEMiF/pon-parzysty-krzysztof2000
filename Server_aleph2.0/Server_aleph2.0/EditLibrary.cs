using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server_aleph_2
{
    public partial class EditLibrary : Form
    {
        private Control editLibrary;

        public EditLibrary(object alephControl)
        {
            editLibrary = (Control) alephControl;
            InitializeComponent();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                window_server.Log("Brak argumentu");
                return;
            }

            editLibrary.RemoveBook(textBox1.Text);
        }

        private void AddBook_Click(object sender, MouseEventArgs e)
        {
            if (NameBook.Text == "")
            {
                window_server.Log("Brak argumentu nazwy książki");
                return;
            }

            editLibrary.AddNewBook(NameBook.Text, AutorBook.Text, DescriptionBook.Text, BorrowBook.Text);
        }


      


    }
}
