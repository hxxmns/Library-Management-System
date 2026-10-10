using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Tech.CLASSES
{
    internal class ISSUE_BOOK
    {

        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        CLASSES.BOOKS book = new CLASSES.BOOKS();

        // create a function to add a new issue
        public Boolean Issue(int bookID, int studentID, string status, DateTime issueDate, DateTime returnDate, string note)
        {

            string query = "INSERT INTO `issue_book` (`book_id`, `student_id`, `status`, `issue_date`, `return_date`, `note`) VALUES (@bId, @mId, @stt, @issDt, @rtnDt, @nt)";

            MySqlParameter[] paramters = new MySqlParameter[6];

            paramters[0] = new MySqlParameter("@bId", MySqlDbType.Int32);
            paramters[0].Value = bookID;

            paramters[1] = new MySqlParameter("@mId", MySqlDbType.Int32);
            paramters[1].Value = studentID;

            paramters[2] = new MySqlParameter("@stt", MySqlDbType.VarChar);
            paramters[2].Value = status;

            paramters[3] = new MySqlParameter("@issDt", MySqlDbType.Date);
            paramters[3].Value = issueDate;

            paramters[4] = new MySqlParameter("@rtnDt", MySqlDbType.Date);
            paramters[4].Value = returnDate;

            paramters[5] = new MySqlParameter("@nt", MySqlDbType.Text);
            paramters[5].Value = note;


            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // function to count the issued books
        public int countIssuedCopiesOfThisBook(int bookId)
        {
            string query = "SELECT * FROM `issue_book` WHERE `book_id`=@id and status = 'issued'";

            MySqlParameter[] paramters = new MySqlParameter[1];
            paramters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            paramters[0].Value = bookId;

            return db.getData(query, paramters).Rows.Count;
           
        }

        public Boolean checkBookAvailability(int bookId) 
        {
         // check if the book is available

            Boolean availavility;

            //get the book quantity
            int bookQuantity = Convert.ToInt32(book.getBookInfo(bookId)["quantity"].ToString());

            // get the number of copy of the same book issued
            int issuedCopies = countIssuedCopiesOfThisBook(bookId);

            // now check if the book is still available or not
            // if the quantity is bigger than the number of issued copies
            if (bookQuantity > issuedCopies)
            {
                availavility = true;
            }
            else
            {
                availavility = false;
            }
            return availavility;
        }

        // create a function to return data from table issue 
        public DataTable issueList(string status)
        {
            string query = "SELECT `book_id` as book, `student_id` as student, `status`, `issue_date` issued, `return_date` returned, `note` FROM `issue_book`";

            if(!status.Equals(""))
            {
                query = "SELECT `book_id` as book, `student_id` as student, `status`, `issue_date` issued, `return_date` returned, `note` FROM `issue_book` WHERE `status`='"+status+"'";
            }

            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        // this function allow the user to edit the book status
        public Boolean returnBook(int bookId, int studentId, string status, DateTime issueDate, DateTime returnDate, string note)
        {

            string query = "UPDATE `issue_book` SET `status`=@stt,`return_date`=@rtnDt,`note`=@nt WHERE `book_id`=@bId AND `student_id`=@mId AND `issue_date`=@issDt";

            MySqlParameter[] paramters = new MySqlParameter[6];

            paramters[0] = new MySqlParameter("@stt", MySqlDbType.VarChar);
            paramters[0].Value = status;

            paramters[1] = new MySqlParameter("@rtnDt", MySqlDbType.Date);
            paramters[1].Value = returnDate;

            paramters[2] = new MySqlParameter("@nt", MySqlDbType.Text);
            paramters[2].Value = note;

            paramters[3] = new MySqlParameter("@bId", MySqlDbType.Int32);
            paramters[3].Value = bookId;

            paramters[4] = new MySqlParameter("@mId", MySqlDbType.Int32);
            paramters[4].Value = studentId;

            paramters[5] = new MySqlParameter("@issDt", MySqlDbType.Date);
            paramters[5].Value = issueDate;


            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // create a function to remove the selected transaction
        public Boolean removeData(int bookId, int studentId, DateTime issueDate)
        {
            string query = "DELETE FROM `issue_book` WHERE `book_id`=@bId AND `student_id`=@mId AND `issue_date`=@issDt";

            MySqlParameter[] paramters = new MySqlParameter[3];
            paramters[0] = new MySqlParameter("@bId", MySqlDbType.Int32);
            paramters[0].Value = bookId;

            paramters[1] = new MySqlParameter("@mId", MySqlDbType.Int32);
            paramters[1].Value = studentId;

            paramters[2] = new MySqlParameter("@issDt", MySqlDbType.Date);
            paramters[2].Value = issueDate;


            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // create a function to check if a book is still issued by a student
        public Boolean isBookStillIssuedByStudent(int studentId, int bookId)
        {
            string query = "SELECT * FROM `issue_book` WHERE `status`='issued' AND `book_id`=@bId AND `student_id`=@mId";

            MySqlParameter[] paramters = new MySqlParameter[2];
            paramters[0] = new MySqlParameter("@bId", MySqlDbType.Int32);
            paramters[0].Value = bookId;

            paramters[1] = new MySqlParameter("@mId", MySqlDbType.Int32);
            paramters[1].Value = studentId;

            DataTable table = db.getData(query, paramters);

            if ( table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}

