using Library_Tech.CLASSES;
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
    public partial class BookInfoCard : Form
    {
        int bookID;
        public BookInfoCard(int id)
        {
            InitializeComponent();
            bookID = id;
        }

        CLASSES.BOOKS book = new CLASSES.BOOKS();
        CLASSES.AUTHOR author = new CLASSES.AUTHOR();

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void BookInfoCard_Load(object sender, EventArgs e)
        {
            try
            {
                //display the book info

                DataRow data = book.getBookInfo(bookID);

                label_isbn.Text = data["isbn"].ToString();
                label_title.Text = data["title"].ToString();
                label_author.Text = data["author"].ToString();
                label_genre.Text = data["genre"].ToString();

                int qty = Convert.ToInt32(data["quantity"].ToString());
                if (qty == 0)
                {
                    label_qty.BackColor = Color.Red;
                }
                else if (qty > 0 && qty < 11)
                {
                    label_qty.BackColor = Color.Orange;
                }
                else
                {
                    label_qty.BackColor = Color.LimeGreen;
                }

                label_qty.Text = data["quantity"].ToString();
                label_price.Text = data["price"].ToString();
                label_publisher.Text = data["publisher"].ToString();
                label_dateAdded.Text = data["date_received"].ToString();
                richTextBox_description.Text = data["description"].ToString();

                // display the book cover
                byte[] cover = (byte[])data["cover"];
                MemoryStream ms = new MemoryStream(cover);
                pictureBox_Cover.Image = Image.FromStream(ms);
            }
            catch(Exception ex)
            {
                MessageBox.Show("No Book To Show," + " " + ex.Message);

                //hide the label quantity
                label_qty.Visible = false;
            }
           
        }

        private void BookInfoCard_MouseEnter(object sender, EventArgs e)
        {
         
        }

        private void BookInfoCard_MouseLeave(object sender, EventArgs e)
        {
       
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
       
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.White;
            label_close.Font = new Font(label_close.Font.FontFamily, 17, FontStyle.Regular);

        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Black;
            label_close.Font = new Font(label_close.Font.FontFamily, 16, FontStyle.Regular);

        }
    }
}
