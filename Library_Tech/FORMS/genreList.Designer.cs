namespace Library_Tech.FORMS
{
    partial class genreList
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
            this.dataGridView_genres = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Show_Genre_Books = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_genres)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_genres
            // 
            this.dataGridView_genres.AllowUserToAddRows = false;
            this.dataGridView_genres.AllowUserToDeleteRows = false;
            this.dataGridView_genres.AllowUserToResizeColumns = false;
            this.dataGridView_genres.AllowUserToResizeRows = false;
            this.dataGridView_genres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_genres.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView_genres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_genres.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_genres.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_genres.GridColor = System.Drawing.Color.Black;
            this.dataGridView_genres.Location = new System.Drawing.Point(46, 94);
            this.dataGridView_genres.Name = "dataGridView_genres";
            this.dataGridView_genres.ReadOnly = true;
            this.dataGridView_genres.RowHeadersWidth = 51;
            this.dataGridView_genres.RowTemplate.Height = 29;
            this.dataGridView_genres.Size = new System.Drawing.Size(536, 528);
            this.dataGridView_genres.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_Show_Genre_Books);
            this.panel1.Controls.Add(this.dataGridView_genres);
            this.panel1.Location = new System.Drawing.Point(333, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 737);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(241, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 45);
            this.label3.TabIndex = 82;
            this.label3.Text = "Genre List";
            // 
            // button_Show_Genre_Books
            // 
            this.button_Show_Genre_Books.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_Show_Genre_Books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Show_Genre_Books.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Show_Genre_Books.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Show_Genre_Books.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Show_Genre_Books.ForeColor = System.Drawing.Color.Black;
            this.button_Show_Genre_Books.Location = new System.Drawing.Point(46, 629);
            this.button_Show_Genre_Books.Name = "button_Show_Genre_Books";
            this.button_Show_Genre_Books.Size = new System.Drawing.Size(536, 86);
            this.button_Show_Genre_Books.TabIndex = 12;
            this.button_Show_Genre_Books.Text = "Show Books By Selected Genre";
            this.button_Show_Genre_Books.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Show_Genre_Books.UseVisualStyleBackColor = false;
            this.button_Show_Genre_Books.Click += new System.EventHandler(this.button_Show_Genre_Books_Click);
            // 
            // genreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::Library_Tech.Properties.Resources._5487854;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1275, 849);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "genreList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "genreList";
            this.Load += new System.EventHandler(this.genreList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_genres)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_genres;
        private Panel panel1;
        private Button button_Show_Genre_Books;
        private Label label3;
    }
}