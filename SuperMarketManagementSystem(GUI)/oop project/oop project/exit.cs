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
    public partial class exit : Form
    {
        public exit()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void no_Click(object sender, EventArgs e)
        {
            Hide();
            login m = new login();
            Hide();
            m.Show();
        }

        private void exit_Load(object sender, EventArgs e)
        {

        }
    }
}
