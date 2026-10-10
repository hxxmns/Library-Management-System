namespace Library_Tech.FORMS
{
    partial class StudentInfoCard
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
            pictureBox_profile = new PictureBox();
            label_close = new Label();
            label_email = new Label();
            label_phone = new Label();
            label_gender = new Label();
            label_FullName = new Label();
            label_ID = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_profile).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_profile
            // 
            pictureBox_profile.BackColor = Color.RosyBrown;
            pictureBox_profile.ErrorImage = null;
            pictureBox_profile.ImageLocation = "";
            pictureBox_profile.InitialImage = null;
            pictureBox_profile.Location = new Point(12, 20);
            pictureBox_profile.Name = "pictureBox_profile";
            pictureBox_profile.Size = new Size(255, 282);
            pictureBox_profile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_profile.TabIndex = 61;
            pictureBox_profile.TabStop = false;
            // 
            // label_close
            // 
            label_close.BackColor = Color.Transparent;
            label_close.Cursor = Cursors.Hand;
            label_close.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_close.ForeColor = Color.Black;
            label_close.Location = new Point(689, -2);
            label_close.Name = "label_close";
            label_close.Size = new Size(30, 40);
            label_close.TabIndex = 59;
            label_close.Text = "X";
            label_close.TextAlign = ContentAlignment.MiddleCenter;
            label_close.Click += label_close_Click;
            label_close.MouseEnter += label_close_MouseEnter;
            label_close.MouseLeave += label_close_MouseLeave;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_email.ForeColor = Color.White;
            label_email.Location = new Point(447, 269);
            label_email.Name = "label_email";
            label_email.Size = new Size(175, 29);
            label_email.TabIndex = 55;
            label_email.Text = "Email Address:";
            // 
            // label_phone
            // 
            label_phone.AutoSize = true;
            label_phone.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_phone.ForeColor = Color.White;
            label_phone.Location = new Point(450, 208);
            label_phone.Name = "label_phone";
            label_phone.Size = new Size(182, 29);
            label_phone.TabIndex = 54;
            label_phone.Text = "Phone Number:";
            // 
            // label_gender
            // 
            label_gender.AutoSize = true;
            label_gender.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_gender.ForeColor = Color.White;
            label_gender.Location = new Point(377, 147);
            label_gender.Name = "label_gender";
            label_gender.Size = new Size(100, 29);
            label_gender.TabIndex = 53;
            label_gender.Text = "Gender:";
            // 
            // label_FullName
            // 
            label_FullName.AutoSize = true;
            label_FullName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_FullName.ForeColor = Color.White;
            label_FullName.Location = new Point(399, 86);
            label_FullName.Name = "label_FullName";
            label_FullName.Size = new Size(130, 29);
            label_FullName.TabIndex = 52;
            label_FullName.Text = "Full Name:";
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_ID.ForeColor = Color.White;
            label_ID.Location = new Point(311, 25);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(42, 29);
            label_ID.TabIndex = 51;
            label_ID.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(273, 269);
            label1.Name = "label1";
            label1.Size = new Size(175, 29);
            label1.TabIndex = 66;
            label1.Text = "Email Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(273, 208);
            label2.Name = "label2";
            label2.Size = new Size(182, 29);
            label2.TabIndex = 65;
            label2.Text = "Phone Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(273, 147);
            label3.Name = "label3";
            label3.Size = new Size(100, 29);
            label3.TabIndex = 64;
            label3.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(273, 86);
            label4.Name = "label4";
            label4.Size = new Size(130, 29);
            label4.TabIndex = 63;
            label4.Text = "Full Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(273, 25);
            label5.Name = "label5";
            label5.Size = new Size(42, 29);
            label5.TabIndex = 62;
            label5.Text = "ID:";
            // 
            // StudentInfoCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(718, 323);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(pictureBox_profile);
            Controls.Add(label_close);
            Controls.Add(label_email);
            Controls.Add(label_phone);
            Controls.Add(label_gender);
            Controls.Add(label_FullName);
            Controls.Add(label_ID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentInfoCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentInfoCard";
            Load += StudentInfoCard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_profile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_profile;
        private Label label_close;
        private Label label_email;
        private Label label_phone;
        private Label label_gender;
        private Label label_FullName;
        private Label label_ID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}