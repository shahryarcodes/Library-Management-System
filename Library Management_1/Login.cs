using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_1
{
    internal class Login
    {
        public string email;
        public string pas;

        public void Show(string em, string pass)
        {
            this.email = em;
            this.pas = pass;


        }
    }
}
