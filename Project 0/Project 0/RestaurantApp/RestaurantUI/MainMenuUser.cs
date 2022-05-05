using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI;
class MainMenuUser : IMenuUser
{
    public void Display()
    {
        Console.WriteLine("Welcome to this Restuarant Application.");
        Console.WriteLine("Please choose to login or create a user.");
      
        Console.WriteLine("Press <4> Add User Name");
        Console.WriteLine("Press <3> Email ");
        Console.WriteLine("Press <2> Password");
        Console.WriteLine("Press <1> Login");
        Console.WriteLine("Press <0> Exit");
    }

    public string UserChoice()
    {
        if (Console.ReadLine() is not string userInput)
            throw new InvalidDataException("end of input");

        switch (userInput)
        {
            case "0":
                return "Exit";
            case "1":
                return "Login";
            case "2":
                return "Password";
            case "3":
                return "Email ";
            case "4":
                return "Add User Name";
            
            default:
                Console.WriteLine("Please input a valid response");
                Console.WriteLine("Please press <enter> to continue");
                Console.ReadLine();
                return "MainMenuUser";

        }
    }
}

