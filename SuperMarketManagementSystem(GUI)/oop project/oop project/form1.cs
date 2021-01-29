using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;               //oledb namespace is used for access database
namespace oop_project
{
    public partial class form1 : Form
    {
        private Label companylabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox companytb;
        private DateTimePicker stockendselect;
        private DateTimePicker purchasedateselect;
        private TextBox quantitytb;
        private TextBox costtb;
        private Label label1;
        private Label label5;
        private ComboBox typeselect;
        private Button addbutton;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
       public  OleDbConnection connection = new OleDbConnection();   //creating object to connect our
        //data base in the main class so that every function can access it
        //made this connection public so every form can access this database connection
        public form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cdc\Desktop\oop data base for oil.accdb;
Persist Security Info=False;";                  //path of our access file inside constructor of form1
        }
        private void InitializeComponent()
        {
            this.companylabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.companytb = new System.Windows.Forms.ComboBox();
            this.stockendselect = new System.Windows.Forms.DateTimePicker();
            this.purchasedateselect = new System.Windows.Forms.DateTimePicker();
            this.quantitytb = new System.Windows.Forms.TextBox();
            this.costtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.typeselect = new System.Windows.Forms.ComboBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companylabel
            // 
            this.companylabel.AutoSize = true;
            this.companylabel.Location = new System.Drawing.Point(22, 39);
            this.companylabel.Name = "companylabel";
            this.companylabel.Size = new System.Drawing.Size(51, 13);
            this.companylabel.TabIndex = 0;
            this.companylabel.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Of Purchase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Of Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quanity";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // companytb
            // 
            this.companytb.FormattingEnabled = true;
            this.companytb.Items.AddRange(new object[] {
            "sunflower",
            "dalda ",
            "meezan"});
            this.companytb.Location = new System.Drawing.Point(116, 31);
            this.companytb.Name = "companytb";
            this.companytb.Size = new System.Drawing.Size(121, 21);
            this.companytb.TabIndex = 4;
            this.companytb.Text = "company";
            this.companytb.SelectedIndexChanged += new System.EventHandler(this.companytb_SelectedIndexChanged);
            // 
            // stockendselect
            // 
            this.stockendselect.Location = new System.Drawing.Point(116, 105);
            this.stockendselect.Name = "stockendselect";
            this.stockendselect.Size = new System.Drawing.Size(200, 20);
            this.stockendselect.TabIndex = 5;
            // 
            // purchasedateselect
            // 
            this.purchasedateselect.Location = new System.Drawing.Point(116, 73);
            this.purchasedateselect.Name = "purchasedateselect";
            this.purchasedateselect.Size = new System.Drawing.Size(200, 20);
            this.purchasedateselect.TabIndex = 6;
            // 
            // quantitytb
            // 
            this.quantitytb.Location = new System.Drawing.Point(116, 138);
            this.quantitytb.Name = "quantitytb";
            this.quantitytb.Size = new System.Drawing.Size(100, 20);
            this.quantitytb.TabIndex = 8;
            this.quantitytb.Text = "Enter quantity";
            this.quantitytb.TextChanged += new System.EventHandler(this.quantitytb_TextChanged);
            this.quantitytb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantitytb_KeyPress);
            // 
            // costtb
            // 
            this.costtb.Location = new System.Drawing.Point(116, 176);
            this.costtb.Name = "costtb";
            this.costtb.Size = new System.Drawing.Size(100, 20);
            this.costtb.TabIndex = 9;
            this.costtb.Text = "Enter Cost Per Item";
            this.costtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costtb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cost";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type";
            // 
            // typeselect
            // 
            this.typeselect.FormattingEnabled = true;
            this.typeselect.Items.AddRange(new object[] {
            "hair",
            "cooking"});
            this.typeselect.Location = new System.Drawing.Point(116, 214);
            this.typeselect.Name = "typeselect";
            this.typeselect.Size = new System.Drawing.Size(121, 21);
            this.typeselect.TabIndex = 12;
            this.typeselect.Text = "select type";
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(72, 255);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 13;
            this.addbutton.Text = "Update";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "*Invalid Entry";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "*Invalid Entry";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "*All fields are mandatory";
            this.label8.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form1
            // 
            this.ClientSize = new System.Drawing.Size(338, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.typeselect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costtb);
            this.Controls.Add(this.quantitytb);
            this.Controls.Add(this.purchasedateselect);
            this.Controls.Add(this.stockendselect);
            this.Controls.Add(this.companytb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companylabel);
            this.Name = "form1";
            this.Tag = "";
            this.Text = "Oil Stock";
            this.Load += new System.EventHandler(this.form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        } // initialize component

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        
        
        //main code 
        private void form1_Load_1(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string com = companytb.Text;
                string eos = stockendselect.Text;
                string dop = purchasedateselect.Text;
                string cost = costtb.Text;
                string quantity = quantitytb.Text;
                string ty = typeselect.Text;
                if (com == ""||com=="company"||cost=="Enter Cost Per Item"||quantity=="Enter quantity"||ty=="select type"||eos==""||dop==""||cost==""||quantity==""||ty=="")
                {
                    label8.Visible = true;
                }
                else
                {
                    MessageBox.Show(" UPDATED ");
                    oil newoil = new oil();
                    newoil.updateitem(cost, quantity, com, eos, dop, ty);
                    companytb.Text = null;
                    stockendselect.Text = null;
                    purchasedateselect.Text = null;
                    costtb.Text = null;
                    quantitytb.Text = null;
                    typeselect.Text = null;
                }
            }
            catch
            {
                MessageBox.Show("cannot access database");
                Application.Exit();
            }

        }

        private void companytb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quantitytb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                label6.Visible = true;
                e.Handled = true;
            }
            else
            {
                label6.Visible = false;
            }
        }

        private void costtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                label7.Visible = true;
                e.Handled = true;
            }
            else
            {
                label7.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            manager k1 = new manager();
            k1.Show();
        }

        private void quantitytb_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
    
}
