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
    public partial class BooklistForm : Form
    {
        public BooklistForm()
        {
            InitializeComponent();
        }

        CLASSES.BOOKS book = new CLASSES.BOOKS();

        private void BooklistForm_Load_1(object sender, EventArgs e)
        {
            /*int alpha = (int)(0.8 * 255); // 0.5 is the opacity value
            int red = 240;
            int green = 235;
            int blue = 210;

            panel_booklist.BackColor = Color.FromArgb(alpha, red, green, blue);*/

            // Customize the DataGridView rows height
            dataGridView_bookList.RowTemplate.Height = 75;

            // Display books in the DataGridView
            dataGridView_bookList.DataSource = book.BooksList();

            // Customize the DataGridView image column
            DataGridViewImageColumn dgvImgCol = new DataGridViewImageColumn();
            dgvImgCol = (DataGridViewImageColumn)dataGridView_bookList.Columns[10];
            dgvImgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            // Customize the DataGridView header
            dataGridView_bookList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_bookList.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dataGridView_bookList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_bookList.EnableHeadersVisualStyles = false;
        }
    }
}
