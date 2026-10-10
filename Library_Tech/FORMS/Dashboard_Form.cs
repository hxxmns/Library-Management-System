using Library_Tech.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Tech.FORMS
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        CLASSES.BOOKS book = new CLASSES.BOOKS();
        CLASSES.AUTHOR author = new CLASSES.AUTHOR();
        CLASSES.STUDENTS students = new CLASSES.STUDENTS();

        private void Dashboard_Form_Load_1(object sender, EventArgs e)
        {
            int alpha = (int)(0.8 * 255); // 0.5 is the opacity value
            int red = 240; // Full intensity for red
            int green = 235; // Full intensity for green
            int blue = 210; // Full intensity for blue

            panel_displayBooks.BackColor = Color.FromArgb(alpha, red, green, blue);
            button_Books.BackColor = Color.FromArgb(alpha, red, green, blue);
            button_authors.BackColor = Color.FromArgb(alpha, red, green, blue);
            button_Genres.BackColor = Color.FromArgb(alpha, red, green, blue);
            button_booklist.BackColor = Color.FromArgb(alpha, red, green, blue);
            button_booksByAuthor.BackColor = Color.FromArgb(alpha, red, green, blue);
            button1.BackColor = Color.FromArgb(alpha, red, green, blue);
            button2.BackColor = Color.FromArgb(alpha, red, green, blue);
            button_circulation.BackColor = Color.FromArgb(alpha, red, green, blue);
            button_students.BackColor = Color.FromArgb(alpha, red, green, blue);
            label1.BackColor = Color.Transparent;

            DataTable bookData = book.BooksList();

            byte[] img;
            MemoryStream ms;
            int i = 0; // index for the table rows

            //using a foreach loop
            foreach (var panelControl in panel_displayBooks.Controls)
            {
                if (panelControl.GetType() == typeof(Panel))
                {
                    //display the book cover to book history
                    Panel panel = (Panel)panelControl;
                    img = (byte[])bookData.Rows[i][10];
                    ms = new MemoryStream(img);
                    panel.BackgroundImage = Image.FromStream(ms);
                    panel.BackgroundImageLayout = ImageLayout.Stretch;

                    // displayy the book price
                    foreach (var labelControl in panel.Controls)
                    {
                        if (labelControl.GetType() == typeof(Label))
                        {
                            Label label = (Label)labelControl;
                            label.Text = "$" + bookData.Rows[i][6].ToString();

                        }
                    }
                    i++;

                }
                CLASSES.USER usertype = new CLASSES.USER();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            genreList gnrl = new genreList();
            gnrl.Show();
        }

        private void button_booksByAuthor_Click_1(object sender, EventArgs e)
        {
            AuthorsList aufht = new AuthorsList();
            aufht.Show();
        }

        private void button_booklist_Click_1(object sender, EventArgs e)
        {
            BooklistForm bklf = new BooklistForm();
            bklf.Show();
        }

        private void button_circulation_Click_1(object sender, EventArgs e)
        {
            // Show manage circulation form
            ManageCirculationForm mcf = new ManageCirculationForm();
            mcf.Show();
        }

        private void button_students_Click_1(object sender, EventArgs e)
        {

            //show the Manage students form
            ManageStudentsForm msf = new ManageStudentsForm();
            msf.Show();
        }

        private void button_Genres_Click_1(object sender, EventArgs e)
        {

            //show the Manage genres form
            ManageGenresForm mgf = new ManageGenresForm();
            mgf.Show();
        }

        private void button_Books_Click_1(object sender, EventArgs e)
        {
            // Show the manage books form
            ManageBooksForm mbf = new ManageBooksForm();
            mbf.Show();
        }

        private void button_authors_Click_1(object sender, EventArgs e)
        {
            //show the Manage authors form
            ManageAuthorForm mga = new ManageAuthorForm();
            mga.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TermsAndConditionForm trmsandcond = new TermsAndConditionForm();
            trmsandcond.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}