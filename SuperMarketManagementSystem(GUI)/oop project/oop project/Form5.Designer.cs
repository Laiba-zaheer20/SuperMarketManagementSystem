namespace oop_project
{
    partial class Form5
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
            this.ID_Number = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.delete_id_boxs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "GO_BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID_Number
            // 
            this.ID_Number.AutoSize = true;
            this.ID_Number.Location = new System.Drawing.Point(33, 77);
            this.ID_Number.Name = "ID_Number";
            this.ID_Number.Size = new System.Drawing.Size(61, 13);
            this.ID_Number.TabIndex = 1;
            this.ID_Number.Text = "ID_Number";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(129, 122);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(64, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // delete_id_boxs
            // 
            this.delete_id_boxs.Location = new System.Drawing.Point(129, 74);
            this.delete_id_boxs.Name = "delete_id_boxs";
            this.delete_id_boxs.Size = new System.Drawing.Size(100, 20);
            this.delete_id_boxs.TabIndex = 3;
            this.delete_id_boxs.Text = "Enter Id ";
            this.delete_id_boxs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delete_id_boxs_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "*Invalid Entry";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "*mandatory field";
            this.label2.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_id_boxs);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.ID_Number);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ID_Number;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox delete_id_boxs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}