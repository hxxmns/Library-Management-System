namespace Library_Tech.FORMS
{
    partial class ManageBooksForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBooksForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button_add = new Button();
            button_exportBooks = new Button();
            button_booklist = new Button();
            label_booksCount = new Label();
            button_delete = new Button();
            button_edit = new Button();
            panel_edit = new Panel();
            button_searchISBN = new Button();
            button_searchID = new Button();
            label8 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            button_editBook = new Button();
            label_editAuthorID = new Label();
            button_editSelectcoverphoto = new Button();
            pictureBox_editCover = new PictureBox();
            label17 = new Label();
            richTextBox_editDescription = new RichTextBox();
            dateTimePicker_editDatercv = new DateTimePicker();
            label18 = new Label();
            label19 = new Label();
            textBox_editPublisher = new TextBox();
            label20 = new Label();
            numericUpDown_editqty = new NumericUpDown();
            comboBox_editGenre = new ComboBox();
            button_editselectauthor = new Button();
            textBox_editPrice = new TextBox();
            label21 = new Label();
            textBox_editAuthor = new TextBox();
            label22 = new Label();
            label23 = new Label();
            textBox_editTitle = new TextBox();
            label24 = new Label();
            textBox_editISBN = new TextBox();
            textBox_editID = new TextBox();
            label25 = new Label();
            label26 = new Label();
            panel_add = new Panel();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button_AddBook = new Button();
            label_author_id = new Label();
            button_SelectCover = new Button();
            pictureBox_Cover = new PictureBox();
            label_description = new Label();
            richTextBox_Description = new RichTextBox();
            dateTimePicker_DateReceived = new DateTimePicker();
            label_datereceived = new Label();
            label_publisher = new Label();
            textBox_Publisher = new TextBox();
            label_price = new Label();
            numericUpDown_qty = new NumericUpDown();
            comboBox_genre = new ComboBox();
            button_selectAuthor = new Button();
            textBox_Price = new TextBox();
            label_quantity = new Label();
            textBox_Author = new TextBox();
            label_author = new Label();
            label_genre = new Label();
            textBox_Title = new TextBox();
            label_title = new Label();
            textBox_isbn = new TextBox();
            textBox_id = new TextBox();
            label_id = new Label();
            label_isbn = new Label();
            panel_booklist = new Panel();
            button2 = new Button();
            button1 = new Button();
            dataGridView_bookList = new DataGridView();
            dataSet1BindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_editCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_editqty).BeginInit();
            panel_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Cover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_qty).BeginInit();
            panel_booklist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_bookList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSet1BindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button_add);
            panel1.Controls.Add(button_exportBooks);
            panel1.Controls.Add(button_booklist);
            panel1.Controls.Add(label_booksCount);
            panel1.Controls.Add(button_delete);
            panel1.Controls.Add(button_edit);
            panel1.Controls.Add(panel_edit);
            panel1.Controls.Add(panel_add);
            panel1.Controls.Add(panel_booklist);
            panel1.Location = new Point(23, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(1484, 778);
            panel1.TabIndex = 11;
            // 
            // button_add
            // 
            button_add.BackColor = SystemColors.ActiveBorder;
            button_add.Cursor = Cursors.Hand;
            button_add.FlatAppearance.BorderColor = Color.Black;
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_add.Location = new Point(9, 73);
            button_add.Name = "button_add";
            button_add.Size = new Size(176, 63);
            button_add.TabIndex = 55;
            button_add.Text = "Add";
            button_add.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click_1;
            // 
            // button_exportBooks
            // 
            button_exportBooks.BackColor = SystemColors.ActiveBorder;
            button_exportBooks.Cursor = Cursors.Hand;
            button_exportBooks.FlatAppearance.BorderColor = Color.Black;
            button_exportBooks.FlatStyle = FlatStyle.Flat;
            button_exportBooks.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_exportBooks.Location = new Point(9, 349);
            button_exportBooks.Name = "button_exportBooks";
            button_exportBooks.Size = new Size(176, 86);
            button_exportBooks.TabIndex = 54;
            button_exportBooks.Text = "Export Books To TXT File";
            button_exportBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_exportBooks.UseVisualStyleBackColor = false;
            button_exportBooks.Click += button_exportBooks_Click_1;
            // 
            // button_booklist
            // 
            button_booklist.BackColor = SystemColors.ActiveBorder;
            button_booklist.Cursor = Cursors.Hand;
            button_booklist.FlatAppearance.BorderColor = Color.Black;
            button_booklist.FlatStyle = FlatStyle.Flat;
            button_booklist.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_booklist.Location = new Point(9, 280);
            button_booklist.Name = "button_booklist";
            button_booklist.Size = new Size(176, 63);
            button_booklist.TabIndex = 53;
            button_booklist.Text = "Book List";
            button_booklist.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_booklist.UseVisualStyleBackColor = false;
            button_booklist.Click += button_booklist_Click;
            // 
            // label_booksCount
            // 
            label_booksCount.BackColor = Color.Transparent;
            label_booksCount.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_booksCount.ForeColor = Color.Black;
            label_booksCount.Location = new Point(3, 742);
            label_booksCount.Name = "label_booksCount";
            label_booksCount.Size = new Size(187, 29);
            label_booksCount.TabIndex = 51;
            label_booksCount.Text = "999999 Books";
            label_booksCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_delete
            // 
            button_delete.BackColor = SystemColors.ActiveBorder;
            button_delete.Cursor = Cursors.Hand;
            button_delete.FlatAppearance.BorderColor = Color.Black;
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_delete.Location = new Point(9, 211);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(176, 63);
            button_delete.TabIndex = 9;
            button_delete.Text = " Delete";
            button_delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click_1;
            // 
            // button_edit
            // 
            button_edit.BackColor = SystemColors.ActiveBorder;
            button_edit.Cursor = Cursors.Hand;
            button_edit.FlatAppearance.BorderColor = Color.Black;
            button_edit.FlatStyle = FlatStyle.Flat;
            button_edit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_edit.Location = new Point(9, 142);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(176, 63);
            button_edit.TabIndex = 8;
            button_edit.Text = "Edit";
            button_edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_edit.UseVisualStyleBackColor = false;
            button_edit.Click += button_edit_Click;
            // 
            // panel_edit
            // 
            panel_edit.BackColor = SystemColors.Menu;
            panel_edit.BorderStyle = BorderStyle.FixedSingle;
            panel_edit.Controls.Add(button_searchISBN);
            panel_edit.Controls.Add(button_searchID);
            panel_edit.Controls.Add(label8);
            panel_edit.Controls.Add(label11);
            panel_edit.Controls.Add(label12);
            panel_edit.Controls.Add(label13);
            panel_edit.Controls.Add(label14);
            panel_edit.Controls.Add(label15);
            panel_edit.Controls.Add(button_editBook);
            panel_edit.Controls.Add(label_editAuthorID);
            panel_edit.Controls.Add(button_editSelectcoverphoto);
            panel_edit.Controls.Add(pictureBox_editCover);
            panel_edit.Controls.Add(label17);
            panel_edit.Controls.Add(richTextBox_editDescription);
            panel_edit.Controls.Add(dateTimePicker_editDatercv);
            panel_edit.Controls.Add(label18);
            panel_edit.Controls.Add(label19);
            panel_edit.Controls.Add(textBox_editPublisher);
            panel_edit.Controls.Add(label20);
            panel_edit.Controls.Add(numericUpDown_editqty);
            panel_edit.Controls.Add(comboBox_editGenre);
            panel_edit.Controls.Add(button_editselectauthor);
            panel_edit.Controls.Add(textBox_editPrice);
            panel_edit.Controls.Add(label21);
            panel_edit.Controls.Add(textBox_editAuthor);
            panel_edit.Controls.Add(label22);
            panel_edit.Controls.Add(label23);
            panel_edit.Controls.Add(textBox_editTitle);
            panel_edit.Controls.Add(label24);
            panel_edit.Controls.Add(textBox_editISBN);
            panel_edit.Controls.Add(textBox_editID);
            panel_edit.Controls.Add(label25);
            panel_edit.Controls.Add(label26);
            panel_edit.Location = new Point(193, 32);
            panel_edit.Name = "panel_edit";
            panel_edit.Size = new Size(1269, 715);
            panel_edit.TabIndex = 52;
            // 
            // button_searchISBN
            // 
            button_searchISBN.Location = new Point(343, 108);
            button_searchISBN.Name = "button_searchISBN";
            button_searchISBN.Size = new Size(219, 35);
            button_searchISBN.TabIndex = 52;
            button_searchISBN.Text = "Search Book By ISBN";
            button_searchISBN.UseVisualStyleBackColor = true;
            button_searchISBN.Click += button_searchISBN_Click_1;
            // 
            // button_searchID
            // 
            button_searchID.Location = new Point(342, 44);
            button_searchID.Name = "button_searchID";
            button_searchID.Size = new Size(219, 35);
            button_searchID.TabIndex = 51;
            button_searchID.Text = "Search Book By ID";
            button_searchID.UseVisualStyleBackColor = true;
            button_searchID.Click += button_searchID_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(539, 429);
            label8.Name = "label8";
            label8.Size = new Size(23, 29);
            label8.TabIndex = 50;
            label8.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(538, 488);
            label11.Name = "label11";
            label11.Size = new Size(23, 29);
            label11.TabIndex = 49;
            label11.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(311, 107);
            label12.Name = "label12";
            label12.Size = new Size(23, 29);
            label12.TabIndex = 45;
            label12.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(539, 172);
            label13.Name = "label13";
            label13.Size = new Size(23, 29);
            label13.TabIndex = 44;
            label13.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(358, 240);
            label14.Name = "label14";
            label14.Size = new Size(23, 29);
            label14.TabIndex = 43;
            label14.Text = "*";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(311, 46);
            label15.Name = "label15";
            label15.Size = new Size(23, 29);
            label15.TabIndex = 42;
            label15.Text = "*";
            // 
            // button_editBook
            // 
            button_editBook.BackColor = SystemColors.ActiveBorder;
            button_editBook.Cursor = Cursors.Hand;
            button_editBook.FlatAppearance.BorderColor = Color.Black;
            button_editBook.FlatAppearance.MouseDownBackColor = Color.White;
            button_editBook.FlatAppearance.MouseOverBackColor = Color.White;
            button_editBook.FlatStyle = FlatStyle.Popup;
            button_editBook.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_editBook.ForeColor = Color.Black;
            button_editBook.ImageAlign = ContentAlignment.MiddleRight;
            button_editBook.Location = new Point(92, 652);
            button_editBook.Name = "button_editBook";
            button_editBook.Size = new Size(1101, 58);
            button_editBook.TabIndex = 15;
            button_editBook.Text = "Edit Book";
            button_editBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_editBook.UseVisualStyleBackColor = false;
            button_editBook.Click += button_editBook_Click_1;
            // 
            // label_editAuthorID
            // 
            label_editAuthorID.AutoSize = true;
            label_editAuthorID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_editAuthorID.ForeColor = Color.Black;
            label_editAuthorID.Location = new Point(395, 240);
            label_editAuthorID.Name = "label_editAuthorID";
            label_editAuthorID.Size = new Size(42, 29);
            label_editAuthorID.TabIndex = 40;
            label_editAuthorID.Text = "ID:";
            // 
            // button_editSelectcoverphoto
            // 
            button_editSelectcoverphoto.BackColor = SystemColors.ActiveBorder;
            button_editSelectcoverphoto.FlatStyle = FlatStyle.Flat;
            button_editSelectcoverphoto.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_editSelectcoverphoto.Image = (Image)resources.GetObject("button_editSelectcoverphoto.Image");
            button_editSelectcoverphoto.Location = new Point(839, 595);
            button_editSelectcoverphoto.Name = "button_editSelectcoverphoto";
            button_editSelectcoverphoto.Size = new Size(256, 42);
            button_editSelectcoverphoto.TabIndex = 39;
            button_editSelectcoverphoto.Text = "Select Cover";
            button_editSelectcoverphoto.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_editSelectcoverphoto.UseVisualStyleBackColor = false;
            button_editSelectcoverphoto.Click += button_editSelectcoverphoto_Click_1;
            // 
            // pictureBox_editCover
            // 
            pictureBox_editCover.BackColor = Color.DimGray;
            pictureBox_editCover.ErrorImage = null;
            pictureBox_editCover.Image = Properties.Resources.vecteezy_old_vintage_book_clipart_design_illustration_9384332;
            pictureBox_editCover.ImageLocation = "";
            pictureBox_editCover.InitialImage = null;
            pictureBox_editCover.Location = new Point(839, 192);
            pictureBox_editCover.Name = "pictureBox_editCover";
            pictureBox_editCover.Size = new Size(256, 396);
            pictureBox_editCover.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_editCover.TabIndex = 38;
            pictureBox_editCover.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(603, 6);
            label17.Name = "label17";
            label17.Size = new Size(141, 29);
            label17.TabIndex = 37;
            label17.Text = "Description:";
            // 
            // richTextBox_editDescription
            // 
            richTextBox_editDescription.Location = new Point(750, 8);
            richTextBox_editDescription.Name = "richTextBox_editDescription";
            richTextBox_editDescription.Size = new Size(450, 167);
            richTextBox_editDescription.TabIndex = 36;
            richTextBox_editDescription.Text = "";
            // 
            // dateTimePicker_editDatercv
            // 
            dateTimePicker_editDatercv.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_editDatercv.Location = new Point(186, 543);
            dateTimePicker_editDatercv.Name = "dateTimePicker_editDatercv";
            dateTimePicker_editDatercv.Size = new Size(379, 38);
            dateTimePicker_editDatercv.TabIndex = 35;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(-1, 552);
            label18.Name = "label18";
            label18.Size = new Size(177, 29);
            label18.TabIndex = 34;
            label18.Text = "Date Received:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(2, 493);
            label19.Name = "label19";
            label19.Size = new Size(121, 29);
            label19.TabIndex = 33;
            label19.Text = "Publisher:";
            // 
            // textBox_editPublisher
            // 
            textBox_editPublisher.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_editPublisher.Location = new Point(127, 484);
            textBox_editPublisher.Name = "textBox_editPublisher";
            textBox_editPublisher.Size = new Size(438, 38);
            textBox_editPublisher.TabIndex = 32;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(46, 434);
            label20.Name = "label20";
            label20.Size = new Size(75, 29);
            label20.TabIndex = 31;
            label20.Text = "Price:";
            // 
            // numericUpDown_editqty
            // 
            numericUpDown_editqty.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_editqty.Location = new Point(127, 366);
            numericUpDown_editqty.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown_editqty.Name = "numericUpDown_editqty";
            numericUpDown_editqty.Size = new Size(126, 38);
            numericUpDown_editqty.TabIndex = 30;
            // 
            // comboBox_editGenre
            // 
            comboBox_editGenre.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_editGenre.FormattingEnabled = true;
            comboBox_editGenre.Location = new Point(127, 302);
            comboBox_editGenre.Name = "comboBox_editGenre";
            comboBox_editGenre.Size = new Size(438, 39);
            comboBox_editGenre.TabIndex = 29;
            // 
            // button_editselectauthor
            // 
            button_editselectauthor.Location = new Point(439, 236);
            button_editselectauthor.Name = "button_editselectauthor";
            button_editselectauthor.Size = new Size(126, 35);
            button_editselectauthor.TabIndex = 28;
            button_editselectauthor.Text = "Select Author";
            button_editselectauthor.UseVisualStyleBackColor = true;
            button_editselectauthor.Click += button_editselectauthor_Click_1;
            // 
            // textBox_editPrice
            // 
            textBox_editPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_editPrice.Location = new Point(127, 425);
            textBox_editPrice.Name = "textBox_editPrice";
            textBox_editPrice.Size = new Size(438, 38);
            textBox_editPrice.TabIndex = 27;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(15, 375);
            label21.Name = "label21";
            label21.Size = new Size(106, 29);
            label21.TabIndex = 26;
            label21.Text = "Quantity:";
            // 
            // textBox_editAuthor
            // 
            textBox_editAuthor.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_editAuthor.Location = new Point(127, 237);
            textBox_editAuthor.Name = "textBox_editAuthor";
            textBox_editAuthor.Size = new Size(257, 34);
            textBox_editAuthor.TabIndex = 24;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(37, 236);
            label22.Name = "label22";
            label22.Size = new Size(88, 29);
            label22.TabIndex = 22;
            label22.Text = "Author:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(39, 307);
            label23.Name = "label23";
            label23.Size = new Size(86, 29);
            label23.TabIndex = 23;
            label23.Text = "Genre:";
            // 
            // textBox_editTitle
            // 
            textBox_editTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_editTitle.Location = new Point(127, 168);
            textBox_editTitle.Name = "textBox_editTitle";
            textBox_editTitle.Size = new Size(438, 38);
            textBox_editTitle.TabIndex = 21;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(57, 173);
            label24.Name = "label24";
            label24.Size = new Size(67, 29);
            label24.TabIndex = 20;
            label24.Text = "Title:";
            // 
            // textBox_editISBN
            // 
            textBox_editISBN.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_editISBN.Location = new Point(127, 103);
            textBox_editISBN.Name = "textBox_editISBN";
            textBox_editISBN.Size = new Size(210, 38);
            textBox_editISBN.TabIndex = 19;
            // 
            // textBox_editID
            // 
            textBox_editID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_editID.Location = new Point(127, 44);
            textBox_editID.Name = "textBox_editID";
            textBox_editID.Size = new Size(210, 34);
            textBox_editID.TabIndex = 18;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(83, 49);
            label25.Name = "label25";
            label25.Size = new Size(42, 29);
            label25.TabIndex = 16;
            label25.Text = "ID:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label26.ForeColor = Color.Black;
            label26.Location = new Point(50, 108);
            label26.Name = "label26";
            label26.Size = new Size(75, 29);
            label26.TabIndex = 17;
            label26.Text = "ISBN:";
            // 
            // panel_add
            // 
            panel_add.BackColor = SystemColors.Menu;
            panel_add.BorderStyle = BorderStyle.FixedSingle;
            panel_add.Controls.Add(label10);
            panel_add.Controls.Add(label9);
            panel_add.Controls.Add(label5);
            panel_add.Controls.Add(label4);
            panel_add.Controls.Add(label3);
            panel_add.Controls.Add(label2);
            panel_add.Controls.Add(button_AddBook);
            panel_add.Controls.Add(label_author_id);
            panel_add.Controls.Add(button_SelectCover);
            panel_add.Controls.Add(pictureBox_Cover);
            panel_add.Controls.Add(label_description);
            panel_add.Controls.Add(richTextBox_Description);
            panel_add.Controls.Add(dateTimePicker_DateReceived);
            panel_add.Controls.Add(label_datereceived);
            panel_add.Controls.Add(label_publisher);
            panel_add.Controls.Add(textBox_Publisher);
            panel_add.Controls.Add(label_price);
            panel_add.Controls.Add(numericUpDown_qty);
            panel_add.Controls.Add(comboBox_genre);
            panel_add.Controls.Add(button_selectAuthor);
            panel_add.Controls.Add(textBox_Price);
            panel_add.Controls.Add(label_quantity);
            panel_add.Controls.Add(textBox_Author);
            panel_add.Controls.Add(label_author);
            panel_add.Controls.Add(label_genre);
            panel_add.Controls.Add(textBox_Title);
            panel_add.Controls.Add(label_title);
            panel_add.Controls.Add(textBox_isbn);
            panel_add.Controls.Add(textBox_id);
            panel_add.Controls.Add(label_id);
            panel_add.Controls.Add(label_isbn);
            panel_add.Location = new Point(193, 32);
            panel_add.Name = "panel_add";
            panel_add.Size = new Size(1269, 715);
            panel_add.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(577, 424);
            label10.Name = "label10";
            label10.Size = new Size(23, 29);
            label10.TabIndex = 50;
            label10.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(577, 483);
            label9.Name = "label9";
            label9.Size = new Size(23, 29);
            label9.TabIndex = 49;
            label9.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(577, 102);
            label5.Name = "label5";
            label5.Size = new Size(23, 29);
            label5.TabIndex = 45;
            label5.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(577, 167);
            label4.Name = "label4";
            label4.Size = new Size(23, 29);
            label4.TabIndex = 44;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(398, 234);
            label3.Name = "label3";
            label3.Size = new Size(23, 29);
            label3.TabIndex = 43;
            label3.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(303, 37);
            label2.Name = "label2";
            label2.Size = new Size(23, 29);
            label2.TabIndex = 42;
            label2.Text = "*";
            // 
            // button_AddBook
            // 
            button_AddBook.BackColor = SystemColors.ActiveBorder;
            button_AddBook.Cursor = Cursors.Hand;
            button_AddBook.FlatAppearance.BorderColor = Color.Black;
            button_AddBook.FlatAppearance.MouseDownBackColor = Color.White;
            button_AddBook.FlatAppearance.MouseOverBackColor = Color.White;
            button_AddBook.FlatStyle = FlatStyle.Popup;
            button_AddBook.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_AddBook.ImageAlign = ContentAlignment.MiddleRight;
            button_AddBook.Location = new Point(92, 652);
            button_AddBook.Name = "button_AddBook";
            button_AddBook.Size = new Size(513, 58);
            button_AddBook.TabIndex = 15;
            button_AddBook.Text = " Add Book";
            button_AddBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_AddBook.UseVisualStyleBackColor = false;
            button_AddBook.Click += button_AddBook_Click_1;
            // 
            // label_author_id
            // 
            label_author_id.AutoSize = true;
            label_author_id.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_author_id.ForeColor = Color.Black;
            label_author_id.Location = new Point(435, 235);
            label_author_id.Name = "label_author_id";
            label_author_id.Size = new Size(42, 29);
            label_author_id.TabIndex = 40;
            label_author_id.Text = "ID:";
            // 
            // button_SelectCover
            // 
            button_SelectCover.BackColor = SystemColors.ActiveBorder;
            button_SelectCover.FlatStyle = FlatStyle.Flat;
            button_SelectCover.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_SelectCover.Image = (Image)resources.GetObject("button_SelectCover.Image");
            button_SelectCover.Location = new Point(839, 595);
            button_SelectCover.Name = "button_SelectCover";
            button_SelectCover.Size = new Size(256, 42);
            button_SelectCover.TabIndex = 39;
            button_SelectCover.Text = "Select Cover";
            button_SelectCover.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_SelectCover.UseVisualStyleBackColor = false;
            button_SelectCover.Click += button_SelectCover_Click_1;
            // 
            // pictureBox_Cover
            // 
            pictureBox_Cover.BackColor = Color.DimGray;
            pictureBox_Cover.ErrorImage = null;
            pictureBox_Cover.Image = (Image)resources.GetObject("pictureBox_Cover.Image");
            pictureBox_Cover.ImageLocation = "";
            pictureBox_Cover.InitialImage = null;
            pictureBox_Cover.Location = new Point(839, 192);
            pictureBox_Cover.Name = "pictureBox_Cover";
            pictureBox_Cover.Size = new Size(256, 396);
            pictureBox_Cover.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Cover.TabIndex = 38;
            pictureBox_Cover.TabStop = false;
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_description.ForeColor = Color.Black;
            label_description.Location = new Point(603, 6);
            label_description.Name = "label_description";
            label_description.Size = new Size(141, 29);
            label_description.TabIndex = 37;
            label_description.Text = "Description:";
            // 
            // richTextBox_Description
            // 
            richTextBox_Description.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox_Description.Location = new Point(750, 8);
            richTextBox_Description.Name = "richTextBox_Description";
            richTextBox_Description.Size = new Size(450, 167);
            richTextBox_Description.TabIndex = 36;
            richTextBox_Description.Text = "";
            // 
            // dateTimePicker_DateReceived
            // 
            dateTimePicker_DateReceived.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_DateReceived.Location = new Point(226, 538);
            dateTimePicker_DateReceived.Name = "dateTimePicker_DateReceived";
            dateTimePicker_DateReceived.Size = new Size(379, 38);
            dateTimePicker_DateReceived.TabIndex = 35;
            // 
            // label_datereceived
            // 
            label_datereceived.AutoSize = true;
            label_datereceived.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_datereceived.ForeColor = Color.Black;
            label_datereceived.Location = new Point(43, 538);
            label_datereceived.Name = "label_datereceived";
            label_datereceived.Size = new Size(177, 29);
            label_datereceived.TabIndex = 34;
            label_datereceived.Text = "Date Received:";
            // 
            // label_publisher
            // 
            label_publisher.AutoSize = true;
            label_publisher.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_publisher.ForeColor = Color.Black;
            label_publisher.Location = new Point(42, 488);
            label_publisher.Name = "label_publisher";
            label_publisher.Size = new Size(121, 29);
            label_publisher.TabIndex = 33;
            label_publisher.Text = "Publisher:";
            // 
            // textBox_Publisher
            // 
            textBox_Publisher.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Publisher.Location = new Point(167, 479);
            textBox_Publisher.Name = "textBox_Publisher";
            textBox_Publisher.Size = new Size(438, 38);
            textBox_Publisher.TabIndex = 32;
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_price.ForeColor = Color.Black;
            label_price.Location = new Point(86, 429);
            label_price.Name = "label_price";
            label_price.Size = new Size(75, 29);
            label_price.TabIndex = 31;
            label_price.Text = "Price:";
            // 
            // numericUpDown_qty
            // 
            numericUpDown_qty.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_qty.Location = new Point(167, 361);
            numericUpDown_qty.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown_qty.Name = "numericUpDown_qty";
            numericUpDown_qty.Size = new Size(126, 38);
            numericUpDown_qty.TabIndex = 30;
            // 
            // comboBox_genre
            // 
            comboBox_genre.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_genre.FormattingEnabled = true;
            comboBox_genre.Location = new Point(167, 297);
            comboBox_genre.Name = "comboBox_genre";
            comboBox_genre.Size = new Size(438, 39);
            comboBox_genre.TabIndex = 29;
            // 
            // button_selectAuthor
            // 
            button_selectAuthor.Location = new Point(479, 231);
            button_selectAuthor.Name = "button_selectAuthor";
            button_selectAuthor.Size = new Size(126, 35);
            button_selectAuthor.TabIndex = 28;
            button_selectAuthor.Text = "Select Author";
            button_selectAuthor.UseVisualStyleBackColor = true;
            button_selectAuthor.Click += button_selectAuthor_Click_1;
            // 
            // textBox_Price
            // 
            textBox_Price.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Price.Location = new Point(167, 420);
            textBox_Price.Name = "textBox_Price";
            textBox_Price.Size = new Size(438, 38);
            textBox_Price.TabIndex = 27;
            // 
            // label_quantity
            // 
            label_quantity.AutoSize = true;
            label_quantity.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_quantity.ForeColor = Color.Black;
            label_quantity.Location = new Point(55, 370);
            label_quantity.Name = "label_quantity";
            label_quantity.Size = new Size(106, 29);
            label_quantity.TabIndex = 26;
            label_quantity.Text = "Quantity:";
            // 
            // textBox_Author
            // 
            textBox_Author.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Author.Location = new Point(167, 232);
            textBox_Author.Name = "textBox_Author";
            textBox_Author.Size = new Size(257, 34);
            textBox_Author.TabIndex = 24;
            // 
            // label_author
            // 
            label_author.AutoSize = true;
            label_author.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_author.ForeColor = Color.Black;
            label_author.Location = new Point(77, 231);
            label_author.Name = "label_author";
            label_author.Size = new Size(88, 29);
            label_author.TabIndex = 22;
            label_author.Text = "Author:";
            // 
            // label_genre
            // 
            label_genre.AutoSize = true;
            label_genre.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_genre.ForeColor = Color.Black;
            label_genre.Location = new Point(79, 302);
            label_genre.Name = "label_genre";
            label_genre.Size = new Size(86, 29);
            label_genre.TabIndex = 23;
            label_genre.Text = "Genre:";
            // 
            // textBox_Title
            // 
            textBox_Title.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Title.Location = new Point(167, 163);
            textBox_Title.Name = "textBox_Title";
            textBox_Title.Size = new Size(438, 38);
            textBox_Title.TabIndex = 21;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_title.ForeColor = Color.Black;
            label_title.Location = new Point(97, 168);
            label_title.Name = "label_title";
            label_title.Size = new Size(67, 29);
            label_title.TabIndex = 20;
            label_title.Text = "Title:";
            // 
            // textBox_isbn
            // 
            textBox_isbn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_isbn.Location = new Point(167, 98);
            textBox_isbn.Name = "textBox_isbn";
            textBox_isbn.Size = new Size(438, 38);
            textBox_isbn.TabIndex = 19;
            // 
            // textBox_id
            // 
            textBox_id.Enabled = false;
            textBox_id.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_id.Location = new Point(167, 36);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(161, 34);
            textBox_id.TabIndex = 18;
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_id.ForeColor = Color.Black;
            label_id.Location = new Point(123, 44);
            label_id.Name = "label_id";
            label_id.Size = new Size(42, 29);
            label_id.TabIndex = 16;
            label_id.Text = "ID:";
            // 
            // label_isbn
            // 
            label_isbn.AutoSize = true;
            label_isbn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_isbn.ForeColor = Color.Black;
            label_isbn.Location = new Point(90, 103);
            label_isbn.Name = "label_isbn";
            label_isbn.Size = new Size(75, 29);
            label_isbn.TabIndex = 17;
            label_isbn.Text = "ISBN:";
            // 
            // panel_booklist
            // 
            panel_booklist.BackColor = SystemColors.Menu;
            panel_booklist.BorderStyle = BorderStyle.FixedSingle;
            panel_booklist.Controls.Add(button2);
            panel_booklist.Controls.Add(button1);
            panel_booklist.Controls.Add(dataGridView_bookList);
            panel_booklist.Location = new Point(193, 32);
            panel_booklist.Name = "panel_booklist";
            panel_booklist.Size = new Size(1269, 715);
            panel_booklist.TabIndex = 53;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(692, 650);
            button2.Name = "button2";
            button2.Size = new Size(508, 58);
            button2.TabIndex = 57;
            button2.Text = "Delete This Book";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(86, 650);
            button1.Name = "button1";
            button1.Size = new Size(508, 58);
            button1.TabIndex = 56;
            button1.Text = "Edit This Book";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // dataGridView_bookList
            // 
            dataGridView_bookList.AllowUserToAddRows = false;
            dataGridView_bookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_bookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView_bookList.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_bookList.GridColor = Color.Black;
            dataGridView_bookList.Location = new Point(7, 21);
            dataGridView_bookList.Name = "dataGridView_bookList";
            dataGridView_bookList.ReadOnly = true;
            dataGridView_bookList.RowHeadersWidth = 51;
            dataGridView_bookList.RowTemplate.Height = 29;
            dataGridView_bookList.Size = new Size(1255, 623);
            dataGridView_bookList.TabIndex = 55;
            // 
            // dataSet1BindingSource
            // 
            dataSet1BindingSource.DataSource = typeof(DataSet1);
            dataSet1BindingSource.Position = 0;
            // 
            // ManageBooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._5487854;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1538, 884);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ManageBooksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageBooksForm";
            Load += ManageBooksForm_Load_1;
            panel1.ResumeLayout(false);
            panel_edit.ResumeLayout(false);
            panel_edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_editCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_editqty).EndInit();
            panel_add.ResumeLayout(false);
            panel_add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Cover).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_qty).EndInit();
            panel_booklist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_bookList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSet1BindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_delete;
        private Button button_edit;
        private Panel panel_add;
        private NumericUpDown numericUpDown_qty;
        private ComboBox comboBox_genre;
        private Button button_selectAuthor;
        private TextBox textBox_Price;
        private Label label_quantity;
        private Label label_author;
        private Label label_genre;
        private TextBox textBox_Title;
        private Label label_title;
        private TextBox textBox_isbn;
        private TextBox textBox_id;
        private Label label_id;
        private Label label_isbn;
        private Label label_price;
        private Label label_description;
        private RichTextBox richTextBox_Description;
        private DateTimePicker dateTimePicker_DateReceived;
        private Label label_datereceived;
        private Label label_publisher;
        private TextBox textBox_Publisher;
        private PictureBox pictureBox_Cover;
        private Button button_SelectCover;
        private Button button_AddBook;
        public TextBox textBox_Author;
        public Label label_author_id;
        private Label label10;
        private Label label9;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label_booksCount;
        private Panel panel_edit;
        private Label label8;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button button_editBook;
        public Label label_editAuthorID;
        private Button button_editSelectcoverphoto;
        private PictureBox pictureBox_editCover;
        private Label label17;
        private RichTextBox richTextBox_editDescription;
        private DateTimePicker dateTimePicker_editDatercv;
        private Label label18;
        private Label label19;
        private TextBox textBox_editPublisher;
        private Label label20;
        private NumericUpDown numericUpDown_editqty;
        private ComboBox comboBox_editGenre;
        private Button button_editselectauthor;
        private TextBox textBox_editPrice;
        private Label label21;
        public TextBox textBox_editAuthor;
        private Label label22;
        private Label label23;
        private TextBox textBox_editTitle;
        private Label label24;
        private TextBox textBox_editISBN;
        private TextBox textBox_editID;
        private Label label25;
        private Label label26;
        private Button button_searchISBN;
        private Button button_searchID;
        private Button button_booklist;
        private Panel panel_booklist;
        private BindingSource dataSet1BindingSource;
        private DataGridView dataGridView_bookList;
        private Button button_exportBooks;
        private Button button_add;
        private Button button1;
        private Button button2;
    }
}