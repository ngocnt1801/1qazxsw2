using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.Models
{
    public class User
    {
      

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Gender { get; set; }
        public int Role { get; set; }
        public DateTime RegisterDate { get; set; }

        public User(string username, string password, string email, string fullname, string address, string phone, int gender, DateTime registerDate)
        {
            Username = username;
            Password = password;
            Email = email;
            Fullname = fullname;
            Address = address;
            Phone = phone;
            Gender = gender;
            RegisterDate = registerDate;
        }

        public User(string username, string email, string fullname, string address, string phone, int gender, int role, DateTime registerDate)
        {
            Username = username;
            Email = email;
            Fullname = fullname;
            Address = address;
            Phone = phone;
            Gender = gender;
            Role = role;
            RegisterDate = registerDate;
        }
    }
}
