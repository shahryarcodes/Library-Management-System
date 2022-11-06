using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_1
{
    public class Sdetails
    {
        public string firstname;
        public string lastname;
        public string departname;
        private int sid;

        //propery
        public int Sid
        {
            get
            {
                return this.sid;
            }
            set
            {
                this.sid = value;
            }
        }
        //parameterized constructor
        public Sdetails(string fname,string lname,string dname,int stid)
        {
            firstname = fname;
           lastname = lname;
            departname = dname;
            sid = stid;

        }


    }
}
