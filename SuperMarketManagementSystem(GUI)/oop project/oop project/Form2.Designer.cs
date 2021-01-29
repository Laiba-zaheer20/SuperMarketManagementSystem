namespace oop_project
{
    partial class Form2
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
            this.STOCK = new System.Windows.Forms.Button();
            this.employees = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GO_BACK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // STOCK
            // 
            this.STOCK.Location = new System.Drawing.Point(35, 33);
            this.STOCK.Name = "STOCK";
            this.STOCK.Size = new System.Drawing.Size(123, 23);
            this.STOCK.TabIndex = 0;
            this.STOCK.Text = "STOCK";
            this.STOCK.UseVisualStyleBackColor = true;
            this.STOCK.Click += new System.EventHandler(this.STOCK_Click);
            // 
            // employees
            // 
            this.employees.Location = new System.Drawing.Point(35, 75);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(123, 23);
            this.employees.TabIndex = 1;
            this.employees.Text = "EMPLOYEE INFO";
            this.employees.UseVisualStyleBackColor = true;
            this.employees.Click += new System.EventHandler(this.employees_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GO_BACK);
            this.groupBox1.Controls.Add(this.employees);
            this.groupBox1.Controls.Add(this.STOCK);
            this.groupBox1.Location = new System.Drawing.Point(45, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manager List";
            // 
            // GO_BACK
            // 
            this.GO_BACK.Location = new System.Drawing.Point(35, 117);
            this.GO_BACK.Name = "GO_BACK";
            this.GO_BACK.Size = new System.Drawing.Size(123, 23);
            this.GO_BACK.TabIndex = 2;
            this.GO_BACK.Text = "GO BACK";
            this.GO_BACK.UseVisualStyleBackColor = true;
            this.GO_BACK.Click += new System.EventHandler(this.GO_BACK_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button STOCK;
        private System.Windows.Forms.Button employees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GO_BACK;
    }
}