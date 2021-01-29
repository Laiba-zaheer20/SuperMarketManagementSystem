namespace oop_project
{
    partial class Form7
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
            this.Id_Number = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.id_check = new System.Windows.Forms.TextBox();
            this.new_salary_box = new System.Windows.Forms.TextBox();
            this.salary_update = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Id_Number
            // 
            this.Id_Number.AutoSize = true;
            this.Id_Number.Location = new System.Drawing.Point(47, 80);
            this.Id_Number.Name = "Id_Number";
            this.Id_Number.Size = new System.Drawing.Size(68, 13);
            this.Id_Number.TabIndex = 0;
            this.Id_Number.Text = "ID NUMBER";
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(47, 124);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(78, 13);
            this.Salary.TabIndex = 1;
            this.Salary.Text = "NEW SALARY";
            // 
            // id_check
            // 
            this.id_check.Location = new System.Drawing.Point(141, 77);
            this.id_check.Name = "id_check";
            this.id_check.Size = new System.Drawing.Size(100, 20);
            this.id_check.TabIndex = 2;
            this.id_check.Text = "Enter Id";
            this.id_check.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_check_KeyPress);
            // 
            // new_salary_box
            // 
            this.new_salary_box.Location = new System.Drawing.Point(141, 117);
            this.new_salary_box.Name = "new_salary_box";
            this.new_salary_box.Size = new System.Drawing.Size(100, 20);
            this.new_salary_box.TabIndex = 3;
            this.new_salary_box.Text = "Enter new salary";
            this.new_salary_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.new_salary_box_KeyPress);
            // 
            // salary_update
            // 
            this.salary_update.Location = new System.Drawing.Point(77, 169);
            this.salary_update.Name = "salary_update";
            this.salary_update.Size = new System.Drawing.Size(122, 23);
            this.salary_update.TabIndex = 4;
            this.salary_update.Text = "SALARY UPDATE";
            this.salary_update.UseVisualStyleBackColor = true;
            this.salary_update.Click += new System.EventHandler(this.salary_update_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "GO BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "*Fields Mandatory";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "*Enter Numbers Only";
            this.label2.Visible = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.salary_update);
            this.Controls.Add(this.new_salary_box);
            this.Controls.Add(this.id_check);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Id_Number);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Id_Number;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.TextBox id_check;
        private System.Windows.Forms.TextBox new_salary_box;
        private System.Windows.Forms.Button salary_update;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}