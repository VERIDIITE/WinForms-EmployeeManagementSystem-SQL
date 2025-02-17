namespace EmployeeMngmt1
{
    partial class Departments
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            EditBtn = new Button();
            AddBtn = new Button();
            DepList = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            DepNameTbl = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DepList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.MediumPurple;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.Black;
            EditBtn.Location = new Point(156, 418);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(91, 35);
            EditBtn.TabIndex = 45;
            EditBtn.Text = "Update";
            EditBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.MediumSlateBlue;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(32, 418);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(86, 35);
            AddBtn.TabIndex = 44;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // DepList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DepList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DepList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DepList.ColumnHeadersHeight = 4;
            DepList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DepList.DefaultCellStyle = dataGridViewCellStyle3;
            DepList.GridColor = Color.FromArgb(231, 229, 255);
            DepList.Location = new Point(319, 259);
            DepList.Name = "DepList";
            DepList.RowHeadersVisible = false;
            DepList.Size = new Size(741, 581);
            DepList.TabIndex = 41;
            DepList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DepList.ThemeStyle.AlternatingRowsStyle.Font = null;
            DepList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DepList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DepList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DepList.ThemeStyle.BackColor = Color.White;
            DepList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DepList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DepList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DepList.ThemeStyle.HeaderStyle.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DepList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DepList.ThemeStyle.HeaderStyle.Height = 4;
            DepList.ThemeStyle.ReadOnly = false;
            DepList.ThemeStyle.RowsStyle.BackColor = Color.White;
            DepList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DepList.ThemeStyle.RowsStyle.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DepList.ThemeStyle.RowsStyle.Height = 25;
            DepList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DepList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(97, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSlateBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1215);
            panel2.Name = "panel2";
            panel2.Size = new Size(1114, 15);
            panel2.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumSlateBlue;
            label3.Location = new Point(32, 228);
            label3.Name = "label3";
            label3.Size = new Size(169, 28);
            label3.TabIndex = 30;
            label3.Text = "Departments Name";
            // 
            // DepNameTbl
            // 
            DepNameTbl.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepNameTbl.Location = new Point(32, 259);
            DepNameTbl.Name = "DepNameTbl";
            DepNameTbl.Size = new Size(215, 31);
            DepNameTbl.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 14F, FontStyle.Bold);
            label2.ForeColor = Color.MediumSlateBlue;
            label2.Location = new Point(563, 161);
            label2.Name = "label2";
            label2.Size = new Size(244, 34);
            label2.TabIndex = 28;
            label2.Text = "Manage Departments";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(507, 30);
            label1.Name = "label1";
            label1.Size = new Size(340, 28);
            label1.TabIndex = 0;
            label1.Text = "Employee Managment System Version 1.0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 78);
            panel1.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumSlateBlue;
            label4.Location = new Point(678, 212);
            label4.Name = "label4";
            label4.Size = new Size(146, 28);
            label4.TabIndex = 46;
            label4.Text = "Departments List";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(319, 84);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MediumSlateBlue;
            label5.Location = new Point(366, 89);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 48;
            label5.Text = "Employee";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MediumSlateBlue;
            label6.Location = new Point(522, 89);
            label6.Name = "label6";
            label6.Size = new Size(117, 28);
            label6.TabIndex = 50;
            label6.Text = "Departments";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(475, 84);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 49;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.MediumSlateBlue;
            label7.Location = new Point(702, 89);
            label7.Name = "label7";
            label7.Size = new Size(62, 28);
            label7.TabIndex = 52;
            label7.Text = "Salary";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(655, 84);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 51;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.MediumSlateBlue;
            label8.Location = new Point(851, 89);
            label8.Name = "label8";
            label8.Size = new Size(66, 28);
            label8.TabIndex = 54;
            label8.Text = "Logout";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(804, 84);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 33);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 53;
            pictureBox5.TabStop = false;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1114, 1230);
            Controls.Add(label8);
            Controls.Add(pictureBox5);
            Controls.Add(label7);
            Controls.Add(pictureBox4);
            Controls.Add(label6);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(DepList);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(DepNameTbl);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "Departments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "=";
            ((System.ComponentModel.ISupportInitialize)DepList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditBtn;
        private Button AddBtn;
        private Guna.UI2.WinForms.Guna2DataGridView DepList;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private TextBox DepNameTbl;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label7;
        private PictureBox pictureBox4;
        private Label label8;
        private PictureBox pictureBox5;
    }
}