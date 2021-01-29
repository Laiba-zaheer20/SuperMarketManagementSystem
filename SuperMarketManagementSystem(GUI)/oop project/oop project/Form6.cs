using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace oop_project
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string a = Post_Boxs.Text;
            string b = ID_BOXS.Text;
            string c = Name_Boxs.Text;
            string d = number_boxs.Text;
            string g = salary_boxs.Text;
            if(a==""||b==""||c==""||d==""||g==""||c=="Enter Name"){
                label1.Visible = true;
            }
            else{
            employeelist L1 = new cashiers(a,b,c,d,g);
            L1.add();
            MessageBox.Show("Record Added!!");
            Post_Boxs.Text = null;
            ID_BOXS.Text = null;
            Name_Boxs.Text = null;
            number_boxs.Text = null;
            salary_boxs.Text = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 k1 = new Form3();
            k1.Show();
        }

        private void ID_BOXS_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                label2.Visible = true;
                e.Handled = true;
            }
            else
            {
                label2.Visible = false;
            }
        }

        private void number_boxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                label2.Visible = true;
                e.Handled = true;
            }
            else
            {
                label2.Visible = false;
            }
        }

        private void salary_boxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                label2.Visible = true;
                e.Handled = true;
            }
            else
            {
                label2.Visible = false;
            }
        }
    }
}
