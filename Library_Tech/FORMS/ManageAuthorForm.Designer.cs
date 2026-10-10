namespace Library_Tech.FORMS
{
    partial class ManageAuthorForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.label_authorCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_bio = new System.Windows.Forms.RichTextBox();
            this.dataGridView_authors = new System.Windows.Forms.DataGridView();
            this.label_bio = new System.Windows.Forms.Label();
            this.textBox_educ = new System.Windows.Forms.TextBox();
            this.label_educ = new System.Windows.Forms.Label();
            this.textBox_lname = new System.Windows.Forms.TextBox();
            this.label_lname = new System.Windows.Forms.Label();
            this.textBox_fname = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_fname = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_authors)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(26, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 51);
            this.button1.TabIndex = 54;
            this.button1.Text = "Add";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_export
            // 
            this.button_export.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_export.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_export.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_export.ForeColor = System.Drawing.Color.Black;
            this.button_export.Location = new System.Drawing.Point(427, 633);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(134, 61);
            this.button_export.TabIndex = 53;
            this.button_export.Text = "Export Authors To TXT File";
            this.button_export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_export.UseVisualStyleBackColor = false;
            this.button_export.Click += new System.EventHandler(this.button_export_Click_1);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.ForeColor = System.Drawing.Color.Black;
            this.button_delete.Location = new System.Drawing.Point(294, 638);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(128, 51);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "Delete";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click_1);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_edit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_edit.ForeColor = System.Drawing.Color.Black;
            this.button_edit.Location = new System.Drawing.Point(160, 638);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(128, 51);
            this.button_edit.TabIndex = 8;
            this.button_edit.Text = "Edit";
            this.button_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click_1);
            // 
            // label_authorCount
            // 
            this.label_authorCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_authorCount.ForeColor = System.Drawing.Color.Black;
            this.label_authorCount.Location = new System.Drawing.Point(1014, 588);
            this.label_authorCount.Name = "label_authorCount";
            this.label_authorCount.Size = new System.Drawing.Size(187, 56);
            this.label_authorCount.TabIndex = 52;
            this.label_authorCount.Text = "999999 Authors";
            this.label_authorCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_edit);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.button_export);
            this.panel2.Controls.Add(this.richTextBox_bio);
            this.panel2.Controls.Add(this.dataGridView_authors);
            this.panel2.Controls.Add(this.label_authorCount);
            this.panel2.Controls.Add(this.label_bio);
            this.panel2.Controls.Add(this.textBox_educ);
            this.panel2.Controls.Add(this.label_educ);
            this.panel2.Controls.Add(this.textBox_lname);
            this.panel2.Controls.Add(this.label_lname);
            this.panel2.Controls.Add(this.textBox_fname);
            this.panel2.Controls.Add(this.textBox_id);
            this.panel2.Controls.Add(this.label_id);
            this.panel2.Controls.Add(this.label_fname);
            this.panel2.Location = new System.Drawing.Point(175, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1209, 740);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(464, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 45);
            this.label2.TabIndex = 80;
            this.label2.Text = "Manage Authors Form";
            // 
            // richTextBox_bio
            // 
            this.richTextBox_bio.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox_bio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_bio.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_bio.ForeColor = System.Drawing.Color.Black;
            this.richTextBox_bio.Location = new System.Drawing.Point(31, 464);
            this.richTextBox_bio.Name = "richTextBox_bio";
            this.richTextBox_bio.Size = new System.Drawing.Size(438, 152);
            this.richTextBox_bio.TabIndex = 21;
            this.richTextBox_bio.Text = "";
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
            this.dataGridView_authors.Location = new System.Drawing.Point(538, 119);
            this.dataGridView_authors.Name = "dataGridView_authors";
            this.dataGridView_authors.ReadOnly = true;
            this.dataGridView_authors.RowHeadersWidth = 51;
            this.dataGridView_authors.RowTemplate.Height = 29;
            this.dataGridView_authors.Size = new System.Drawing.Size(656, 465);
            this.dataGridView_authors.TabIndex = 20;
            this.dataGridView_authors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_authors_CellClick_1);
            // 
            // label_bio
            // 
            this.label_bio.AutoSize = true;
            this.label_bio.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_bio.ForeColor = System.Drawing.Color.Black;
            this.label_bio.Location = new System.Drawing.Point(26, 432);
            this.label_bio.Name = "label_bio";
            this.label_bio.Size = new System.Drawing.Size(44, 25);
            this.label_bio.TabIndex = 18;
            this.label_bio.Text = "Bio:";
            // 
            // textBox_educ
            // 
            this.textBox_educ.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_educ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_educ.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_educ.ForeColor = System.Drawing.Color.Black;
            this.textBox_educ.Location = new System.Drawing.Point(31, 379);
            this.textBox_educ.Name = "textBox_educ";
            this.textBox_educ.Size = new System.Drawing.Size(438, 38);
            this.textBox_educ.TabIndex = 17;
            // 
            // label_educ
            // 
            this.label_educ.AutoSize = true;
            this.label_educ.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_educ.ForeColor = System.Drawing.Color.Black;
            this.label_educ.Location = new System.Drawing.Point(26, 347);
            this.label_educ.Name = "label_educ";
            this.label_educ.Size = new System.Drawing.Size(103, 25);
            this.label_educ.TabIndex = 16;
            this.label_educ.Text = "Education:";
            // 
            // textBox_lname
            // 
            this.textBox_lname.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_lname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_lname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_lname.ForeColor = System.Drawing.Color.Black;
            this.textBox_lname.Location = new System.Drawing.Point(31, 294);
            this.textBox_lname.Name = "textBox_lname";
            this.textBox_lname.Size = new System.Drawing.Size(438, 38);
            this.textBox_lname.TabIndex = 15;
            // 
            // label_lname
            // 
            this.label_lname.AutoSize = true;
            this.label_lname.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_lname.ForeColor = System.Drawing.Color.Black;
            this.label_lname.Location = new System.Drawing.Point(26, 262);
            this.label_lname.Name = "label_lname";
            this.label_lname.Size = new System.Drawing.Size(107, 25);
            this.label_lname.TabIndex = 14;
            this.label_lname.Text = "Last Name:";
            // 
            // textBox_fname
            // 
            this.textBox_fname.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_fname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_fname.ForeColor = System.Drawing.Color.Black;
            this.textBox_fname.Location = new System.Drawing.Point(31, 209);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.Size = new System.Drawing.Size(438, 38);
            this.textBox_fname.TabIndex = 13;
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_id.ForeColor = System.Drawing.Color.Black;
            this.textBox_id.Location = new System.Drawing.Point(31, 128);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(161, 34);
            this.textBox_id.TabIndex = 12;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_id.ForeColor = System.Drawing.Color.Black;
            this.label_id.Location = new System.Drawing.Point(26, 96);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(35, 25);
            this.label_id.TabIndex = 10;
            this.label_id.Text = "ID:";
            // 
            // label_fname
            // 
            this.label_fname.AutoSize = true;
            this.label_fname.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_fname.ForeColor = System.Drawing.Color.Black;
            this.label_fname.Location = new System.Drawing.Point(26, 177);
            this.label_fname.Name = "label_fname";
            this.label_fname.Size = new System.Drawing.Size(110, 25);
            this.label_fname.TabIndex = 11;
            this.label_fname.Text = "First Name:";
            // 
            // ManageAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::Library_Tech.Properties.Resources._5487854;
            this.ClientSize = new System.Drawing.Size(1550, 877);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManageAuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAuthorForm1";
            this.Load += new System.EventHandler(this.ManageAuthorForm_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_authors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Label label_close;
        private Button button_edit;
        private Button button_delete;
        private TextBox textBox_fname;
        private TextBox textBox_id;
        private Label label_id;
        private Label label_fname;
        private TextBox textBox_lname;
        private Label label_lname;
        private DataGridView dataGridView_authors;
        private Label label_bio;
        private TextBox textBox_educ;
        private Label label_educ;
        private RichTextBox richTextBox_bio;
        private Label label_authorCount;
        private Button button_export;
        private Button button1;
        private Label label2;
    }
}