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
    public partial class genreList : Form
    {
        public genreList()
        {
            InitializeComponent();
        }

        CLASSES.GENRE genre = new CLASSES.GENRE();
        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void genreList_Load(object sender, EventArgs e)
        {
            dataGridView_genres.DataSource = genre.GenresList();

            // customize the datagridview header
            dataGridView_genres.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_genres.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
            dataGridView_genres.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_genres.EnableHeadersVisualStyles = false;
        }

        private void button_Show_Genre_Books_Click(object sender, EventArgs e)
        {
            int genre_Id = Convert.ToInt32(dataGridView_genres.CurrentRow.Cells[0].Value.ToString());
            string name = dataGridView_genres.CurrentRow.Cells[1].Value.ToString();

            BooksBySelectedGenre bbsg = new BooksBySelectedGenre(genre_Id, name);
            bbsg.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
