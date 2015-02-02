using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADAssignment
{
    class User
    {
        public User() { }
        public User(string uID, string pass, Name name, string email, Address address) 
        {
            UserID = uID;
            Password = pass;
            Name = name;
            Email = email;
            Address = address;
        }

        public string UserID { get; set; }
        public string Password { get; set; }
        public Name Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
}
