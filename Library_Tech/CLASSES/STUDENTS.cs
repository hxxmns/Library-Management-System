using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Library_Tech.CLASSES
{

    internal class STUDENTS
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

        // create a function to add a new member
        public Boolean addStudents(string fname, string lname, string gender, string phone, string email, byte[] profile)
        {

            string query = "INSERT INTO `students`(`first_name`, `last_name`, `gender`, `phone`, `email`, `picture`) VALUES (@fn,@ln,@gender,@phone,@email,@prof)";

            MySqlParameter[] paramters = new MySqlParameter[6];

            paramters[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            paramters[0].Value = fname;

            paramters[1] = new MySqlParameter("@ln", MySqlDbType.VarChar);
            paramters[1].Value = lname;

            paramters[2] = new MySqlParameter("@gender", MySqlDbType.VarChar);
            paramters[2].Value = gender;

            paramters[3] = new MySqlParameter("@phone", MySqlDbType.VarChar);
            paramters[3].Value = phone;

            paramters[4] = new MySqlParameter("@email", MySqlDbType.VarChar);
            paramters[4].Value = email;

            paramters[5] = new MySqlParameter("@prof", MySqlDbType.Blob);
            paramters[5].Value = profile;

            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // create a function to edit member
        public Boolean editStudents(int id, string fname, string lname, string gender, string phone, string email, byte[] profile)
        {
            string query = "UPDATE `students` SET `first_name`=@fn,`last_name`=@ln,`gender`=@gender,`phone`=@phone,`email`=@email,`picture`=@prof WHERE `id`=@id";

            MySqlParameter[] paramters = new MySqlParameter[7];

            paramters[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            paramters[0].Value = fname;

            paramters[1] = new MySqlParameter("@ln", MySqlDbType.VarChar);
            paramters[1].Value = lname;

            paramters[2] = new MySqlParameter("@gender", MySqlDbType.VarChar);
            paramters[2].Value = gender;

            paramters[3] = new MySqlParameter("@phone", MySqlDbType.VarChar);
            paramters[3].Value = phone;

            paramters[4] = new MySqlParameter("@email", MySqlDbType.VarChar);
            paramters[4].Value = email;

            paramters[5] = new MySqlParameter("@prof", MySqlDbType.Blob);
            paramters[5].Value = profile;

            paramters[6] = new MySqlParameter("@id", MySqlDbType.Int32);
            paramters[6].Value = id;

            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // create a function to remove the selected students
        public Boolean removeStudents(int id)
        {
            string query = "DELETE FROM `students` WHERE `id` =@id";

            MySqlParameter[] paramters = new MySqlParameter[1];
            paramters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            paramters[0].Value = id;


            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // create a function to return table of students
        public DataTable StudentsList(Boolean display_fullname)
        {
            string query = "SELECT * FROM `students`";

            if (display_fullname)
            {
                query = "SELECT `id`, Concat(`first_name`, ' ', `last_name`)as FullName, `gender`, `phone`, `email`, `picture` FROM `students` ";
            }


            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        // create a function to search student by id
        
        public DataRow getStudentByID(int studentID)
        {
            string query = "SELECT * FROM `students` WHERE `id` =@id";

            MySqlParameter[] paramters = new MySqlParameter[1];
            paramters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            paramters[0].Value = studentID;

            DataTable table = new DataTable();
            table = db.getData(query, paramters);

            DataRow dr = null;

            if (table.Rows.Count > 0)
            {
                 dr = table.Rows[0];
            }

           
            return dr;
        }
    }
}
