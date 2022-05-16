using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModels
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public User()
        {
            Name = "UserName";
            Email = "Email";
            Password = "Password";
        }
        public override string ToString()
        {
            return $"Restaurant Name: {Name}\nAddress: {Email}\nPhone Number: {Password}\n";
        }

    }
}