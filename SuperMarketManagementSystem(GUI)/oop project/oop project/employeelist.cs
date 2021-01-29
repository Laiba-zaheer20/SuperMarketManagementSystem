using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop_project
{
     public  abstract class employeelist
        {
           
            public string post;
            public string id;
            public string name;
            public string phonenumber;
            public string salary;
            public employeelist(string p,string i,string n,string pn,string s)
            {
                post=p;
                id=i;
                name=n;
                phonenumber=pn;
                salary = s;
            }
            public employeelist(string i)
            {
                id = i;
            }
            public employeelist()
            {
              
            }
            public employeelist(string i,string k)
            {
                id = i;
                salary = k;
            }
            public abstract void add();
            public virtual void delete() {
            }
            public virtual void update()
            {
            }
       }
}

