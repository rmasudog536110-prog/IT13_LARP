using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IT13_Masudog.model
{
    internal class User
    {

        private string _username;
        private string _password;
        private string _email;
        private int _phone;
        private string _address;
        private string _role;

        public int Id { get; set; }

        public User(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int phone
        {
            get { return _phone; }

        }

        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string role
        {
            get { return _role; }
            set { _role = value; }
        }

        public DateTime Date { get; set; } = DateTime.Now;



    }