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
using System.IO;
using Google.Protobuf.WellKnownTypes;

namespace Library_Tech.FORMS
{

    public partial class ManageStudentsForm : Form
    {
        public ManageStudentsForm()
        {
            InitializeComponent();
        }

        CLASSES.STUDENTS students = new CLASSES.STUDENTS();
        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            // populate datagridview with students

            // customize the datagridview rows height
            dataGridView_students.RowTemplate.Height = 50;

            dataGridView_students.DataSource = students.StudentsList(true);

            // customize the datagridview header
            dataGridView_students.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_students.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dataGridView_students.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_students.EnableHeadersVisualStyles = false;

            

          

            // customize the datagridview image column
            DataGridViewImageColumn dgvImgCol = new DataGridViewImageColumn();
            dgvImgCol = (DataGridViewImageColumn)dataGridView_students.Columns[5];
            dgvImgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;



            // show the number of students 
             label_studentsCount.Text = students.StudentsList(true).Rows.Count.ToString() + " Students";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_SelectProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // image types
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                // display image in the pictureBox
                pictureBox_Profile.Image = Image.FromFile(opf.FileName);
            }
        }

        // button add student
        private void button_add_Click(object sender, EventArgs e)
        {
            string first_name = textBox_fname.Text;
            string last_name = textBox_lname.Text;
            string phone = textBox_number.Text; // Store phone number as a string
            string email = textBox_email.Text;
            string gender = "Male"; // by default

            if (radioButton_female.Checked)
            {
                gender = "Female";
            }

            MemoryStream ms = new MemoryStream();
            pictureBox_Profile.Image.Save(ms, pictureBox_Profile.Image.RawFormat);
            byte[] profile_picture = ms.ToArray();

            // Check if the first/last name and phone text are empty
            if (first_name.Trim().Equals("") || last_name.Trim().Equals("") || phone.Trim().Equals(""))
            {
                MessageBox.Show("You must insert data into the required fields.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                    // Proceed with adding the data
                    if (students.addStudents(first_name, last_name, gender, phone, email, profile_picture))
                    {
                        MessageBox.Show("New Student Added Successfully", "New Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Show the number of students
                        label_studentsCount.Text = students.StudentsList(true).Rows.Count.ToString() + " Students";
                    }
                    else
                    {
                        MessageBox.Show("Student Not Added", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
       
        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_male.ForeColor = Color.LimeGreen;
            radioButton_female.ForeColor = Color.Black;
        }

        private void radioButton_female_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_female.ForeColor = Color.LimeGreen;
            radioButton_male.ForeColor = Color.Black;
        }

        // edit selected student button
        private void button_edit_Click(object sender, EventArgs e)
        {
            int id;
            string first_name = textBox_fname.Text;
            string last_name = textBox_lname.Text;
            string phone = textBox_number.Text;
            string email = textBox_email.Text;
            string gender = "Male"; // by default

            if (radioButton_female.Checked)
            {
                gender = "Female";
            }


            MemoryStream ms = new MemoryStream();
            pictureBox_Profile.Image.Save(ms, pictureBox_Profile.Image.RawFormat);
            byte[] profile_picture = ms.ToArray();



            if (!textBox_id.Text.Trim().Equals(""))
            {
                //check if the first/last name are empty
                if (first_name.Trim().Equals("") || last_name.Trim().Equals("") || phone.Trim().Equals(""))


                {
                    MessageBox.Show(" You Must Insert Data To The Required Fields", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    id= Convert.ToInt32(textBox_id.Text);
                    if (students.editStudents(id, first_name, last_name, gender, phone, email, profile_picture))
                    {

                        MessageBox.Show(" Student's Data Updated Succesfully ", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // show the number of students 
                        label_studentsCount.Text = students.StudentsList(true).Rows.Count.ToString() + " Students";

                    }
                    else
                    {
                        MessageBox.Show(" Student Data Not Edited", "Edit-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select A Student From The Table First", "Empty ID", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

        }

        // remove selected student
        private void button_delete_Click(object sender, EventArgs e)
        {
            int id;
            if (!textBox_id.Text.Trim().Equals(""))
            {
                id = Convert.ToInt32(textBox_id.Text);

                // show confirmation before delete
                if (MessageBox.Show("Do You Really Want To Delete This Student?", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (students.removeStudents(id))
                    {
                        MessageBox.Show(" Student Removed Succesfully ", "Remove Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // update the number of students 
                        label_studentsCount.Text = students.StudentsList(true).Rows.Count.ToString() + " Students";

                        //clear fields
                        button_Clear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show(" Student Not Removed", "Check If This Student-ID Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                
            }
            else
            {
                MessageBox.Show("Select A Student From The Table First", "Empty ID", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        // display the selected data
        private void dataGridView_students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_students.CurrentRow.Cells[0].Value.ToString();

            // get the first and last name from the fullname column
            string fullname = dataGridView_students.CurrentRow.Cells[1].Value.ToString();
            var first_and_last_name = fullname.Split(' ');

            textBox_fname.Text = first_and_last_name[0];
            textBox_lname.Text = first_and_last_name[1];
            string gender = dataGridView_students.CurrentRow.Cells[2].Value.ToString();
            if (gender.Equals("Male"))
            {
                radioButton_male.Checked = true;
            }
            else
            {
                radioButton_female.Checked = false;
            }
            textBox_number.Text = dataGridView_students.CurrentRow.Cells[3].Value.ToString();
            textBox_email.Text = dataGridView_students.CurrentRow.Cells[4].Value.ToString();

            byte[] prof =(byte[]) dataGridView_students.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(prof);
            pictureBox_Profile.Image = Image.FromStream(ms);

        }

        // button to clear all fields
        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_id.Text = "";
            textBox_fname.Text = "";
            textBox_lname.Text = "";
            radioButton_male.Checked = true;
            textBox_number.Text = "";
            textBox_email.Text = "";
        }

        // refresh the datagridview with the new data
        private void button_refresh_Click(object sender, EventArgs e)
        {
            // refresh datagridview  
            dataGridView_students.DataSource = students.StudentsList(true);

        }
        private void textBox_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { 
                e.Handled= true;
            }
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {

        }
    }
}
