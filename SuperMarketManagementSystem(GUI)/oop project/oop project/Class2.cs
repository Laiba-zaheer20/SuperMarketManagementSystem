using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace oop_project
{

       class oil : stock
    {
       //    public OleDbConnection connection = new OleDbConnection();

        string type;
      
        public oil()
        {
          
        }
        public oil(string cost, string q, string com, string eos,string dop,string ty):base (cost,q,com,eos,dop)
        {
            type = ty;
         }

        public void updateitem(string cost,string quantity,string com,string eos,string dop,string ty)
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection cn = new OleDbConnection();

            if (com != "")
            {
                string q = "update oilstock set cost='"+cost+"' where company='"+com+"'";
                cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nayyer\Desktop\oop data base for oil.accdb;
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
      
        public void viewitem(DataGridView v) {

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nayyer\Desktop\oop data base for oil.accdb;
Persist Security Info=False;";
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
               
                command.Connection = connection;
             
                command.CommandText = "select * from oilstock";
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                viewitems vi = new viewitems();
                vi.Activate();
                v.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        
        }

        public void deleteitem(string tb) {
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection cn = new OleDbConnection();

            if (tb != "") {
                string q = "delete from oilstock where company='"+tb+"'";
                cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nayyer\Desktop\oop data base for oil.accdb;
Persist Security Info=False;";
                cmd.Connection = cn;
                try
                {
                    cn.Open();
                    cmd.CommandText = q;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }//end try
                catch(Exception ex) {
                    MessageBox.Show("error" + ex);
                }// end catch
                
                
                
            }// end if
        
        
        
        }// end method


        public void additem( string com,string ty,string k)
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection cn = new OleDbConnection();

            if (com != "")
            {
                string q = "insert into  oilstock(company,type,ids)values('"+com+"','"+ty+"','"+k+"')";
                cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nayyer\Desktop\oop data base for oil.accdb;
Persist Security Info=False;";
                cmd.Connection = cn;
                try
                {
                    //MessageBox.Show("in try");
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



        }// end method

        public void sellitem(string cost, string quantity, string com, string eos, string dop, string ty)
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection cn = new OleDbConnection();

            if (com != "")
            {

                string q = "update oilstock set cost='" + cost + "' where company='" + com + "'";
                cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nayyer\Desktop\oop data base for oil.accdb;
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
        } //end sell method
        public static int count = 0,q=0;
     static    string r;
           public string  viewquantity(string n){


               connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nayyer\Desktop\oop data base for oil.accdb;
Persist Security Info=False;";
               try{
            connection.Open();
                OleDbCommand command = new OleDbCommand();   // to give any command to our database
                command.Connection = connection;   // to tell that for which database our command is
                command.CommandText = "select * from oilstock where ids='" +n+ "'";  //setting the query
                OleDbDataReader reader = command.ExecuteReader();      // to read from the above query  executenonquery is used to add or update in database
                // it returns boolean value 
                string rt="incorrect id";
       
                string c;
                  while (reader.Read())  {
                  c=reader[6].ToString();  //column no. of quantity
                   rt = reader[2].ToString();
                   //MessageBox.Show(reader[3].ToString());      //cost
                   r = reader[3].ToString();
                   
                   //count =count+ Int32.Parse(c);
                   // sold item quantity
                   
                  
                    
                //   MessageBox.Show(count.ToString());
                }// end while
                  q = q + Int32.Parse(r);
                return rt;
                } //end try
                   catch (Exception ex){
                       string g="sorry";
                       MessageBox.Show("error" + ex);
                       return g;
                   }// end catch
           
           }// end viewquantity method
        
        }
    };

