namespace Library_Tech.FORMS
{
    partial class BooklistForm
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
            this.panel_booklist = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_bookList = new System.Windows.Forms.DataGridView();
            this.panel_booklist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bookList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_booklist
            // 
            this.panel_booklist.BackColor = System.Drawing.SystemColors.Menu;
            this.panel_booklist.Controls.Add(this.label3);
            this.panel_booklist.Controls.Add(this.dataGridView_bookList);
            this.panel_booklist.Location = new System.Drawing.Point(51, 62);
            this.panel_booklist.Name = "panel_booklist";
            this.panel_booklist.Size = new System.Drawing.Size(1302, 736);
            this.panel_booklist.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(576, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 54);
            this.label3.TabIndex = 82;
            this.label3.Text = "Book List";
            // 
            // dataGridView_bookList
            // 
            this.dataGridView_bookList.AllowUserToAddRows = false;
            this.dataGridView_bookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_bookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_bookList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_bookList.GridColor = System.Drawing.Color.Black;
            this.dataGridView_bookList.Location = new System.Drawing.Point(31, 126);
            this.dataGridView_bookList.Name = "dataGridView_bookList";
            this.dataGridView_bookList.ReadOnly = true;
            this.dataGridView_bookList.RowHeadersWidth = 51;
            this.dataGridView_bookList.RowTemplate.Height = 29;
            this.dataGridView_bookList.Size = new System.Drawing.Size(1243, 587);
            this.dataGridView_bookList.TabIndex = 55;
            // 
            // BooklistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Tech.Properties.Resources._5487854;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1410, 856);
            this.Controls.Add(this.panel_booklist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BooklistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooklistForm";
            this.Load += new System.EventHandler(this.BooklistForm_Load_1);
            this.panel_booklist.ResumeLayout(false);
            this.panel_booklist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_booklist;
        private DataGridView dataGridView_bookList;
        private Label label3;
    }
}