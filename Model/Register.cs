using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IT13_Masudog.model
{
    internal class Register : User
    {
        public string username;
        public string password;
        public string email;
        public int phone;

        public Register (string username, string password, string email, int phone) : base (username, password)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.phone = phone;
             
        }
    }