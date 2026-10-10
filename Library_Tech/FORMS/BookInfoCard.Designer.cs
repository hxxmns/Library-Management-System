namespace Library_Tech.FORMS
{
    partial class BookInfoCard
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
            label_isbn = new Label();
            label_title = new Label();
            label_author = new Label();
            label_genre = new Label();
            label_quantity = new Label();
            label_price = new Label();
            label_publisher = new Label();
            label_dateAdded = new Label();
            richTextBox_description = new RichTextBox();
            pictureBox_Cover = new PictureBox();
            label_qty = new Label();
            label_close = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Cover).BeginInit();
            SuspendLayout();
            // 
            // label_isbn
            // 
            label_isbn.AutoSize = true;
            label_isbn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_isbn.ForeColor = Color.White;
            label_isbn.Location = new Point(415, 35);
            label_isbn.Name = "label_isbn";
            label_isbn.Size = new Size(75, 29);
            label_isbn.TabIndex = 40;
            label_isbn.Text = "ISBN:";
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_title.ForeColor = Color.White;
            label_title.Location = new Point(410, 109);
            label_title.Name = "label_title";
            label_title.Size = new Size(67, 29);
            label_title.TabIndex = 41;
            label_title.Text = "Title:";
            // 
            // label_author
            // 
            label_author.AutoSize = true;
            label_author.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_author.ForeColor = Color.White;
            label_author.Location = new Point(438, 183);
            label_author.Name = "label_author";
            label_author.Size = new Size(88, 29);
            label_author.TabIndex = 42;
            label_author.Text = "Author:";
            // 
            // label_genre
            // 
            label_genre.AutoSize = true;
            label_genre.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_genre.ForeColor = Color.White;
            label_genre.Location = new Point(438, 257);
            label_genre.Name = "label_genre";
            label_genre.Size = new Size(86, 29);
            label_genre.TabIndex = 43;
            label_genre.Text = "Genre:";
            // 
            // label_quantity
            // 
            label_quantity.AutoSize = true;
            label_quantity.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_quantity.ForeColor = Color.White;
            label_quantity.Location = new Point(458, 331);
            label_quantity.Name = "label_quantity";
            label_quantity.Size = new Size(106, 29);
            label_quantity.TabIndex = 44;
            label_quantity.Text = "Quantity:";
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_price.ForeColor = Color.White;
            label_price.Location = new Point(425, 405);
            label_price.Name = "label_price";
            label_price.Size = new Size(75, 29);
            label_price.TabIndex = 45;
            label_price.Text = "Price:";
            // 
            // label_publisher
            // 
            label_publisher.AutoSize = true;
            label_publisher.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_publisher.ForeColor = Color.White;
            label_publisher.Location = new Point(474, 479);
            label_publisher.Name = "label_publisher";
            label_publisher.Size = new Size(121, 29);
            label_publisher.TabIndex = 46;
            label_publisher.Text = "Publisher:";
            // 
            // label_dateAdded
            // 
            label_dateAdded.AutoSize = true;
            label_dateAdded.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_dateAdded.ForeColor = Color.White;
            label_dateAdded.Location = new Point(489, 553);
            label_dateAdded.Name = "label_dateAdded";
            label_dateAdded.Size = new Size(146, 29);
            label_dateAdded.TabIndex = 47;
            label_dateAdded.Text = "Date Added:";
            // 
            // richTextBox_description
            // 
            richTextBox_description.Enabled = false;
            richTextBox_description.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox_description.Location = new Point(21, 485);
            richTextBox_description.Name = "richTextBox_description";
            richTextBox_description.ReadOnly = true;
            richTextBox_description.Size = new Size(301, 143);
            richTextBox_description.TabIndex = 49;
            richTextBox_description.Text = "";
            // 
            // pictureBox_Cover
            // 
            pictureBox_Cover.BackColor = Color.RosyBrown;
            pictureBox_Cover.ErrorImage = null;
            pictureBox_Cover.ImageLocation = "";
            pictureBox_Cover.InitialImage = null;
            pictureBox_Cover.Location = new Point(21, 23);
            pictureBox_Cover.Name = "pictureBox_Cover";
            pictureBox_Cover.Size = new Size(301, 456);
            pictureBox_Cover.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Cover.TabIndex = 50;
            pictureBox_Cover.TabStop = false;
            // 
            // label_qty
            // 
            label_qty.AutoSize = true;
            label_qty.BackColor = Color.Lime;
            label_qty.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_qty.ForeColor = Color.White;
            label_qty.Location = new Point(570, 331);
            label_qty.Name = "label_qty";
            label_qty.Size = new Size(52, 29);
            label_qty.TabIndex = 51;
            label_qty.Text = "100";
            // 
            // label_close
            // 
            label_close.BackColor = Color.Transparent;
            label_close.Cursor = Cursors.Hand;
            label_close.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_close.ForeColor = Color.Black;
            label_close.Location = new Point(738, 2);
            label_close.Name = "label_close";
            label_close.Size = new Size(30, 40);
            label_close.TabIndex = 48;
            label_close.Text = "X";
            label_close.TextAlign = ContentAlignment.MiddleCenter;
            label_close.Click += label_close_Click;
            label_close.MouseEnter += label_close_MouseEnter;
            label_close.MouseLeave += label_close_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(461, 331);
            label1.Name = "label1";
            label1.Size = new Size(0, 29);
            label1.TabIndex = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(349, 553);
            label2.Name = "label2";
            label2.Size = new Size(146, 29);
            label2.TabIndex = 59;
            label2.Text = "Date Added:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(349, 479);
            label3.Name = "label3";
            label3.Size = new Size(121, 29);
            label3.TabIndex = 58;
            label3.Text = "Publisher:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(349, 405);
            label4.Name = "label4";
            label4.Size = new Size(75, 29);
            label4.TabIndex = 57;
            label4.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(349, 331);
            label5.Name = "label5";
            label5.Size = new Size(106, 29);
            label5.TabIndex = 56;
            label5.Text = "Quantity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(349, 257);
            label6.Name = "label6";
            label6.Size = new Size(86, 29);
            label6.TabIndex = 55;
            label6.Text = "Genre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(349, 183);
            label7.Name = "label7";
            label7.Size = new Size(88, 29);
            label7.TabIndex = 54;
            label7.Text = "Author:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(349, 109);
            label8.Name = "label8";
            label8.Size = new Size(67, 29);
            label8.TabIndex = 53;
            label8.Text = "Title:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(349, 35);
            label9.Name = "label9";
            label9.Size = new Size(75, 29);
            label9.TabIndex = 52;
            label9.Text = "ISBN:";
            // 
            // BookInfoCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(771, 639);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label_close);
            Controls.Add(label_qty);
            Controls.Add(pictureBox_Cover);
            Controls.Add(richTextBox_description);
            Controls.Add(label_dateAdded);
            Controls.Add(label_publisher);
            Controls.Add(label_price);
            Controls.Add(label_quantity);
            Controls.Add(label_genre);
            Controls.Add(label_author);
            Controls.Add(label_title);
            Controls.Add(label_isbn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookInfoCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookInfoCard";
            Load += BookInfoCard_Load;
            MouseEnter += BookInfoCard_MouseEnter;
            MouseLeave += BookInfoCard_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Cover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_isbn;
        private Label label_title;
        private Label label_author;
        private Label label_genre;
        private Label label_quantity;
        private Label label_price;
        private Label label_publisher;
        private Label label_dateAdded;
        private RichTextBox richTextBox_description;
        private PictureBox pictureBox_Cover;
        private Label label_qty;
        private Label label_close;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}