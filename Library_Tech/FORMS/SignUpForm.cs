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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        CLASSES.USER users = new CLASSES.USER();
        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            label_fn.Visible = false;
            label_ln.Visible = false;
            label_user.Visible = false;
            label_pass.Visible = false;
            label_reEnter.Visible = false;
            label_user8.Visible = false;
            label_pass8.Visible = false;
            label_mismatch.Visible = false;
        }

        private bool ValidateUsernameAndPassword(string username, string password)
        {
            bool isValid = true;

            if (username.Length < 8)
            {
                label_user8.Visible = true;
                isValid = false;
            }

            if (password.Length < 8)
            {
                label_pass8.Visible = true;
                isValid = false;
            }
            return isValid;
        }

        private bool ValidateReEnterPassword(string password, string reEnterPassword)
        {
            if (password != reEnterPassword)
            {
                label_mismatch.Visible = true;
                return false;
            }
            return true;
        }
        private void button_add_Click(object sender, EventArgs e)
       {
            label_fn.Visible = false;
            label_ln.Visible = false;
            label_user.Visible = false;
            label_pass.Visible = false;
            label_reEnter.Visible = false;
            label_user8.Visible = false;
            label_pass8.Visible = false;
            label_mismatch.Visible = false;

            string fname = textBox_fname.Text;
            string lname = textBox_lname.Text;
            string username = textBox_userName.Text;
            string password = textBox_pass.Text;
            string userType = "user";
            string reEnterPassword = textBox_confirmPass.Text;

            if (checkBox1.Checked)
            {
                userType = "admin";
            }
            else
            {
                userType = "student";
            }

            if (fname.Trim().Equals(""))
            {
                label_fn.Visible = true;
            }
            else if (lname.Trim().Equals(""))
            {
                label_ln.Visible = true;
            }
            else if (username.Trim().Equals(""))
            {
                label_user.Visible = true;
            }
            else if (password.Trim().Equals(""))
            {
                label_pass.Visible = true;
            }
            else if (reEnterPassword.Trim().Equals(""))
            {
                label_reEnter.Visible = true;
            }
            else if (!ValidateUsernameAndPassword(username, password))
            {
                // Username or password is invalid
            }
            else if (!ValidateReEnterPassword(password, reEnterPassword))
            {
                // Passwords do not match
            }
            else
            if (users.isUsernameExists(username))
            {
                MessageBox.Show("This Username Has Already Been Taken", "Data Entry Duplication", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                users.addUser(fname, lname, username, password, userType);
                MessageBox.Show("New User Added Successfully", "New User", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
