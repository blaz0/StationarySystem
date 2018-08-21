using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationarySystem
{
    class Login
    {
        //variables
        public string Username { get; set; }
        public string Password { get; set; }

        //initialise
        public Login(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        //validate username
        private bool validUsername(string input)
        {
            string pattern = "Regina";
            if( input == pattern)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
