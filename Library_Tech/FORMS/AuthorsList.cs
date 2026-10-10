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
    public partial class AuthorsList : Form
    {
        public AuthorsList()
        {
            InitializeComponent();
        }

        CLASSES.AUTHOR author = new CLASSES.AUTHOR();
        private void AuthorsList_Load(object sender, EventArgs e)
        {
            /*int alpha = (int)(0.6 * 255); // 0.5 is the opacity value
            int red = 240;
            int green = 235;
            int blue = 210;

            panel1.BackColor = Color.FromArgb(alpha, red, green, blue);*/

            // populate datagridview with authors
            dataGridView_authors.DataSource = author.AuthorsList(false);

            // customize the datagridview header
            dataGridView_authors.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_authors.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dataGridView_authors.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_authors.EnableHeadersVisualStyles = false;


            // show the number of authors 

        }

        private void button_Show_Author_Books_Click(object sender, EventArgs e)
        {
            int author_Id = Convert.ToInt32(dataGridView_authors.CurrentRow.Cells[0].Value.ToString());
            string fname = dataGridView_authors.CurrentRow.Cells[1].Value.ToString();
            string lname = dataGridView_authors.CurrentRow.Cells[2].Value.ToString();
            string fullname = fname + " " + lname;
            BookList bkl = new BookList(author_Id, fullname);
            bkl.Show();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
