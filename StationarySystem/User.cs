using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationarySystem
{

    class User
    {
        private int id;
        private string firstName;
        private string lastName;
        private int username;
        private string password;
        private string emailAddress;
        private string phoneNo;
        private string costCentre;
        private string nickname;
        
        public User(int id, string firstName, string lastName, int username, string password, string emailAddress, string phoneNo, string costCentre, string nickname)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.password = password;
            this.emailAddress = emailAddress;
            this.phoneNo = phoneNo;
            this.costCentre = costCentre;
            this.nickname = nickname;
        }

        public int GetId()
        {
            return id;
        }
        public string GetFirstName()
        {
            return firstName;
        }
        public string GetLastName()
        {
            return lastName;
        }
        public string GetFullName(string firstName, string lastName)
        {
            string fullname = firstName + lastName;
            return fullname;
        }
        public int GetUsername()
        {
            return username;
        }
        public string GetPassword()
        {
            return password;
        }
        public string GetEmailAddress()
        {
            return emailAddress;
        }
        public string GetPhoneNo()
        {
            return phoneNo;
        }
        public string GetCostCentre()
        {
            return costCentre;
        }
        public string GetNickname()
        {
            return nickname;
        }
    }
}
