namespace oop_project
{
    partial class Form6
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
            this.button1 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.salary_boxs = new System.Windows.Forms.TextBox();
            this.number_boxs = new System.Windows.Forms.TextBox();
            this.Name_Boxs = new System.Windows.Forms.TextBox();
            this.ID_BOXS = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.Label();
            this.phone_number = new System.Windows.Forms.Label();
            this.NAMES = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.posts = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Post_Boxs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "GO BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(22, 198);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // salary_boxs
            // 
            this.salary_boxs.Location = new System.Drawing.Point(73, 135);
            this.salary_boxs.Name = "salary_boxs";
            this.salary_boxs.Size = new System.Drawing.Size(100, 20);
            this.salary_boxs.TabIndex = 2;
            this.salary_boxs.Text = "Enter Salary";
            this.salary_boxs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_boxs_KeyPress);
            // 
            // number_boxs
            // 
            this.number_boxs.Location = new System.Drawing.Point(73, 104);
            this.number_boxs.Name = "number_boxs";
            this.number_boxs.Size = new System.Drawing.Size(100, 20);
            this.number_boxs.TabIndex = 3;
            this.number_boxs.Text = "Enter Number";
            this.number_boxs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_boxs_KeyPress);
            // 
            // Name_Boxs
            // 
            this.Name_Boxs.Location = new System.Drawing.Point(73, 78);
            this.Name_Boxs.Name = "Name_Boxs";
            this.Name_Boxs.Size = new System.Drawing.Size(100, 20);
            this.Name_Boxs.TabIndex = 4;
            this.Name_Boxs.Text = "Enter Name";
            // 
            // ID_BOXS
            // 
            this.ID_BOXS.Location = new System.Drawing.Point(73, 52);
            this.ID_BOXS.Name = "ID_BOXS";
            this.ID_BOXS.Size = new System.Drawing.Size(100, 20);
            this.ID_BOXS.TabIndex = 5;
            this.ID_BOXS.Text = "Enter Id";
            this.ID_BOXS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_BOXS_KeyPress);
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Location = new System.Drawing.Point(19, 135);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(34, 13);
            this.salary.TabIndex = 7;
            this.salary.Text = "salary";
            // 
            // phone_number
            // 
            this.phone_number.AutoSize = true;
            this.phone_number.Location = new System.Drawing.Point(6, 104);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(48, 13);
            this.phone_number.TabIndex = 8;
            this.phone_number.Text = "Phone #";
            this.phone_number.Click += new System.EventHandler(this.label2_Click);
            // 
            // NAMES
            // 
            this.NAMES.AutoSize = true;
            this.NAMES.Location = new System.Drawing.Point(19, 78);
            this.NAMES.Name = "NAMES";
            this.NAMES.Size = new System.Drawing.Size(35, 13);
            this.NAMES.TabIndex = 9;
            this.NAMES.Text = "Name";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(19, 52);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 10;
            this.ID.Text = "ID";
            // 
            // posts
            // 
            this.posts.AutoSize = true;
            this.posts.Location = new System.Drawing.Point(19, 29);
            this.posts.Name = "posts";
            this.posts.Size = new System.Drawing.Size(28, 13);
            this.posts.TabIndex = 11;
            this.posts.Text = "Post";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Post_Boxs);
            this.groupBox1.Controls.Add(this.posts);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.salary_boxs);
            this.groupBox1.Controls.Add(this.number_boxs);
            this.groupBox1.Controls.Add(this.Name_Boxs);
            this.groupBox1.Controls.Add(this.ID_BOXS);
            this.groupBox1.Controls.Add(this.salary);
            this.groupBox1.Controls.Add(this.phone_number);
            this.groupBox1.Controls.Add(this.NAMES);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Location = new System.Drawing.Point(40, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 238);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD EMPLOYEE";
            // 
            // Post_Boxs
            // 
            this.Post_Boxs.FormattingEnabled = true;
            this.Post_Boxs.Items.AddRange(new object[] {
            "Cashier",
            "Salesman",
            "Guard"});
            this.Post_Boxs.Location = new System.Drawing.Point(73, 21);
            this.Post_Boxs.Name = "Post_Boxs";
            this.Post_Boxs.Size = new System.Drawing.Size(100, 21);
            this.Post_Boxs.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "*All Fields are mandatory";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "*one of your entry\'s format is incorrect";
            this.label2.Visible = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox salary_boxs;
        private System.Windows.Forms.TextBox number_boxs;
        private System.Windows.Forms.TextBox Name_Boxs;
        private System.Windows.Forms.TextBox ID_BOXS;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label phone_number;
        private System.Windows.Forms.Label NAMES;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label posts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Post_Boxs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}