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
    public partial class ManageCirculationForm : Form
    {
        public ManageCirculationForm()
        {
            InitializeComponent();
        }

        CLASSES.BOOKS book = new CLASSES.BOOKS();
        CLASSES.STUDENTS students = new CLASSES.STUDENTS();
        CLASSES.ISSUE_BOOK issueBook = new CLASSES.ISSUE_BOOK();
     
        // Function to check if the student ID exists
        private bool studentExists(int studentId)
        {
            return true;
        }


        //display the panel issue 
        private void button2_Click_1(object sender, EventArgs e)
        {
            panel_issue.BringToFront();
        }

        //display the panel return 
        private void button_return_Click_1(object sender, EventArgs e)
        {
            panel_return.BringToFront();
            dataGridView_issueList.DataSource = issueBook.issueList("");
        }

        //display the issued book
        private void button_issued_Click_1(object sender, EventArgs e)
        {
            dataGridView_issueList.DataSource = issueBook.issueList("issued");
        }

        //display the returned book
        private void button_returned_Click_1(object sender, EventArgs e)
        {
            dataGridView_issueList.DataSource = issueBook.issueList("returned");
        }

        //display the lost book
        private void button_lost_Click_1(object sender, EventArgs e)
        {
            dataGridView_issueList.DataSource = issueBook.issueList("lost");
        }

        private void button_returnBook_Click_1(object sender, EventArgs e)
        {
            dataGridView_issueList.DataSource = issueBook.issueList("returned");

            int bookId = Convert.ToInt32(numericUpDown_bookID_2.Value);
            int studentId = Convert.ToInt32(numericUpDown_studentID_2.Value);
            DateTime issueDate = dateTimePicker_issueDate_2.Value;
            DateTime returnDate = dateTimePicker_returnDate_2.Value;
            string note = richTextBox_note_2.Text;

            issueBook.returnBook(bookId, studentId, "returned", issueDate, returnDate, note);

            MessageBox.Show("Book Returned Successfully", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // refresh datagridview  
            dataGridView_issueList.DataSource = issueBook.issueList("");
        }

        private void button_bookLost_Click_1(object sender, EventArgs e)
        {
            dataGridView_issueList.DataSource = issueBook.issueList("lost");

            // change the status to lost
            int bookId = Convert.ToInt32(numericUpDown_bookID_2.Value);
            int studentId = Convert.ToInt32(numericUpDown_studentID_2.Value);
            DateTime issueDate = dateTimePicker_issueDate_2.Value;
            DateTime returnDate = dateTimePicker_returnDate_2.Value;// the day when the book was lost
            string note = richTextBox_note_2.Text;

            if (issueBook.returnBook(bookId, studentId, "lost", issueDate, issueDate, note))
            {
                MessageBox.Show("The Book Has Been Lost", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // edit the book quantity
                // -1 copy due to lost
                if (book.bookQuantityMinusOne(bookId))
                {
                    MessageBox.Show("Book Quantity Updated", "Quantity Minus-One", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Return Date Must Not Be Before The Date Of Issue Date", "Invalid Return Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_deleteTransaction_Click_1(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(numericUpDown_bookID_2.Value);
            int studentId = Convert.ToInt32(numericUpDown_studentID_2.Value);
            DateTime issueDate = dateTimePicker_issueDate_2.Value;

            if (issueBook.removeData(bookId, studentId, issueDate))
            {
                MessageBox.Show("Transaction Has Been Removed Successfully", "Remove Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_issueList.DataSource = issueBook.issueList("");

            }
            else
            {
                MessageBox.Show("Something Went Wrong", "Remove-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //show book profile
        private void label_bookTItle_Click_1(object sender, EventArgs e)
        {
            // get the book id
            int bookID = Convert.ToInt32(numericUpDown_bookID.Value);
            BookInfoCard bookcard = new BookInfoCard(bookID);
            bookcard.ShowDialog();
        }

        //show student profile
        private void label_StudentFullname_Click_1(object sender, EventArgs e)
        {
            // get the student id
            int studentID = Convert.ToInt32(numericUpDown_student_id.Value);
            StudentInfoCard Studentcard = new StudentInfoCard(studentID);
            Studentcard.ShowDialog();
        }

        // issue book
        private void button_issueBook_Click_1(object sender, EventArgs e)
        {
            int bookId, studentId;

            // Check if book ID is a valid integer
            if (!int.TryParse(numericUpDown_bookID.Text, out bookId) || bookId <= 0)
            {
                MessageBox.Show("Please enter a valid Book ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if student ID is a valid integer
            if (!int.TryParse(numericUpDown_student_id.Text, out studentId) || studentId <= 0)
            {
                MessageBox.Show("Please enter a valid Student ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime issueDate = dateTimePicker_issueDate.Value;
            DateTime returnDate = dateTimePicker_returnDate.Value;
            string note = richTextBox_note.Text;

            // Check if the book is still available
            // Return date must not be before the date of issue date
            // Check if a copy of this book is still issued by the same student
            if (issueBook.isBookStillIssuedByStudent(studentId, bookId))
            {
                MessageBox.Show("A Copy Of This Book Is Still On This Student", "Book Can't Issue", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (issueBook.checkBookAvailability(bookId))
                {
                    if (issueDate < returnDate)
                    {
                        if (issueBook.Issue(bookId, studentId, "issued", issueDate, returnDate, note))
                        {
                            MessageBox.Show("Book Issued Successfully", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Return Date Must Not Be Before The Date Of Issue Date", "Invalid Return Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Book Is Not Available", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //search book
        private void button_searchBook_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDown_bookID.Value);
            DataTable table = book.searchBookBy_IDorISBN("id", id, "");

            //Check if the book exist
            if (table.Rows.Count > 0)
            {
                label_bookTItle.Text = table.Rows[0][2].ToString();
                label_bookTItle.ForeColor = Color.LimeGreen;


                // check the book availability
                if (issueBook.checkBookAvailability(id))
                {
                    label_availability.ForeColor = Color.Green;
                    label_availability.Text = "Yes";
                }
                else
                {
                    label_availability.ForeColor = Color.Red;
                    label_availability.Text = "No";
                }
            }
            else
            {
                label_bookTItle.Text = "this book id doesn't exist";
                label_bookTItle.ForeColor = Color.OrangeRed;
            }
        }

        // search student
        private void button_searchStudent_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDown_student_id.Value);
            DataRow row = students.getStudentByID(id);

            if (row != null)
            {
                label_StudentFullname.Text = row["first_name"] + " " + row["last_name"];
                label_StudentFullname.ForeColor = Color.LimeGreen;
            }
            else
            {
                label_StudentFullname.Text = "this student id doesn't exist";
                label_StudentFullname.ForeColor = Color.OrangeRed;
            }
        }

        private void label_bookTItle_MouseLeave_1(object sender, EventArgs e)
        {
            label_bookTItle.Font = new Font(label_bookTItle.Font.FontFamily, 10, FontStyle.Regular);
        }

        private void label_bookTItle_MouseEnter_1(object sender, EventArgs e)
        {
            label_bookTItle.Font = new Font(label_bookTItle.Font.FontFamily, 11, FontStyle.Underline);
        }

        private void ManageCirculationForm_Load_1(object sender, EventArgs e)
        {
            panel_issue.BringToFront();
            // customize the datagridview header
            dataGridView_issueList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_issueList.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dataGridView_issueList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_issueList.EnableHeadersVisualStyles = false;
        }

        private void label_StudentFullname_MouseLeave_1(object sender, EventArgs e)
        {
            label_StudentFullname.Font = new Font(label_StudentFullname.Font.FontFamily, 10, FontStyle.Regular);
        }

        private void label_StudentFullname_MouseEnter_1(object sender, EventArgs e)
        {
            label_StudentFullname.Font = new Font(label_StudentFullname.Font.FontFamily, 11, FontStyle.Underline);
        }

        private void dataGridView_issueList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDown_bookID_2.Value = (int)dataGridView_issueList.CurrentRow.Cells[0].Value;
            numericUpDown_studentID_2.Value = (int)dataGridView_issueList.CurrentRow.Cells[1].Value;
            dateTimePicker_issueDate_2.Value = (DateTime)dataGridView_issueList.CurrentRow.Cells[3].Value;
            dateTimePicker_returnDate_2.Value = (DateTime)dataGridView_issueList.CurrentRow.Cells[4].Value;
            richTextBox_note_2.Text = dataGridView_issueList.CurrentRow.Cells[5].Value.ToString();

            //display the book title
            int bkid = Convert.ToInt32(numericUpDown_bookID_2.Value);
            DataRow bookData = book.getBookInfo(bkid);
            label_book_info.Text = bookData["title"].ToString();

            // display the member fullname
            int stid = Convert.ToInt32(numericUpDown_studentID_2.Value);
            DataRow row = students.getStudentByID(stid);
            label_student_info.Text = row["first_name"] + " " + row["last_name"];
        }
    }
}

