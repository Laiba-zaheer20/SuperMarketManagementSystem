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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void STOCK_Click(object sender, EventArgs e)
        {
            manager mobj = new manager();
            Hide();
            mobj.Show();
        }

        private void GO_BACK_Click(object sender, EventArgs e)
        {
            login mobj = new login();
            Hide();
            mobj.Show();
        }

        private void employees_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 k1 = new Form3();
            k1.Show();
        }
    }
}
