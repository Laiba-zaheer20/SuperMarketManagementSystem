using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace oop_project
{
    public partial class manager : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public manager()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cdc\Desktop\oop data base for oil.accdb;
Persist Security Info=False;";           
        }

        private void managerform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            add_items obj = new add_items();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewitems vi = new viewitems();
          
            vi.Show();
          //  da.Fill(dt);
            
          //  itemsview.
            Hide();

        }

        private void managerback_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 l = new Form2();
            l.Show();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            string tb = deletebox.Text;
            if(tb==""||tb=="enter id"){
                label2.Visible = true;
            }
            else{
            oil o = new oil();
            o.deleteitem(tb);
            MessageBox.Show("successfull");}
        }

        private void addbutton1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            string com = addcom.Text ;
            string ty = addty.Text ;
            string i = IDs.Text;

            if (i == "" || i == "Enter Id" || com == "" || com == "enter company" || ty == "" || ty == "Enter type")
            {
                label2.Visible = true;
            }
            else
            {
                oil oilobj = new oil();
                oilobj.additem(com, ty,i);
                      MessageBox.Show("iem added successfully");
                 com = addcom.Text = null;
                 ty = addty.Text = null;
            }
        }

        private void deletebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                label1.Visible = true;
                e.Handled = true;
            }
            else
            {
                label1.Visible = false;
            }
        }
    }
}
