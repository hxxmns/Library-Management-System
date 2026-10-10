using Library_Tech.CLASSES;
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
    public partial class ManageAuthorForm : Form
    {

        CLASSES.AUTHOR author = new CLASSES.AUTHOR();
        public ManageAuthorForm()
        {
            InitializeComponent();
        }

        private void ManageAuthorForm_Load_1(object sender, EventArgs e)
        {
            // populate datagridview with authors
            dataGridView_authors.DataSource = author.AuthorsList(false);

            // customize the datagridview header
            dataGridView_authors.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_authors.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dataGridView_authors.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_authors.EnableHeadersVisualStyles = false;

            // show the number of authors 
            label_authorCount.Text = author.AuthorsList(false).Rows.Count.ToString() + " Authors";
        }

        //button to edit author
        private void button_edit_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string first_name = textBox_fname.Text;
                string last_name = textBox_lname.Text;
                string education = textBox_educ.Text;
                string bio = richTextBox_bio.Text;

                //check if the first/last name are empty
                if (first_name.Trim().Equals("") || last_name.Trim().Equals(""))
                {
                    MessageBox.Show(" You Must Enter the Author's First and Last Name", "Empty Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (author.editAuthor(id, first_name, last_name, education, bio))
                    {

                        MessageBox.Show("The Author's Data Has Been Updated Succesfully ", "Edit Author", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //clear fields
                        textBox_id.Text = "";
                        textBox_fname.Text = "";
                        textBox_lname.Text = "";
                        textBox_educ.Text = "";
                        richTextBox_bio.Text = "";

                        // refresh datagridview 
                        dataGridView_authors.DataSource = author.AuthorsList(false);
                    }
                    else
                    {
                        MessageBox.Show(" Author's Data Not Updated", "Update-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Author ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // button to add author
        private void button1_Click_1(object sender, EventArgs e)
        {
            string first_name = textBox_fname.Text;
            string last_name = textBox_lname.Text;
            string education = textBox_educ.Text;
            string bio = richTextBox_bio.Text;

            //check if the first/last name are empty
            if (first_name.Trim().Equals("") || last_name.Trim().Equals(""))
            {
                MessageBox.Show(" You Must Enter the Author's First and Last Name", "Empty Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (author.addAuthor(first_name, last_name, education, bio))
                {

                    MessageBox.Show("New Author Added Succesfully ", "New Author", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //clear fields
                    textBox_id.Text = "";
                    textBox_fname.Text = "";
                    textBox_lname.Text = "";
                    textBox_educ.Text = "";
                    richTextBox_bio.Text = "";

                    // refresh datagridview  
                    dataGridView_authors.DataSource = author.AuthorsList(false);

                    // show the number of authors 
                    label_authorCount.Text = author.AuthorsList(false).Rows.Count.ToString() + " Authors";

                }
                else
                {
                    MessageBox.Show(" Author Not Added", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // button to delete author
        private void button_delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);

                //show a confirmation message before deleting the author
                if (MessageBox.Show("Do You Really Want To Delete This Author?", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (author.removeAuthor(id))
                    {
                        MessageBox.Show("The Author's Data Has Been Removed Succesfully ", "Remove Author", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //clear fields
                        textBox_id.Text = "";
                        textBox_fname.Text = "";
                        textBox_lname.Text = "";
                        textBox_educ.Text = "";
                        richTextBox_bio.Text = "";

                        // populate datagridview with genres
                        dataGridView_authors.DataSource = author.AuthorsList(false);

                        // edit the number of authors 
                        label_authorCount.Text = author.AuthorsList(false).Rows.Count.ToString() + " Authors";

                    }
                    else
                    {
                        MessageBox.Show("The Author Has Not Deleted  ", "Remove Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Author ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        // button to export authors from datagridview to a text file
        private void button_export_Click_1(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:\authors"))
            {
                Directory.CreateDirectory(@"C:\authors");
            }


            string filePath = @"C:\authors\list.txt";

            if (!File.Exists(filePath))// check if this exist
            {
                File.Create(filePath).Close();//create the file
                MessageBox.Show("file created");
            }
            // populate the text file with the authors id and fullname
            TextWriter writer = new StreamWriter(filePath);


            string id;
            string fname;
            string lname;
            string fullName;


            for (int i = 0; i < dataGridView_authors.Rows.Count; i++) // for rows
            {
                /*
               for(int j = 0; j < dataGridView_authors.Columns.Count; j++) //for columns
                   {
                       writer.Write(dataGridView_authors.Rows[i].Cells[j].Value.ToString());   
                   }
               */
                id = dataGridView_authors.Rows[i].Cells[0].Value.ToString();
                fname = dataGridView_authors.Rows[i].Cells[1].Value.ToString();
                lname = dataGridView_authors.Rows[i].Cells[2].Value.ToString();
                fullName = fname + " " + lname;

                writer.Write(id + " - " + fullName);

                writer.WriteLine("");//create a new line
                writer.WriteLine("-----------------------------------------");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        // populate the textboxes
        private void dataGridView_authors_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_authors.CurrentRow.Cells[0].Value.ToString();
            textBox_fname.Text = dataGridView_authors.CurrentRow.Cells[1].Value.ToString();
            textBox_lname.Text = dataGridView_authors.CurrentRow.Cells[2].Value.ToString();
            textBox_educ.Text = dataGridView_authors.CurrentRow.Cells[3].Value.ToString();
            richTextBox_bio.Text = dataGridView_authors.CurrentRow.Cells[4].Value.ToString();
        }
    }
}

