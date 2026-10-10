namespace Library_Tech.FORMS
{
    partial class ManageGenresForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.dataGridView_genres = new System.Windows.Forms.DataGridView();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_genres)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.dataGridView_genres);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Location = new System.Drawing.Point(146, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 539);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(375, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 45);
            this.label2.TabIndex = 79;
            this.label2.Text = "Manage Genres Form";
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_edit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_edit.Location = new System.Drawing.Point(233, 315);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(127, 45);
            this.button_edit.TabIndex = 7;
            this.button_edit.Text = "Edit";
            this.button_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.Location = new System.Drawing.Point(407, 315);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(123, 45);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = " Delete";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add.Location = new System.Drawing.Point(59, 315);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(127, 45);
            this.button_add.TabIndex = 5;
            this.button_add.Text = " Add";
            this.button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dataGridView_genres
            // 
            this.dataGridView_genres.AllowUserToAddRows = false;
            this.dataGridView_genres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_genres.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView_genres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_genres.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_genres.GridColor = System.Drawing.Color.Black;
            this.dataGridView_genres.Location = new System.Drawing.Point(587, 117);
            this.dataGridView_genres.Name = "dataGridView_genres";
            this.dataGridView_genres.ReadOnly = true;
            this.dataGridView_genres.RowHeadersWidth = 51;
            this.dataGridView_genres.RowTemplate.Height = 29;
            this.dataGridView_genres.Size = new System.Drawing.Size(428, 409);
            this.dataGridView_genres.TabIndex = 4;
            this.dataGridView_genres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_genres_CellClick);
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_name.Location = new System.Drawing.Point(64, 229);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(466, 33);
            this.textBox_name.TabIndex = 3;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_id.Location = new System.Drawing.Point(64, 151);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(161, 33);
            this.textBox_id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(59, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.SystemColors.Menu;
            this.label_id.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_id.ForeColor = System.Drawing.Color.Black;
            this.label_id.Location = new System.Drawing.Point(59, 121);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(35, 25);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID:";
            this.label_id.Click += new System.EventHandler(this.label_id_Click);
            // 
            // ManageGenresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::Library_Tech.Properties.Resources._5487854;
            this.ClientSize = new System.Drawing.Size(1309, 746);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManageGenresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageGenresForm";
            this.Load += new System.EventHandler(this.ManageGenresForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_genres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label_id;
        private TextBox textBox_name;
        private TextBox textBox_id;
        private Button button_add;
        private DataGridView dataGridView_genres;
        private Button button_edit;
        private Button button_delete;
        private Label label2;
    }
}