using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationarySystem
{
    class User
    {
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int username { get; set; }
        public string password { get; set; }
        public string emailAddress { get; set; }
        public string phoneNo { get; set; }
        public string costCentre { get; set; }
        public string nickname { get; set; }
        public string fullname { get { return firstName + " " + lastName; } }
        
        public User()
        { }

        public User(int id, string firstName, string lastName, int username, string password, string emailAddress, string phoneNo, string costCentre, string nickname)
        {
            this.userId = id;
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
            return userId;
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
