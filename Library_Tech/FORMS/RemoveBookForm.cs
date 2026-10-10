using Library_Tech.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Tech.FORMS
{
    public partial class RemoveBookForm : Form
    {
        public RemoveBookForm()
        {
            InitializeComponent();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // remove book
        CLASSES.BOOKS books = new CLASSES.BOOKS();
        private void button_RemoveBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_deletebook.Text))
            {
                if (int.TryParse(textBox_deletebook.Text, out int id))
                {
                    if (books.removeBook(id))
                    {
                        MessageBox.Show("Book Removed Successfully", "Remove Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Book Not Removed. Check If This Book-ID Exists", "Remove Book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Book ID. Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Insert a Book ID First", "Empty ID", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}