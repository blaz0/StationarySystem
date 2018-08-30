using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StationarySystem
{
    class Login
    {
        //Declare Variables
        public string staffid { get; set; }
        public string staffPassword { get; set; }

        //intialise  
        public Login(string id, string password)
        {
            this.staffid = id;
            this.staffPassword = password;
        }

        //clear user inputs 
        private void ClearTexts(string id, string password)
        {
            id = String.Empty;
            password = String.Empty;
        }

        //method to check if eligible to be logged in 
        internal bool isLoggedIn(string id, string password)
        {
            //check user name empty 
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter a valid staffID");
                return false;

            }
            //check user name is correct 
            else
            {
                if (id != staffid)
                {
                    MessageBox.Show("Invalid ID");
                    ClearTexts(id, password);
                    return false;
                }
                //check password is empty 
                else
                {
                    if (string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Please enter the correct password.");
                        return false;
                    }

                    //check password is correct 
                    else if (password != staffPassword)
                    {
                        MessageBox.Show("Password is incorrect.");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}
