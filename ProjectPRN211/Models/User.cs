using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN211.Models
{
    internal class User
    {

        public string Username { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Password { set; get; }
        public string Email { set; get; }
        public DateTime CreatedDate { set; get; }
        public int Role { set; get; }

        public User(string username, string firstName, string lastName, string password, string email, DateTime createdDate, int role)
        {
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Email = email;
            CreatedDate = createdDate;
            Role = role;
        }
    }
}
