using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
namespace oop_project
{
    public class stock
    {
        public OleDbConnection connection = new OleDbConnection();
        //   private int price;
        protected string cost;
        protected string quantity;
        protected string company, ceos, cdop;

        public stock(string c, string q, string com, string eos, string dop)
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Nayyer\Desktop\oop data base for oil.accdb;
Persist Security Info=False;";
            cost = c;
            quantity = q;
            company = com;
            ceos = eos;
            cdop = dop;
            // price=cost*quantity;
        }
        public stock()
        {
      //    connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cdc\Desktop\oop data base for oil.accdb;
//Persist Security Info=False;";
        }


    };
}

// namespace  

   

