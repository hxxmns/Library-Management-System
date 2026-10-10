using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Tech.FORMS
{
    public partial class BookList : Form
    {
        int author_id;
        string fullname;
        public BookList(int id, string Fullname)
        {
            InitializeComponent();
            this.author_id = id;
            this.fullname = Fullname;
        }

    

        private void label_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            int alpha = (int)(0.8 * 255); // 0.5 is the opacity value
            int red = 240; // Full intensity for red
            int green = 235; // Full intensity for green
            int blue = 210; // Full intensity for blue

            panel1.BackColor = Color.FromArgb(alpha, red, green, blue);

            // display the selected author fullname
            label_author.Text = "books by: " + fullname;

            // display the author books in the listview
            CLASSES.BOOKS book = new CLASSES.BOOKS();
            DataTable booksList = book.authorBooks(author_id);

            ListViewItem[] items = new ListViewItem[booksList.Rows.Count];
            String[] bookId = new String[booksList.Rows.Count];
            String[] titles = new String[booksList.Rows.Count];

            // loop to populate the titles % images
            for (int i = 0; i < booksList.Rows.Count; i++) 
            {
               
                byte[] img = (byte[]) booksList.Rows[i][10];
                MemoryStream ms = new MemoryStream(img);

                // add image to the image list
                imageList_bookCovers.Images.Add(Image.FromStream(ms));

                // add title to the titles array
                titles[i] = ("Book ID: ") + booksList.Rows[i][0] + "  " +  "Title: " + booksList.Rows[i][2].ToString(); 
            }

            listView_books.View = View.LargeIcon;
            imageList_bookCovers.ImageSize = new Size(200, 250);
            listView_books.LargeImageList= imageList_bookCovers;

            // loop to display the data in the listciew
            for(int j = 0; j < imageList_bookCovers.Images.Count; j++)
            { 
            listView_books.Items.Add(new ListViewItem() { Text = titles[j], ImageIndex = j });
            }    
        }
    }
}
