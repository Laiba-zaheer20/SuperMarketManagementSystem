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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string b = delete_id_boxs.Text;
            if (b == "" || b == "Enter Id ")
            {
                label2.Visible = true;
            }
            else{
            employeelist l1 = new cashiers(b);
            l1.delete();
            MessageBox.Show("Record Deleted!!");
            delete_id_boxs.Text = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 k1 = new Form3();
            k1.Show();
        }

        private void delete_id_boxs_KeyPress(object sender, KeyPressEventArgs e)
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
