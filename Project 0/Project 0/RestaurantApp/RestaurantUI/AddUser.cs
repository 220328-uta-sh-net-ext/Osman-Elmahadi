using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI;

class AddUserMenu : IMenuUser
{
    static readonly User newUser = new();

    readonly IUserLogic logic;

    public AddUserMenu(IUserLogic logic)
    {
        this.logic = logic;
    }

    public void Display()
    {
        Console.WriteLine("Enter User Information");
        Console.WriteLine("<4> Name - " + newUser.Name);
        Console.WriteLine("<3> Email - " + newUser.Email);
        Console.WriteLine("<2> Password - " + newUser.Password);
        Console.WriteLine("<1> Save");
        Console.WriteLine("<0> Go Back");
    }
    public string UserChoice()
    {
        if (Console.ReadLine() is not string userInput)
            throw new InvalidDataException("end of input");
        switch (userInput)
        {
            case "0":
                return "MainMenuUser";
            case "1":
                newUser.Email = "";
                newUser.Password = "";
                try
                {

                    Log.Information("Adding a user - " + newUser.Name);
                    logic.AddUser(newUser);
                    Log.Information("User added successfully");
                }
                catch (Exception ex)
                {
                    Log.Warning("failed to add user");
                    Console.WriteLine(ex.Message);

                }
                return "MainMenuUser";
            case "2":
                Console.Write("Please enter address int ");
                newUser.Email = Console.ReadLine();
                return "AddUser";
            case "3":
                Console.Write("Please enter phone string ");
                newUser.Password = Console.ReadLine();
                return "AddRestaurant";
            case "4":
                Console.Write("Please enter a name! string");
                newUser.Name = Console.ReadLine();
                return "AddRestaurant";
        
            
            /// Add more cases for any other attributes of Restaurant
            default:
                Console.WriteLine("Please input a valid response");
                Console.WriteLine("Please press Enter to continue");
                Console.ReadLine();
                return "AddUser";
        }
    }
}
