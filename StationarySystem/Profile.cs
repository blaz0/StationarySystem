using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationarySystem
{
    class Profile
    {
        private int userID;
        private String firstName;
        private String lastName;
        private string username;
        private string emailAddress;
        private string phoneNumber;
        private string costCentre;

        public Profile(int userID, string firstName, string lastName, string username, string emailAddress, string costCentre)
        {
            this.userID = userID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.emailAddress = emailAddress;
            this.costCentre = costCentre;
        }

        public bool IsUser(string staffID)
        {
            if (username == staffID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getUserID()
        {
            return this.userID;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public string getUsername()
        {
            return this.username;
        }

        public string getEmailAddress()
        {
            return this.emailAddress;
        }

        public string getCostCentre()
        {
            return this.costCentre;
        }
    }
}
