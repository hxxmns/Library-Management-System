using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Tech.CLASSES
{
    
    internal class USER
    {

        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

        // create a function to add a new user
        public Boolean addUser(string fname, string lname, string username, string password, string userType)
        {
            string query = "INSERT INTO `users`(`first_name`, `last_name`, `username`, `password`, `userType`) VALUES (@fn,@ln,@un,@pass,@utyp)";

            MySqlParameter[] paramters = new MySqlParameter[5];

            paramters[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            paramters[0].Value = fname;

            paramters[1] = new MySqlParameter("@ln", MySqlDbType.VarChar);
            paramters[1].Value = lname;

            paramters[2] = new MySqlParameter("@un", MySqlDbType.VarChar);
            paramters[2].Value = username;

            paramters[3] = new MySqlParameter("@pass", MySqlDbType.VarChar);
            paramters[3].Value = password;

            paramters[4] = new MySqlParameter("@utyp", MySqlDbType.VarChar);
            paramters[4].Value = userType;

            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        // create a function to edit user's data
        public Boolean editUser(int id, string fname, string lname, string username, string password, string userType)
        {

            string query = "UPDATE `users` SET `first_name`=@fn,`last_name`=@ln,`username`=@un,`password`=@pass,`userType`=@utyp WHERE `id`=@id";

            MySqlParameter[] paramters = new MySqlParameter[6];

            paramters[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            paramters[0].Value = fname;

            paramters[1] = new MySqlParameter("@ln", MySqlDbType.VarChar);
            paramters[1].Value = lname;

            paramters[2] = new MySqlParameter("@un", MySqlDbType.VarChar);
            paramters[2].Value = username;

            paramters[3] = new MySqlParameter("@pass", MySqlDbType.VarChar);
            paramters[3].Value = password;

            paramters[4] = new MySqlParameter("@utyp", MySqlDbType.Int32);
            paramters[4].Value = userType;

            paramters[5] = new MySqlParameter("@id", MySqlDbType.VarChar);
            paramters[5].Value = id;

            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // create a function to remove the selected user
        public Boolean removeUser(int id)
        {
            string query = "DELETE FROM `users` WHERE `id` =@id";

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

        // create a function to return table of users
        public DataTable usersList()
        {
            string query = "SELECT * FROM `users`";

            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }
        public Boolean isUsernameExists(string username)
        {
            string query = "SELECT * FROM `users` WHERE username = @un";

            MySqlParameter[] paramters = new MySqlParameter[1];
            paramters[0] = new MySqlParameter("@un", MySqlDbType.VarChar);
            paramters[0].Value = username;

            DataTable table = new DataTable();
            table = db.getData(query, paramters);

            if (table.Rows.Count > 0)
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
