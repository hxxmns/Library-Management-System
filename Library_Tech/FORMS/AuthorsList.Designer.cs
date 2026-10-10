namespace Library_Tech.FORMS
{
    partial class AuthorsList
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
            this.dataGridView_authors = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Show_Author_Books = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_authors)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_authors
            // 
            this.dataGridView_authors.AllowUserToAddRows = false;
            this.dataGridView_authors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_authors.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView_authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_authors.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_authors.GridColor = System.Drawing.Color.Black;
            this.dataGridView_authors.Location = new System.Drawing.Point(39, 82);
            this.dataGridView_authors.Name = "dataGridView_authors";
            this.dataGridView_authors.ReadOnly = true;
            this.dataGridView_authors.RowHeadersWidth = 51;
            this.dataGridView_authors.RowTemplate.Height = 29;
            this.dataGridView_authors.Size = new System.Drawing.Size(995, 477);
            this.dataGridView_authors.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_Show_Author_Books);
            this.panel1.Controls.Add(this.dataGridView_authors);
            this.panel1.Location = new System.Drawing.Point(101, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 687);
            this.panel1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(454, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 45);
            this.label3.TabIndex = 81;
            this.label3.Text = "Author List";
            // 
            // button_Show_Author_Books
            // 
            this.button_Show_Author_Books.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_Show_Author_Books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Show_Author_Books.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Show_Author_Books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Show_Author_Books.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Show_Author_Books.Location = new System.Drawing.Point(39, 565);
            this.button_Show_Author_Books.Name = "button_Show_Author_Books";
            this.button_Show_Author_Books.Size = new System.Drawing.Size(995, 86);
            this.button_Show_Author_Books.TabIndex = 23;
            this.button_Show_Author_Books.Text = "Show Books By Selected Author";
            this.button_Show_Author_Books.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Show_Author_Books.UseVisualStyleBackColor = false;
            this.button_Show_Author_Books.Click += new System.EventHandler(this.button_Show_Author_Books_Click);
            // 
            // AuthorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::Library_Tech.Properties.Resources._5487854;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1257, 872);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AuthorsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorsList";
            this.Load += new System.EventHandler(this.AuthorsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_authors)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_authors;
        private Panel panel1;
        private Button button_Show_Author_Books;
        private Label label3;
    }
}