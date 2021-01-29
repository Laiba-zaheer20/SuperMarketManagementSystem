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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         
            oil obj = new oil();
            string n = textBox1.Text;
           string rt= obj.viewquantity(n);
           items.Items.Add(rt);
            textBox1.Text = null;
        
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            oil obj = new oil();
           int c= oil.q;
           textBox2.Text = c.ToString();

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            login obj = new login();
            Hide();
            obj.Show();
        }

    }
}
