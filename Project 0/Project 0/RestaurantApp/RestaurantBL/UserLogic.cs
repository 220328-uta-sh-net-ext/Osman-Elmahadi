using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBL
{
    public class UserLogic : IUserLogic
    {
        
        readonly IRepo repo;

        public UserLogic(IRepo repo)
        {
            this.repo = repo;
        }

        public User AddUser(User u)
        {
            //var random = new Random();
            //process data to meet conditions
            //It will either substract or add a range from -5 to 5
            // r.Name = random.Next(-5, 5);
            //r.Rating = random.Next(-5, 5);
            // r.Note = "";
            return repo.AddUser(u);

        }

        public List<User> SearchUser(string name, string n)
        {
            List<User>? users = repo.GetAllUsers();
            
            var filteredUsers = users.Where(u => u.Email.Contains(name)).ToList();
            if (n == "name")
                filteredUsers = users.Where(u => u.Name.Contains(name)).ToList();
            else if (n == "Email")
                filteredUsers = users.Where(u => u.Email.Contains(name)).ToList();
            
            // Method Syntax


            return filteredUsers;

        }

    }

 }
