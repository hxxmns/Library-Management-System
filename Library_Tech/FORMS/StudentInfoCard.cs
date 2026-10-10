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
    public partial class StudentInfoCard : Form
    {
        int studentID;
        public StudentInfoCard(int id)
        {
            InitializeComponent();
            studentID = id;
        }

        CLASSES.STUDENTS students = new CLASSES.STUDENTS();
        private void StudentInfoCard_Load(object sender, EventArgs e)
        {
            try
            {
                DataRow data = students.getStudentByID(studentID);

                if (data != null)
                {
                    label_ID.Text = data["id"].ToString();
                    label_FullName.Text = data["first_name"].ToString() + " " + data["last_name"].ToString();
                    label_gender.Text = data["gender"].ToString();
                    label_phone.Text = data["phone"].ToString();
                    label_email.Text = data["email"].ToString();

                    // display the student profile picture
                    byte[] cover = (byte[])data["picture"];
                    MemoryStream ms = new MemoryStream(cover);
                    pictureBox_profile.Image = Image.FromStream(ms);
                }
                else
                {
                    MessageBox.Show("No Student To Show.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Student Doesn't Exist: " + ex.Message);
            }
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
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
