/*using RestaurantDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    internal class AddUsercs : IMenu
    {
        private static User NewUser = new User();

        private IRepo _repository = new SqlRepository();
        public void Display()
        {
            Console.WriteLine("Enter Restaurant Information");

            Console.WriteLine("<4> Name - " + NewUser.Name);
            Console.WriteLine("<3> Email - " + NewUser.Email);
            Console.WriteLine("<2> Password - " + NewUser.Password);

            Console.WriteLine("<1> Save");
            Console.WriteLine("<0> Go Back");
        }
        public string UserChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    _repository.AddUser(NewUser);
                    Console.WriteLine("----New Restaurant Added----");
                    return "MainMenu";
                case "2":
                    Console.Write("Please enter a password: ");
                    NewUser.Password = Console.ReadLine();
                    return "Create User";
                case "3":
                    Console.Write("Please enter a email: ");
                    NewUser.Email = Convert.ToString(Console.ReadLine());
                    return "Create User";
                case "4":
                    Console.Write("Please enter a name: ");
                    NewUser.Name = Console.ReadLine();
                    return "Create User";
                /// Add more cases for any other attributes of pokemon
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddUser";
            }
        }
    }
}*/
