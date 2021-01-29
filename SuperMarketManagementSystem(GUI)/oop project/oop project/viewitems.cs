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
    public partial class viewitems : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public viewitems()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cdc\Desktop\oop data base for oil.accdb;
Persist Security Info=False;";
        }

        public void itemsview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewitems_Load(object sender, EventArgs e)
        {
            try
            {
                oil oilviewobj = new oil();
                DataGridView v = itemsview;
                oilviewobj.viewitem(v);
                

            }
            catch
            {
                MessageBox.Show("ooff");
            }
        }

        private void viewok_Click(object sender, EventArgs e)
        {
            Hide();
            manager m = new manager();
            m.Show();
        }
    }
}
