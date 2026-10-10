using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Library_Tech.FORMS
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void Login_form_Load_1(object sender, EventArgs e)
        {
            int alpha = (int)(0.8 * 255); // 0.5 is the opacity value
            int red = 240;
            int green = 235; 
            int blue = 210; 

            panel1.BackColor = Color.FromArgb(alpha, red, green, blue);

            label1.Visible = false;
            label2.Visible = false;
        }

        // the login button
        private void button_login_Click_1(object sender, EventArgs e)
        {
            THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

            string username = textBox_username.Text;
            string password = textBoxPassword.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username`=@usn AND `password`=@pass", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //check if this user exist or not
            if (table.Rows.Count > 0)// if exist
            {
                if (table.Rows[0][5].ToString().Equals("admin"))
                {
                    {
                        Dashboard_Form dashf = new Dashboard_Form();
                        dashf.Show();

                        textBoxPassword.Clear();
                        textBox_username.Clear();
                    }
                }
                else if (table.Rows[0][5].ToString().Equals("student"))
                {
                    Dashboard_Form dashf = new Dashboard_Form();
                    dashf.Show();
                    dashf.button_authors.Enabled = false;
                    dashf.button_Genres.Enabled = false;
                    dashf.button_Books.Enabled = false;
                    dashf.button_circulation.Enabled = false;
                    dashf.button_students.Enabled = false;
                    dashf.button2.Enabled = false;

                    textBoxPassword.Clear();
                    textBox_username.Clear();
                }
            }


            else //  if not 
            {
                // chech if the username is empty
                if (username.Trim().Equals(""))
                {
                    label2.Visible = true;
                }
                //  if this data doesn't exist
                else if (password.Trim().Equals(""))
                {
                    {
                        label1.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
