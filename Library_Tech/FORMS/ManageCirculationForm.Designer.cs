namespace Library_Tech.FORMS
{
    partial class ManageCirculationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.panel_issue = new System.Windows.Forms.Panel();
            this.button_issueBook = new System.Windows.Forms.Button();
            this.button_searchStudent = new System.Windows.Forms.Button();
            this.button_searchBook = new System.Windows.Forms.Button();
            this.richTextBox_note = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker_returnDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_issueDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_availability = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_StudentFullname = new System.Windows.Forms.Label();
            this.label_bookTItle = new System.Windows.Forms.Label();
            this.numericUpDown_student_id = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_bookID = new System.Windows.Forms.NumericUpDown();
            this.label_quantity = new System.Windows.Forms.Label();
            this.panel_return = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_lost = new System.Windows.Forms.Button();
            this.button_returned = new System.Windows.Forms.Button();
            this.button_issued = new System.Windows.Forms.Button();
            this.dataGridView_issueList = new System.Windows.Forms.DataGridView();
            this.button_bookLost = new System.Windows.Forms.Button();
            this.button_returnBook = new System.Windows.Forms.Button();
            this.button_deleteTransaction = new System.Windows.Forms.Button();
            this.richTextBox_note_2 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker_returnDate_2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_issueDate_2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_student_info = new System.Windows.Forms.Label();
            this.label_book_info = new System.Windows.Forms.Label();
            this.numericUpDown_studentID_2 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown_bookID_2 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_issue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_student_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bookID)).BeginInit();
            this.panel_return.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_issueList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_studentID_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bookID_2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button_return);
            this.panel1.Location = new System.Drawing.Point(2, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 656);
            this.panel1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(11, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 79);
            this.button2.TabIndex = 9;
            this.button2.Text = "Issue";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button_return
            // 
            this.button_return.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_return.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_return.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_return.Location = new System.Drawing.Point(11, 135);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(176, 79);
            this.button_return.TabIndex = 8;
            this.button_return.Text = "Return";
            this.button_return.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_return.UseVisualStyleBackColor = false;
            this.button_return.Click += new System.EventHandler(this.button_return_Click_1);
            // 
            // panel_issue
            // 
            this.panel_issue.BackColor = System.Drawing.SystemColors.Menu;
            this.panel_issue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_issue.Controls.Add(this.button_issueBook);
            this.panel_issue.Controls.Add(this.button_searchStudent);
            this.panel_issue.Controls.Add(this.button_searchBook);
            this.panel_issue.Controls.Add(this.richTextBox_note);
            this.panel_issue.Controls.Add(this.dateTimePicker_returnDate);
            this.panel_issue.Controls.Add(this.dateTimePicker_issueDate);
            this.panel_issue.Controls.Add(this.label8);
            this.panel_issue.Controls.Add(this.label7);
            this.panel_issue.Controls.Add(this.label6);
            this.panel_issue.Controls.Add(this.label_availability);
            this.panel_issue.Controls.Add(this.label4);
            this.panel_issue.Controls.Add(this.label_StudentFullname);
            this.panel_issue.Controls.Add(this.label_bookTItle);
            this.panel_issue.Controls.Add(this.numericUpDown_student_id);
            this.panel_issue.Controls.Add(this.label3);
            this.panel_issue.Controls.Add(this.numericUpDown_bookID);
            this.panel_issue.Controls.Add(this.label_quantity);
            this.panel_issue.Location = new System.Drawing.Point(210, 161);
            this.panel_issue.Name = "panel_issue";
            this.panel_issue.Size = new System.Drawing.Size(1173, 633);
            this.panel_issue.TabIndex = 56;
            // 
            // button_issueBook
            // 
            this.button_issueBook.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_issueBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_issueBook.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_issueBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_issueBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_issueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_issueBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_issueBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_issueBook.Location = new System.Drawing.Point(126, 568);
            this.button_issueBook.Name = "button_issueBook";
            this.button_issueBook.Size = new System.Drawing.Size(933, 58);
            this.button_issueBook.TabIndex = 47;
            this.button_issueBook.Text = "Issue Book";
            this.button_issueBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_issueBook.UseVisualStyleBackColor = false;
            this.button_issueBook.Click += new System.EventHandler(this.button_issueBook_Click_1);
            // 
            // button_searchStudent
            // 
            this.button_searchStudent.Location = new System.Drawing.Point(756, 107);
            this.button_searchStudent.Name = "button_searchStudent";
            this.button_searchStudent.Size = new System.Drawing.Size(126, 35);
            this.button_searchStudent.TabIndex = 46;
            this.button_searchStudent.Text = "Search Student";
            this.button_searchStudent.UseVisualStyleBackColor = true;
            this.button_searchStudent.Click += new System.EventHandler(this.button_searchStudent_Click_1);
            // 
            // button_searchBook
            // 
            this.button_searchBook.Location = new System.Drawing.Point(756, 27);
            this.button_searchBook.Name = "button_searchBook";
            this.button_searchBook.Size = new System.Drawing.Size(126, 35);
            this.button_searchBook.TabIndex = 45;
            this.button_searchBook.Text = "Search Book";
            this.button_searchBook.UseVisualStyleBackColor = true;
            this.button_searchBook.Click += new System.EventHandler(this.button_searchBook_Click_1);
            // 
            // richTextBox_note
            // 
            this.richTextBox_note.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_note.Location = new System.Drawing.Point(340, 377);
            this.richTextBox_note.Name = "richTextBox_note";
            this.richTextBox_note.Size = new System.Drawing.Size(410, 175);
            this.richTextBox_note.TabIndex = 44;
            this.richTextBox_note.Text = "";
            // 
            // dateTimePicker_returnDate
            // 
            this.dateTimePicker_returnDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_returnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_returnDate.Location = new System.Drawing.Point(525, 325);
            this.dateTimePicker_returnDate.Name = "dateTimePicker_returnDate";
            this.dateTimePicker_returnDate.Size = new System.Drawing.Size(225, 34);
            this.dateTimePicker_returnDate.TabIndex = 43;
            // 
            // dateTimePicker_issueDate
            // 
            this.dateTimePicker_issueDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_issueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_issueDate.Location = new System.Drawing.Point(525, 271);
            this.dateTimePicker_issueDate.Name = "dateTimePicker_issueDate";
            this.dateTimePicker_issueDate.Size = new System.Drawing.Size(225, 34);
            this.dateTimePicker_issueDate.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(263, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 29);
            this.label8.TabIndex = 41;
            this.label8.Text = "Note:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(373, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 29);
            this.label7.TabIndex = 40;
            this.label7.Text = "Return Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(387, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 29);
            this.label6.TabIndex = 39;
            this.label6.Text = "Issue Date:";
            // 
            // label_availability
            // 
            this.label_availability.AutoSize = true;
            this.label_availability.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_availability.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_availability.Location = new System.Drawing.Point(525, 207);
            this.label_availability.Name = "label_availability";
            this.label_availability.Size = new System.Drawing.Size(161, 32);
            this.label_availability.TabIndex = 38;
            this.label_availability.Text = "YES or NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(263, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 29);
            this.label4.TabIndex = 37;
            this.label4.Text = "Is This Book Available:";
            // 
            // label_StudentFullname
            // 
            this.label_StudentFullname.AutoSize = true;
            this.label_StudentFullname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_StudentFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_StudentFullname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_StudentFullname.Location = new System.Drawing.Point(525, 144);
            this.label_StudentFullname.Name = "label_StudentFullname";
            this.label_StudentFullname.Size = new System.Drawing.Size(147, 20);
            this.label_StudentFullname.TabIndex = 36;
            this.label_StudentFullname.Text = "Student FullName:";
            this.label_StudentFullname.Click += new System.EventHandler(this.label_StudentFullname_Click_1);
            this.label_StudentFullname.MouseEnter += new System.EventHandler(this.label_StudentFullname_MouseEnter_1);
            this.label_StudentFullname.MouseLeave += new System.EventHandler(this.label_StudentFullname_MouseLeave_1);
            // 
            // label_bookTItle
            // 
            this.label_bookTItle.AutoSize = true;
            this.label_bookTItle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_bookTItle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_bookTItle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_bookTItle.Location = new System.Drawing.Point(525, 64);
            this.label_bookTItle.Name = "label_bookTItle";
            this.label_bookTItle.Size = new System.Drawing.Size(89, 20);
            this.label_bookTItle.TabIndex = 35;
            this.label_bookTItle.Text = "Book Title:";
            this.label_bookTItle.Click += new System.EventHandler(this.label_bookTItle_Click_1);
            this.label_bookTItle.MouseEnter += new System.EventHandler(this.label_bookTItle_MouseEnter_1);
            this.label_bookTItle.MouseLeave += new System.EventHandler(this.label_bookTItle_MouseLeave_1);
            // 
            // numericUpDown_student_id
            // 
            this.numericUpDown_student_id.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_student_id.Location = new System.Drawing.Point(525, 103);
            this.numericUpDown_student_id.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_student_id.Name = "numericUpDown_student_id";
            this.numericUpDown_student_id.Size = new System.Drawing.Size(225, 38);
            this.numericUpDown_student_id.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(277, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Enter The Student ID:";
            // 
            // numericUpDown_bookID
            // 
            this.numericUpDown_bookID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_bookID.Location = new System.Drawing.Point(525, 23);
            this.numericUpDown_bookID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_bookID.Name = "numericUpDown_bookID";
            this.numericUpDown_bookID.Size = new System.Drawing.Size(225, 38);
            this.numericUpDown_bookID.TabIndex = 32;
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_quantity.ForeColor = System.Drawing.Color.Black;
            this.label_quantity.Location = new System.Drawing.Point(303, 27);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(216, 29);
            this.label_quantity.TabIndex = 31;
            this.label_quantity.Text = "Enter The Book ID:";
            // 
            // panel_return
            // 
            this.panel_return.BackColor = System.Drawing.SystemColors.Menu;
            this.panel_return.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_return.Controls.Add(this.button1);
            this.panel_return.Controls.Add(this.button_lost);
            this.panel_return.Controls.Add(this.button_returned);
            this.panel_return.Controls.Add(this.button_issued);
            this.panel_return.Controls.Add(this.dataGridView_issueList);
            this.panel_return.Controls.Add(this.button_bookLost);
            this.panel_return.Controls.Add(this.button_returnBook);
            this.panel_return.Controls.Add(this.button_deleteTransaction);
            this.panel_return.Controls.Add(this.richTextBox_note_2);
            this.panel_return.Controls.Add(this.dateTimePicker_returnDate_2);
            this.panel_return.Controls.Add(this.dateTimePicker_issueDate_2);
            this.panel_return.Controls.Add(this.label1);
            this.panel_return.Controls.Add(this.label5);
            this.panel_return.Controls.Add(this.label9);
            this.panel_return.Controls.Add(this.label_student_info);
            this.panel_return.Controls.Add(this.label_book_info);
            this.panel_return.Controls.Add(this.numericUpDown_studentID_2);
            this.panel_return.Controls.Add(this.label14);
            this.panel_return.Controls.Add(this.numericUpDown_bookID_2);
            this.panel_return.Controls.Add(this.label15);
            this.panel_return.Location = new System.Drawing.Point(210, 161);
            this.panel_return.Name = "panel_return";
            this.panel_return.Size = new System.Drawing.Size(1173, 633);
            this.panel_return.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1082, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 42);
            this.button1.TabIndex = 53;
            this.button1.Text = "All";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button_lost
            // 
            this.button_lost.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_lost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_lost.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_lost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_lost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_lost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_lost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_lost.Location = new System.Drawing.Point(863, 7);
            this.button_lost.Name = "button_lost";
            this.button_lost.Size = new System.Drawing.Size(215, 42);
            this.button_lost.TabIndex = 52;
            this.button_lost.Text = "Lost";
            this.button_lost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_lost.UseVisualStyleBackColor = false;
            this.button_lost.Click += new System.EventHandler(this.button_lost_Click_1);
            // 
            // button_returned
            // 
            this.button_returned.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_returned.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_returned.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_returned.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_returned.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_returned.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_returned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_returned.Location = new System.Drawing.Point(643, 7);
            this.button_returned.Name = "button_returned";
            this.button_returned.Size = new System.Drawing.Size(215, 42);
            this.button_returned.TabIndex = 51;
            this.button_returned.Text = "Returned";
            this.button_returned.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_returned.UseVisualStyleBackColor = false;
            this.button_returned.Click += new System.EventHandler(this.button_returned_Click_1);
            // 
            // button_issued
            // 
            this.button_issued.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_issued.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_issued.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_issued.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_issued.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_issued.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_issued.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_issued.Location = new System.Drawing.Point(424, 7);
            this.button_issued.Name = "button_issued";
            this.button_issued.Size = new System.Drawing.Size(215, 42);
            this.button_issued.TabIndex = 9;
            this.button_issued.Text = "Issued";
            this.button_issued.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_issued.UseVisualStyleBackColor = false;
            this.button_issued.Click += new System.EventHandler(this.button_issued_Click_1);
            // 
            // dataGridView_issueList
            // 
            this.dataGridView_issueList.AllowUserToAddRows = false;
            this.dataGridView_issueList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_issueList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_issueList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_issueList.GridColor = System.Drawing.Color.Black;
            this.dataGridView_issueList.Location = new System.Drawing.Point(424, 51);
            this.dataGridView_issueList.Name = "dataGridView_issueList";
            this.dataGridView_issueList.ReadOnly = true;
            this.dataGridView_issueList.RowHeadersWidth = 51;
            this.dataGridView_issueList.RowTemplate.Height = 29;
            this.dataGridView_issueList.Size = new System.Drawing.Size(724, 436);
            this.dataGridView_issueList.TabIndex = 50;
            this.dataGridView_issueList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_issueList_CellClick_1);
            // 
            // button_bookLost
            // 
            this.button_bookLost.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_bookLost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_bookLost.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_bookLost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_bookLost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_bookLost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_bookLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_bookLost.ForeColor = System.Drawing.Color.Black;
            this.button_bookLost.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_bookLost.Location = new System.Drawing.Point(589, 504);
            this.button_bookLost.Name = "button_bookLost";
            this.button_bookLost.Size = new System.Drawing.Size(561, 58);
            this.button_bookLost.TabIndex = 49;
            this.button_bookLost.Text = "Book Lost";
            this.button_bookLost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_bookLost.UseVisualStyleBackColor = false;
            this.button_bookLost.Click += new System.EventHandler(this.button_bookLost_Click_1);
            // 
            // button_returnBook
            // 
            this.button_returnBook.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_returnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_returnBook.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_returnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_returnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_returnBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_returnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_returnBook.ForeColor = System.Drawing.Color.Black;
            this.button_returnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_returnBook.Location = new System.Drawing.Point(20, 503);
            this.button_returnBook.Name = "button_returnBook";
            this.button_returnBook.Size = new System.Drawing.Size(561, 58);
            this.button_returnBook.TabIndex = 48;
            this.button_returnBook.Text = "Return Book";
            this.button_returnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_returnBook.UseVisualStyleBackColor = false;
            this.button_returnBook.Click += new System.EventHandler(this.button_returnBook_Click_1);
            // 
            // button_deleteTransaction
            // 
            this.button_deleteTransaction.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_deleteTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_deleteTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_deleteTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_deleteTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_deleteTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_deleteTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_deleteTransaction.ForeColor = System.Drawing.Color.Black;
            this.button_deleteTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_deleteTransaction.Location = new System.Drawing.Point(20, 566);
            this.button_deleteTransaction.Name = "button_deleteTransaction";
            this.button_deleteTransaction.Size = new System.Drawing.Size(1129, 58);
            this.button_deleteTransaction.TabIndex = 47;
            this.button_deleteTransaction.Text = "Delete Transaction";
            this.button_deleteTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_deleteTransaction.UseVisualStyleBackColor = false;
            this.button_deleteTransaction.Click += new System.EventHandler(this.button_deleteTransaction_Click_1);
            // 
            // richTextBox_note_2
            // 
            this.richTextBox_note_2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_note_2.Location = new System.Drawing.Point(88, 281);
            this.richTextBox_note_2.Name = "richTextBox_note_2";
            this.richTextBox_note_2.Size = new System.Drawing.Size(299, 175);
            this.richTextBox_note_2.TabIndex = 44;
            this.richTextBox_note_2.Text = "";
            // 
            // dateTimePicker_returnDate_2
            // 
            this.dateTimePicker_returnDate_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_returnDate_2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_returnDate_2.Location = new System.Drawing.Point(162, 225);
            this.dateTimePicker_returnDate_2.Name = "dateTimePicker_returnDate_2";
            this.dateTimePicker_returnDate_2.Size = new System.Drawing.Size(225, 34);
            this.dateTimePicker_returnDate_2.TabIndex = 43;
            // 
            // dateTimePicker_issueDate_2
            // 
            this.dateTimePicker_issueDate_2.Enabled = false;
            this.dateTimePicker_issueDate_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_issueDate_2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_issueDate_2.Location = new System.Drawing.Point(162, 171);
            this.dateTimePicker_issueDate_2.Name = "dateTimePicker_issueDate_2";
            this.dateTimePicker_issueDate_2.Size = new System.Drawing.Size(225, 34);
            this.dateTimePicker_issueDate_2.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "Note:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 29);
            this.label5.TabIndex = 40;
            this.label5.Text = "Return Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(24, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 29);
            this.label9.TabIndex = 39;
            this.label9.Text = "Issue Date:";
            // 
            // label_student_info
            // 
            this.label_student_info.AutoSize = true;
            this.label_student_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_student_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_student_info.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_student_info.Location = new System.Drawing.Point(162, 137);
            this.label_student_info.Name = "label_student_info";
            this.label_student_info.Size = new System.Drawing.Size(147, 20);
            this.label_student_info.TabIndex = 36;
            this.label_student_info.Text = "Student FullName:";
            // 
            // label_book_info
            // 
            this.label_book_info.AutoSize = true;
            this.label_book_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_book_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_book_info.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_book_info.Location = new System.Drawing.Point(162, 57);
            this.label_book_info.Name = "label_book_info";
            this.label_book_info.Size = new System.Drawing.Size(89, 20);
            this.label_book_info.TabIndex = 35;
            this.label_book_info.Text = "Book Title:";
            // 
            // numericUpDown_studentID_2
            // 
            this.numericUpDown_studentID_2.Enabled = false;
            this.numericUpDown_studentID_2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_studentID_2.Location = new System.Drawing.Point(162, 96);
            this.numericUpDown_studentID_2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_studentID_2.Name = "numericUpDown_studentID_2";
            this.numericUpDown_studentID_2.Size = new System.Drawing.Size(225, 38);
            this.numericUpDown_studentID_2.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(6, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 29);
            this.label14.TabIndex = 33;
            this.label14.Text = " Student ID:";
            // 
            // numericUpDown_bookID_2
            // 
            this.numericUpDown_bookID_2.Enabled = false;
            this.numericUpDown_bookID_2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_bookID_2.Location = new System.Drawing.Point(162, 16);
            this.numericUpDown_bookID_2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_bookID_2.Name = "numericUpDown_bookID_2";
            this.numericUpDown_bookID_2.Size = new System.Drawing.Size(225, 38);
            this.numericUpDown_bookID_2.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(32, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 29);
            this.label15.TabIndex = 31;
            this.label15.Text = " Book ID:";
            // 
            // ManageCirculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::Library_Tech.Properties.Resources._5487854;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1388, 802);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_issue);
            this.Controls.Add(this.panel_return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManageCirculationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCirculationForm.cs";
            this.Load += new System.EventHandler(this.ManageCirculationForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel_issue.ResumeLayout(false);
            this.panel_issue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_student_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bookID)).EndInit();
            this.panel_return.ResumeLayout(false);
            this.panel_return.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_issueList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_studentID_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bookID_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button_return;
        private Panel panel_issue;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label_availability;
        private Label label4;
        private Label label_StudentFullname;
        private Label label_bookTItle;
        private NumericUpDown numericUpDown_student_id;
        private Label label3;
        private NumericUpDown numericUpDown_bookID;
        private Label label_quantity;
        private DateTimePicker dateTimePicker_returnDate;
        private DateTimePicker dateTimePicker_issueDate;
        private RichTextBox richTextBox_note;
        private Button button_searchStudent;
        private Button button_searchBook;
        private Button button_issueBook;
        private Panel panel_return;
        private Button button_deleteTransaction;
        private RichTextBox richTextBox_note_2;
        private DateTimePicker dateTimePicker_returnDate_2;
        private DateTimePicker dateTimePicker_issueDate_2;
        private Label label1;
        private Label label5;
        private Label label9;
        private Label label_student_info;
        private Label label_book_info;
        private NumericUpDown numericUpDown_studentID_2;
        private Label label14;
        private NumericUpDown numericUpDown_bookID_2;
        private Label label15;
        private Button button_bookLost;
        private Button button_returnBook;
        private DataGridView dataGridView_issueList;
        private Button button_lost;
        private Button button_returned;
        private Button button_issued;
        private Button button1;
        private Button button2;
    }
}