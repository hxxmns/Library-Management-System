namespace Library_Tech.FORMS
{
    partial class RemoveBookForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_close = new System.Windows.Forms.Label();
            this.textBox_deletebook = new System.Windows.Forms.TextBox();
            this.button_RemoveBook = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "REMOVE BOOK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_close);
            this.panel1.Controls.Add(this.textBox_deletebook);
            this.panel1.Controls.Add(this.button_RemoveBook);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 311);
            this.panel1.TabIndex = 2;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.RoyalBlue;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_close.ForeColor = System.Drawing.Color.Black;
            this.label_close.Location = new System.Drawing.Point(692, -1);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(17, 30);
            this.label_close.TabIndex = 3;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // textBox_deletebook
            // 
            this.textBox_deletebook.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_deletebook.Location = new System.Drawing.Point(312, 130);
            this.textBox_deletebook.Name = "textBox_deletebook";
            this.textBox_deletebook.Size = new System.Drawing.Size(297, 41);
            this.textBox_deletebook.TabIndex = 56;
            // 
            // button_RemoveBook
            // 
            this.button_RemoveBook.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_RemoveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RemoveBook.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_RemoveBook.ForeColor = System.Drawing.Color.White;
            this.button_RemoveBook.Location = new System.Drawing.Point(95, 212);
            this.button_RemoveBook.Name = "button_RemoveBook";
            this.button_RemoveBook.Size = new System.Drawing.Size(514, 56);
            this.button_RemoveBook.TabIndex = 54;
            this.button_RemoveBook.Text = "Remove This Book";
            this.button_RemoveBook.UseVisualStyleBackColor = false;
            this.button_RemoveBook.Click += new System.EventHandler(this.button_RemoveBook_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(90, 138);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(216, 29);
            this.label25.TabIndex = 52;
            this.label25.Text = "Enter The Book ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 311);
            this.panel2.TabIndex = 4;
            // 
            // RemoveBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(719, 311);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveBookForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label_close;
        private Button button_RemoveBook;
        private Label label25;
        private TextBox textBox_deletebook;
        private Panel panel2;
    }
}