using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_1
{
    public class Book
    {
        public int bookid;
        public string booktitl;
        
        public void Print(int bid,string btitl)
        {
           bookid = bid;
           booktitl = btitl;
           
        

        }

        
           
        
    }
    public class Bdetails:Book
    {
        public string bookauthr;
        private int bookprc;
        //property
        public int Bookprc
        {
            get
            {
                return this.bookprc;
            }

            set
            {
                this.bookprc = value;
            }
        }
        public void Method(string bauthor,int bookprice)
        {
            bookauthr = bauthor;
            bookprc = bookprice;

        }

    }
}
