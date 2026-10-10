namespace Library_Tech.FORMS
{
    partial class BooksBySelectedGenre
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
            this.components = new System.ComponentModel.Container();
            this.label_author = new System.Windows.Forms.Label();
            this.listView_booksByGenre = new System.Windows.Forms.ListView();
            this.imageList_bookCovers = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.BackColor = System.Drawing.Color.Transparent;
            this.label_author.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_author.ForeColor = System.Drawing.Color.Black;
            this.label_author.Location = new System.Drawing.Point(19, 49);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(263, 38);
            this.label_author.TabIndex = 6;
            this.label_author.Text = "Books By: the genre";
            // 
            // listView_booksByGenre
            // 
            this.listView_booksByGenre.BackColor = System.Drawing.Color.Gray;
            this.listView_booksByGenre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView_booksByGenre.ForeColor = System.Drawing.Color.White;
            this.listView_booksByGenre.Location = new System.Drawing.Point(19, 101);
            this.listView_booksByGenre.Name = "listView_booksByGenre";
            this.listView_booksByGenre.Size = new System.Drawing.Size(374, 583);
            this.listView_booksByGenre.TabIndex = 5;
            this.listView_booksByGenre.UseCompatibleStateImageBehavior = false;
            // 
            // imageList_bookCovers
            // 
            this.imageList_bookCovers.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_bookCovers.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_bookCovers.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_author);
            this.panel1.Controls.Add(this.listView_booksByGenre);
            this.panel1.Location = new System.Drawing.Point(57, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 725);
            this.panel1.TabIndex = 7;
            // 
            // BooksBySelectedGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::Library_Tech.Properties.Resources._5487854;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(539, 781);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BooksBySelectedGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooksBySelectedGenre";
            this.Load += new System.EventHandler(this.BooksBySelectedGenre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label_author;
        private ListView listView_booksByGenre;
        private ImageList imageList_bookCovers;
        private Panel panel1;
    }
}