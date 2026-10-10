using Google.Protobuf.WellKnownTypes;
using Library_Tech.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Tech.FORMS
{
    public partial class ManageBooksForm : Form
    {
        public ManageBooksForm()
        {
            InitializeComponent();
        }

        CLASSES.BOOKS book = new CLASSES.BOOKS();
        CLASSES.GENRE genre = new CLASSES.GENRE();
        CLASSES.AUTHOR author = new CLASSES.AUTHOR();

        // create a function to display data in the fields
        public void displayData(DataTable data)
        {
            // display book data
            textBox_editID.Text = data.Rows[0][0].ToString();
            textBox_editISBN.Text = data.Rows[0][1].ToString();
            textBox_editTitle.Text = data.Rows[0][2].ToString();

            //get tge author data
            int author_id = Convert.ToInt32(data.Rows[0][3].ToString());
            DataTable authordata = author.getAuthorById(author_id);
            // first name               last name
            textBox_editAuthor.Text = authordata.Rows[0][1].ToString() + " " + authordata.Rows[0][2].ToString();
            label_editAuthorID.Text = data.Rows[0][3].ToString();

            textBox_editPrice.Text = data.Rows[0][6].ToString();
            textBox_editPublisher.Text = data.Rows[0][7].ToString();
            richTextBox_editDescription.Text = data.Rows[0][9].ToString();
            numericUpDown_editqty.Value = Convert.ToInt32(data.Rows[0][5].ToString());
            comboBox_editGenre.SelectedValue = data.Rows[0][4].ToString();
            dateTimePicker_editDatercv.Value = (DateTime)data.Rows[0][8];

            // display the book cover
            byte[] cover = (byte[])data.Rows[0][10];
            MemoryStream ms = new MemoryStream(cover);
            pictureBox_editCover.Image = Image.FromStream(ms);
        }

        private void ManageBooksForm_Load_1(object sender, EventArgs e)
        {
            int alpha = (int)(0.8 * 255); // 0.5 is the opacity value
            int red = 240; // Full intensity for red
            int green = 235; // Full intensity for green
            int blue = 210; // Full intensity for blue

            panel1.BackColor = Color.FromArgb(alpha, red, green, blue);

            // populate the combobox with genres(add panel)          

            comboBox_genre.DataSource = genre.GenresList();
            comboBox_genre.DisplayMember = "name";
            comboBox_genre.ValueMember = "id";

            // show the number of books 
            label_booksCount.Text = book.BooksList().Rows.Count.ToString() + " Books";

            // populate combobox with genres
            comboBox_editGenre.DataSource = genre.GenresList();
            comboBox_editGenre.DisplayMember = "name";
            comboBox_editGenre.ValueMember = "id";

            panel_add.BringToFront();
        }

        // SHOW ADD PANEL
        private void button_add_Click_1(object sender, EventArgs e)
        {
            panel_add.BringToFront();

            textBox_Author.Text = "";
            label_author_id.Text = "ID";
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            panel_edit.BringToFront();

            // populate the combobox with genres(edit panel)

            comboBox_editGenre.DataSource = genre.GenresList();
            comboBox_editGenre.DisplayMember = "name";
            comboBox_editGenre.ValueMember = "id";

            textBox_editAuthor.Text = "";
            label_editAuthorID.Text = "ID";
        }

        // SHOW DELETE PANEL
        private void button_delete_Click_1(object sender, EventArgs e)
        {
            // show the remove book form
            RemoveBookForm rmvbk = new RemoveBookForm();
            rmvbk.Show();
        }

        // SHOW BOOKLIST PANEL
        private void button_booklist_Click(object sender, EventArgs e)
        {
            panel_booklist.BringToFront();

            // customize the datagridview rows height
            dataGridView_bookList.RowTemplate.Height = 75;

            // display books in the datagridview
            dataGridView_bookList.DataSource = book.BooksList();

            // customize the datagridview image column
            DataGridViewImageColumn dgvImgCol = new DataGridViewImageColumn();
            dgvImgCol = (DataGridViewImageColumn)dataGridView_bookList.Columns[10];
            dgvImgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            // customize the datagridview header
            dataGridView_bookList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_bookList.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dataGridView_bookList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_bookList.EnableHeadersVisualStyles = false;
        }

        //SHOW AUTHORS IN A NEW FORM
        private void button_selectAuthor_Click_1(object sender, EventArgs e)
        {
            AuthorsListForm athslsform = new AuthorsListForm(this);
            athslsform.Show();
        }

        private void button_SelectCover_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // image types
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                // display image in the pictureBox
                pictureBox_Cover.Image = Image.FromFile(opf.FileName);
            }
        }

        //BUTTON TO ADD A NEW BOOK
        private void button_AddBook_Click_1(object sender, EventArgs e)
        {
            // get data
            int author_id;
            int genre_id;
            int quantity;
            double price;
            string isbn = textBox_isbn.Text;
            string title = textBox_Title.Text;
            string publisher = textBox_Publisher.Text;
            string description = richTextBox_Description.Text;
            DateTime date_received = dateTimePicker_DateReceived.Value;

            MemoryStream ms = new MemoryStream();
            pictureBox_Cover.Image.Save(ms, pictureBox_Cover.Image.RawFormat);
            byte[] book_cover = ms.ToArray();

            try
            {
                author_id = Convert.ToInt32(label_author_id.Text);
                genre_id = Convert.ToInt32(comboBox_genre.SelectedValue);
                quantity = Convert.ToInt32(numericUpDown_qty.Value);
                price = Convert.ToDouble(textBox_Price.Text);

                if (!book.isIsbnExists(isbn, 0))
                {
                    if (!book.isTitleExists(title, 0))
                    {
                        if (book.addBook(isbn, title, author_id, genre_id, quantity, price, publisher, date_received, description, book_cover))
                        {
                            MessageBox.Show("New Book Added Succesfully ", "New Book", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // refresh the books counter
                            label_booksCount.Text = book.BooksList().Rows.Count.ToString() + " Books";

                            foreach (var control in panel_add.Controls)
                            {
                                if (control.GetType() == typeof(TextBox))
                                {
                                    TextBox tb = (TextBox)control;
                                    tb.Text = "";
                                }
                            }
                            richTextBox_Description.Text = "";
                            label_author_id.Text = "";
                            comboBox_genre.SelectedIndex = 0;
                            numericUpDown_qty.Value = 0;
                            dateTimePicker_DateReceived.Value = DateTime.Now;
                        
                    }
                        else
                        {
                            MessageBox.Show("Book Not Added", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Book Title Already Exists, Enter A New One", "DATA ENTRY DUPLICATED", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("This Book ISBN Already Exists, Enter A New One", "DATA ENTRY DUPLICATED", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //EXPORT DATA TO TXT FILE
        private void button_exportBooks_Click_1(object sender, EventArgs e)
        {
            // call the button show books so that the datagridview will be populated
            button_booklist.PerformClick();

            if (!Directory.Exists(@"C:\books"))
            {
                Directory.CreateDirectory(@"C:\books");
            }


            string filePath = @"C:\books\list.txt";

            if (!File.Exists(filePath))// check if this exist
            {
                File.Create(filePath).Close();//create the file
                MessageBox.Show("file created");
            }
            // populate the text file with -id- -isbn- -title-
            TextWriter writer = new StreamWriter(filePath);


            string id;
            string isbn;
            string title;

            for (int i = 0; i < dataGridView_bookList.Rows.Count; i++) // for rows
            {
                //display id, isbn, title
                id = dataGridView_bookList.Rows[i].Cells[0].Value.ToString();
                isbn = dataGridView_bookList.Rows[i].Cells[1].Value.ToString();
                title = dataGridView_bookList.Rows[i].Cells[2].Value.ToString();


                writer.Write(id + " - " + isbn + " - " + title);

                writer.WriteLine("");//create a new line
                writer.WriteLine("-----------------------------------------");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        // EDIT BOOK(BOOKLIST PANEL)
        private void button1_Click_1(object sender, EventArgs e)
        {
            panel_edit.BringToFront();

            int id = Convert.ToInt32(dataGridView_bookList.CurrentRow.Cells[0].Value);
            DataTable data = book.searchBookBy_IDorISBN("id", id, "");
            if (data.Rows.Count > 0)
            {
                displayData(data);
            }
            else
            {
                MessageBox.Show("This Book ID Does Not Exists, Enter A New One", "ID Not Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        // DELETE BOOK(BOOKLIST PANEL)
        private void button2_Click_1(object sender, EventArgs e)
        {
            button_delete.PerformClick();
            try
            {
                int bookId = Convert.ToInt32(dataGridView_bookList.CurrentRow.Cells[0].Value.ToString());

                //confirmation
                if (MessageBox.Show("Do You Really Want To Delete This Book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (book.removeBook(bookId))
                    {
                        MessageBox.Show("Book Removed Successfully", "Remove Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Book Not Removed. Check If This Book-ID Exists", "Remove Book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please Select a Book on the Table | " + ex.Message, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //SEARCH BOOK (EDIT PANEL)
        private void button_searchID_Click_1(object sender, EventArgs e)
        {
            string inputText = textBox_editID.Text.Trim();

            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Please enter a valid Book ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(inputText, out int id))
            {
                MessageBox.Show("Invalid input. Please enter a valid integer for Book ID or ISBN.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable data = book.searchBookBy_IDorISBN("id", id, "");

            if (data.Rows.Count > 0)
            {
                displayData(data);
            }
            else
            {
                MessageBox.Show("This Book ID Does Not Exist. Enter a new one.", "ID Not Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button_searchISBN_Click_1(object sender, EventArgs e)
        {
            string isbn = textBox_editISBN.Text.Trim();

            if (string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Please enter a valid ISBN.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable data = book.searchBookBy_IDorISBN("isbn", 0, isbn);

            if (data.Rows.Count > 0)
            {
                displayData(data);
            }
            else
            {
                MessageBox.Show("This Book ISBN Does Not Exist. Enter a new one.", "ISBN Not Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        // show authors list in a new form (edit panel)
        private void button_editselectauthor_Click_1(object sender, EventArgs e)
        {
            AuthorsListForm athslsform = new AuthorsListForm(this);
            athslsform.Show();
        }

        // BUTTON TO EDIT A BOOK
        private void button_editBook_Click_1(object sender, EventArgs e)
        {
            // get data
            int id;
            int author_id;
            int genre_id;
            int quantity;
            double price;
            string isbn = textBox_editISBN.Text;
            string title = textBox_editTitle.Text;
            string publisher = textBox_editPublisher.Text;
            string description = richTextBox_editDescription.Text;
            DateTime date_received = dateTimePicker_editDatercv.Value;

            MemoryStream ms = new MemoryStream();
            pictureBox_editCover.Image.Save(ms, pictureBox_editCover.Image.RawFormat);
            byte[] book_cover = ms.ToArray();

            try
            {
                id = Convert.ToInt32(textBox_editID.Text);
                author_id = Convert.ToInt32(label_editAuthorID.Text);
                genre_id = Convert.ToInt32(comboBox_editGenre.SelectedValue);
                quantity = Convert.ToInt32(numericUpDown_editqty.Value);
                price = Convert.ToDouble(textBox_editPrice.Text);

                if (book.editBook(id, isbn, title, author_id, genre_id, quantity, price, publisher, date_received, description, book_cover))
                {
                    MessageBox.Show("Book Updated Succesfully ", "Edit Book", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(" Book Not Edited", "Edit-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // BUTTON TO SELECT A COVER PHOTO (EDIT)
        private void button_editSelectcoverphoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // image types
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                // display image in the pictureBox
                pictureBox_editCover.Image = Image.FromFile(opf.FileName);
            }
        }
    }       
    }

