using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace oop_project
{
    public class cashiers : employeelist
    {
        public cashiers(string p, string i, string n, string pn, string s)
            : base(p, i, n, pn, s)
        {
        }
        public cashiers(string i)
            : base(i)
        {
        }
        public cashiers()
            : base()
        {
        }
        public cashiers(string i, string d)
            : base(i, d)
        {
        }
        public override void add()
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection cn = new OleDbConnection();

            if (id != "")
            {

                string l = "INSERT INTO EmployeesRecord (Posts,IDs,Persons,Phone_Numbers,Salarys)values('" + post + "','" + id + "','" + name + "','" + phonenumber + "','" + salary + "')";
                cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\oop data base for oil.accdb;
Persist Security Info=False;";
                cmd.Connection = cn;
                try
                {

                    cn.Open();
                    cmd.CommandText = l;
                    cmd.ExecuteNonQuery();
                    cn.Close();

                }//end try
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }// end catch
            }// end if
        }
        public override void delete()
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection cn = new OleDbConnection();

            if (id != "")
            {
                string q = "delete from  EmployeesRecord where IDs='" + id + "'";
                cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\oop data base for oil.accdb;
Persist Security Info=False;";
                cmd.Connection = cn;
                try
                {
                    cn.Open();
                    cmd.CommandText = q;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }//end try
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }// end catch
            }// end if
        }
        public override void update()
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection cn = new OleDbConnection();

            if (id != "")
            {
                string q = "update EmployeesRecord set Salarys='" + salary + "'where IDs='" + id + "'";
                cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\oop data base for oil.accdb;
Persist Security Info=False;";
                cmd.Connection = cn;
                try
                {
                    cn.Open();
                    cmd.CommandText = q;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }//end try
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }// end catch
            }// end if
        }
        public void viewemployee(DataGridView v)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\oop data base for oil.accdb;
Persist Security Info=False;";
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();

                command.Connection = connection;

                command.CommandText = "select * from EmployeesRecord";
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Form4 vi = new Form4();
                vi.Activate();
                v.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }

        }
    }
}
