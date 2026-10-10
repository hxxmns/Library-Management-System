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
    public partial class AuthorsListForm : Form
    {

        private ManageBooksForm mngBooks = null;
        public AuthorsListForm(ManageBooksForm sourceForm)
        {

            mngBooks = sourceForm as ManageBooksForm;
            InitializeComponent();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // display authors list on the listbox
        private void AuthorsListForm_Load(object sender, EventArgs e)
        {
            CLASSES.AUTHOR author = new CLASSES.AUTHOR();

            listBox_authors.DataSource = author.AuthorsList(true);
            listBox_authors.DisplayMember = "fullName";
            listBox_authors.ValueMember = "id";
        }


        // button to set the selected author id into the manage books form
        // and close this form
        private void button_selectAndClose_Click(object sender, EventArgs e)
        {
            try
            {
                //get the author fullname and id

                DataRowView drv = (DataRowView)listBox_authors.SelectedItem;
                string fullname = drv["fullname"].ToString();
                string id = drv["id"].ToString();

                // display the id and the fullname
              // for add 
                mngBooks.textBox_Author.Text = fullname;
                mngBooks.label_author_id.Text = id;

                // for edit
                mngBooks.textBox_editAuthor.Text = fullname;
                mngBooks.label_editAuthorID.Text = id;

            }
            catch(Exception ex)
            {
                MessageBox.Show("No Author Selected" + ex.Message);
            }


            //close
            this.Close();
        }
    }
}
