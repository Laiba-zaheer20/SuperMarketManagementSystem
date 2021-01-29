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
    public partial class add_items : Form
    {
        public OleDbConnection connection = new OleDbConnection();   //creating object to connect our
        //data base in the main class so that every function can access it
        //made this connection public so every form can access this database connection
        public add_items()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cdc\Desktop\oop data base for oil.accdb;
Persist Security Info=False;";                  //path of our access file inside constructor of form1
        }


        private void add_items_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oilstring = "oil"; //we will add strings for every item
            string itemstring = comboBox1.GetItemText(comboBox1.SelectedItem);   //getting the selected item string
          
            if (itemstring.Equals(oilstring))    //more if conditions will be added or switch conditions(same as in c)

            {
                Hide();
                form1 oilform = new form1();
                oilform.Show();
            }
        }

        private void add_items_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            manager obj = new manager();
            obj.Show();
        }
        
        



    }   
}       
    

