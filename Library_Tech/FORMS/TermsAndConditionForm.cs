using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Tech.FORMS
{
    public partial class TermsAndConditionForm : Form
    {
        public TermsAndConditionForm()
        {
            InitializeComponent();
        }

        private void TermsAndConditionForm_Load_1(object sender, EventArgs e)
        {
            label_tc.Visible = false;

            // Set the label's font and text
            label1.Font = new Font(label1.Font.FontFamily, 16);
            label1.TextAlign = ContentAlignment.TopLeft;
            label1.Text = "Borrowing books entails adhering to specific rules and regulations outlined as follows:\r\n" +
                          "a. To borrow a book, you must present a valid ID to the librarian.\r\n" +
                          "b. Books must not be taken outside of the school premises.\r\n" +
                          "c. Failure to return books by the specified deadline results in a first warning,\r\n" +
                          "with subsequent violations leading to a suspension of borrowing privileges.\r\n" +
                          "d. Penalties will be incurred for lost books.";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.Close();

                SignUpForm sgf = new SignUpForm();
                sgf.Show();
            }
            else
            {
                label_tc.Visible = true;
            }
        }
    }
}
