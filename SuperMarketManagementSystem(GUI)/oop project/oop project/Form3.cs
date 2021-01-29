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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 k1 = new Form5();
            k1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 k1 = new Form7();
            k1.Show();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 k1 = new Form4();
            k1.Show();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 k1 = new Form2();
            k1.Show();
        }

        private void add_E_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 k1 = new Form6();
            k1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
