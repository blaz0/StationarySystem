using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationarySystem
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNo { get; set; }
        public string CostCentre { get; set; }
        public string Nickname { get; set; }
        public string Fullname { get { return FirstName + " " + LastName; } }
        public int RoleId { get; set; }

        public User()
        { }

        public User(int id, string firstName, string lastName, int username, string password, string emailAddress, string phoneNo, string costCentre, string nickname, int roleId)
        {
            this.UserId = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Username = username;
            this.Password = password;
            this.EmailAddress = emailAddress;
            this.PhoneNo = phoneNo;
            this.CostCentre = costCentre;
            this.Nickname = nickname;
            this.RoleId = roleId;
        }
                
        public bool CheckID (int ID)
        {
            if (ID == this.UserId)
                return true;
            else
                return false;
        }
    }
}
