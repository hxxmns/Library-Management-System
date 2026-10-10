namespace Library_Tech.FORMS
{
    partial class TermsAndConditionForm
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label_tc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "If you borrow a book, you must give your ID to the librarian";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(544, 418);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(462, 32);
            this.checkBox1.TabIndex = 62;
            this.checkBox1.Text = "I agree to the terms and condition of Library Tech";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(847, 478);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(159, 46);
            this.button_add.TabIndex = 74;
            this.button_add.Text = "Agree";
            this.button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_tc
            // 
            this.label_tc.AutoSize = true;
            this.label_tc.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_tc.Location = new System.Drawing.Point(544, 453);
            this.label_tc.Name = "label_tc";
            this.label_tc.Size = new System.Drawing.Size(245, 20);
            this.label_tc.TabIndex = 75;
            this.label_tc.Text = "Agree to the terms and conditions *";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label_tc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Location = new System.Drawing.Point(148, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 543);
            this.panel1.TabIndex = 76;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(537, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 8);
            this.panel2.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(364, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 46);
            this.label2.TabIndex = 78;
            this.label2.Text = "Terms and Condition";
            // 
            // TermsAndConditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Tech.Properties.Resources._54878541;
            this.ClientSize = new System.Drawing.Size(1309, 746);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TermsAndConditionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TermsAndConditionForm";
            this.Load += new System.EventHandler(this.TermsAndConditionForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private CheckBox checkBox1;
        private Button button_add;
        private Label label_tc;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
    }
}