namespace Library_Tech.FORMS
{
    partial class AuthorsListForm
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
            this.listBox_authors = new System.Windows.Forms.ListBox();
            this.button_selectAndClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_authors
            // 
            this.listBox_authors.BackColor = System.Drawing.Color.White;
            this.listBox_authors.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_authors.FormattingEnabled = true;
            this.listBox_authors.ItemHeight = 31;
            this.listBox_authors.Location = new System.Drawing.Point(60, 147);
            this.listBox_authors.Name = "listBox_authors";
            this.listBox_authors.Size = new System.Drawing.Size(569, 500);
            this.listBox_authors.TabIndex = 16;
            // 
            // button_selectAndClose
            // 
            this.button_selectAndClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_selectAndClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selectAndClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_selectAndClose.Location = new System.Drawing.Point(57, 651);
            this.button_selectAndClose.Name = "button_selectAndClose";
            this.button_selectAndClose.Size = new System.Drawing.Size(574, 61);
            this.button_selectAndClose.TabIndex = 29;
            this.button_selectAndClose.Text = "Select And Close";
            this.button_selectAndClose.UseVisualStyleBackColor = false;
            this.button_selectAndClose.Click += new System.EventHandler(this.button_selectAndClose_Click);
            // 
            // AuthorsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::Library_Tech.Properties.Resources._5487854;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 828);
            this.Controls.Add(this.button_selectAndClose);
            this.Controls.Add(this.listBox_authors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AuthorsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorsListForm";
            this.Load += new System.EventHandler(this.AuthorsListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox listBox_authors;
        private Button button_selectAndClose;
    }
}