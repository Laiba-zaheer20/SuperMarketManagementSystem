namespace oop_project
{
    partial class manager
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
            this.button2 = new System.Windows.Forms.Button();
            this.managerback = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.deletebox = new System.Windows.Forms.TextBox();
            this.addbutton1 = new System.Windows.Forms.Button();
            this.addcom = new System.Windows.Forms.TextBox();
            this.addty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update Items\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "View Items\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // managerback
            // 
            this.managerback.Location = new System.Drawing.Point(94, 227);
            this.managerback.Name = "managerback";
            this.managerback.Size = new System.Drawing.Size(75, 23);
            this.managerback.TabIndex = 2;
            this.managerback.Text = "GO BACK\r\n";
            this.managerback.UseVisualStyleBackColor = true;
            this.managerback.Click += new System.EventHandler(this.managerback_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(105, 114);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(130, 23);
            this.deletebutton.TabIndex = 3;
            this.deletebutton.Text = "Delete Items";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // deletebox
            // 
            this.deletebox.Location = new System.Drawing.Point(5, 117);
            this.deletebox.Name = "deletebox";
            this.deletebox.Size = new System.Drawing.Size(100, 20);
            this.deletebox.TabIndex = 4;
            this.deletebox.Text = "enter id";
            this.deletebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deletebox_KeyPress);
            // 
            // addbutton1
            // 
            this.addbutton1.Location = new System.Drawing.Point(29, 198);
            this.addbutton1.Name = "addbutton1";
            this.addbutton1.Size = new System.Drawing.Size(206, 23);
            this.addbutton1.TabIndex = 5;
            this.addbutton1.Text = "Add Items";
            this.addbutton1.UseVisualStyleBackColor = true;
            this.addbutton1.Click += new System.EventHandler(this.addbutton1_Click);
            // 
            // addcom
            // 
            this.addcom.Location = new System.Drawing.Point(0, 161);
            this.addcom.Name = "addcom";
            this.addcom.Size = new System.Drawing.Size(100, 20);
            this.addcom.TabIndex = 6;
            this.addcom.Text = "enter company";
            // 
            // addty
            // 
            this.addty.Location = new System.Drawing.Point(106, 161);
            this.addty.Name = "addty";
            this.addty.Size = new System.Drawing.Size(100, 20);
            this.addty.TabIndex = 7;
            this.addty.Text = "Enter type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "*invalid entry";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "*madatory field";
            this.label2.Visible = false;
            // 
            // IDs
            // 
            this.IDs.Location = new System.Drawing.Point(212, 161);
            this.IDs.Name = "IDs";
            this.IDs.Size = new System.Drawing.Size(63, 20);
            this.IDs.TabIndex = 10;
            this.IDs.Text = "Enter Id";
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.IDs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addty);
            this.Controls.Add(this.addcom);
            this.Controls.Add(this.addbutton1);
            this.Controls.Add(this.deletebox);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.managerback);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "manager";
            this.Text = "x";
            this.Load += new System.EventHandler(this.managerform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button managerback;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.TextBox deletebox;
        private System.Windows.Forms.Button addbutton1;
        private System.Windows.Forms.TextBox addcom;
        private System.Windows.Forms.TextBox addty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDs;
    }
}