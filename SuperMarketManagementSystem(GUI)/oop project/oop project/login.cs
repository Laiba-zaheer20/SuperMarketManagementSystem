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
    public partial class login : Form
    {
        public OleDbConnection connection = new OleDbConnection();   //creating object to connect our
        //data base in the main class so that every function can access it
        //made this connection public so every form can access this database connection
        public login()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\oop data base for oil.accdb;
Persist Security Info=False;";                  //path of our access file inside constructor of form1
        }
        

        private void login_Load(object sender, EventArgs e)
        {
           
        }

        private void enterbutton_Click(object sender, EventArgs e)
        {
            Form2 mobj = new Form2();
                        Hide();
                        mobj.Show();

            //try
            //{
            //    connection.Open();
            //    OleDbCommand command = new OleDbCommand();   // to give any command to our database
            //    command.Connection = connection;   // to tell that for which database our command is
            //    command.CommandText = "select * from credentials where username='" + textBox1.Text + "' and password='" + textBox2.Text + "' and JobTitle='" + comboBox1.Text + "'";  //setting the query
            //    OleDbDataReader reader = command.ExecuteReader();      // to read from the above query  executenonquery is used to add or update in database
            //    // it returns boolean value 

            //    int count = 0;
            //    while (reader.Read())                  //while the pointer does not reach the end of database table reading the 'true' values
            //    {
            //        count++;                           //increase the count
            //    }
            //    if (count == 1)
            //    {
            //        Hide();

            //        if (comboBox1.Text == "manager")
            //        {
            //            //manager forms
            //            Form2 mobj = new Form2();
            //            Hide();
            //            mobj.Show();
            //        }
            //        else if (comboBox1.Text == "cashier")
            //        {
            //            MessageBox.Show("welcome cashier");
            //            Form8 obj = new Form8();
            //            Hide();
            //            obj.Show();

            //        }
            //        else
            //            MessageBox.Show("oops");

            //    }
            //    else if (count > 1)
            //    {

            //        MessageBox.Show("Error: two or more similar entries ");
            //        Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("incorrect  id , password  OR  job title");



            //    }
            //    connection.Close();  //closing the database before ending the function
            //    // Application.Exit();
            //}
            //catch {
            //    MessageBox.Show("please check your data base connection");
            
            //}
        }








        private void textBox1_TextChanged(object sender, EventArgs e) //username
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)   //password
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Hide();
            exit r = new exit();
            r.Show();

        }

      
    }
}
