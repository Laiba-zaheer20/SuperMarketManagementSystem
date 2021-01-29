namespace oop_project
{
    partial class Form3
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
            this.employee = new System.Windows.Forms.Button();
            this.Remove_E = new System.Windows.Forms.Button();
            this.add_E = new System.Windows.Forms.Button();
            this.update_E = new System.Windows.Forms.Button();
            this.BACK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employee
            // 
            this.employee.Location = new System.Drawing.Point(33, 33);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(128, 23);
            this.employee.TabIndex = 0;
            this.employee.Text = "Employee Detail";
            this.employee.UseVisualStyleBackColor = true;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            // 
            // Remove_E
            // 
            this.Remove_E.Location = new System.Drawing.Point(33, 62);
            this.Remove_E.Name = "Remove_E";
            this.Remove_E.Size = new System.Drawing.Size(128, 23);
            this.Remove_E.TabIndex = 1;
            this.Remove_E.Text = "Remove Employee";
            this.Remove_E.UseVisualStyleBackColor = true;
            this.Remove_E.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_E
            // 
            this.add_E.Location = new System.Drawing.Point(33, 91);
            this.add_E.Name = "add_E";
            this.add_E.Size = new System.Drawing.Size(128, 23);
            this.add_E.TabIndex = 2;
            this.add_E.Text = "Add Employee";
            this.add_E.UseVisualStyleBackColor = true;
            this.add_E.Click += new System.EventHandler(this.add_E_Click);
            // 
            // update_E
            // 
            this.update_E.Location = new System.Drawing.Point(33, 120);
            this.update_E.Name = "update_E";
            this.update_E.Size = new System.Drawing.Size(128, 23);
            this.update_E.TabIndex = 3;
            this.update_E.Text = "Update Employee Salary";
            this.update_E.UseVisualStyleBackColor = true;
            this.update_E.Click += new System.EventHandler(this.button4_Click);
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(33, 149);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(128, 26);
            this.BACK.TabIndex = 4;
            this.BACK.Text = "GO BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_E);
            this.groupBox1.Controls.Add(this.BACK);
            this.groupBox1.Controls.Add(this.Remove_E);
            this.groupBox1.Controls.Add(this.update_E);
            this.groupBox1.Controls.Add(this.employee);
            this.groupBox1.Location = new System.Drawing.Point(53, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 190);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "employee information";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.Button Remove_E;
        private System.Windows.Forms.Button add_E;
        private System.Windows.Forms.Button update_E;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}