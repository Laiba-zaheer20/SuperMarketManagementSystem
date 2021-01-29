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
    public partial class Form4 : Form
    {
        public Form4()
        {

            InitializeComponent();
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cdc\Desktop\oop data base for oil.accdb;
Persist Security Info=False;";
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 k1 = new Form3();
            k1.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                cashiers oilviewobj = new cashiers();
                DataGridView v = dataGridView1;
                oilviewobj.viewemployee(v);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR "+ ex);
            }
            // TODO: This line of code loads data into the 'logInDataDataSet.EmployeesRecord' table. You can move, or remove it, as needed.
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
    }
}
