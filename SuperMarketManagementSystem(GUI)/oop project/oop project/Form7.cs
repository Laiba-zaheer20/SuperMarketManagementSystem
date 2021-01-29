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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void salary_update_Click(object sender, EventArgs e)
        {
            string n = id_check.Text;
            string k = new_salary_box.Text;
            if (n == "" || k == "" || n == "Enter Id" || k == "Enter new salary") {
                label1.Visible = true;
            }
            else{
            employeelist L1 = new cashiers(n, k);
            L1.update();
            MessageBox.Show("Salary Updated!!");
            id_check.Text = null;
            new_salary_box.Text = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 k1 = new Form3();
            k1.Show();
        }

        private void id_check_KeyPress(object sender, KeyPressEventArgs e)
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

        private void new_salary_box_KeyPress(object sender, KeyPressEventArgs e)
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
