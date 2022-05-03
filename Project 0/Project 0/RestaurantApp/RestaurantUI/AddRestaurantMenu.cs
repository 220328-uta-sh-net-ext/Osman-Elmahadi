using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantDL;
using RestaurantModels;
using Serilog;
using RestaurantBL;

namespace RestaurantUI
{

    class AddRestaurantMenu : IMenu
    {
        static readonly Restaurant newRestaurant = new();

        readonly IRestaurantLogic logic;

        public AddRestaurantMenu(IRestaurantLogic logic)
        {
            this.logic = logic;
        }

        public void Display()
        {
            Console.WriteLine("Enter Restaurant Information");
            Console.WriteLine("<4> Name - " + newRestaurant.Name);
            Console.WriteLine("<3> Phone - " + newRestaurant.Phone);
            Console.WriteLine("<2> Address - " + newRestaurant.Address);
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
                    return "MainMenu";
                case "1":
                    try
                    {
                        Log.Information("Adding a restaurant - " + newRestaurant.Name);
                        logic.AddRestaurant(newRestaurant);
                        Log.Information("Restaurant added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("failed to add restaurant");
                        Console.WriteLine(ex.Message);

                    }
                    return "MainMenu";
                case "2":
                    Console.Write("Please enter address ");
                    newRestaurant.Address = Console.ReadLine();
                    return "AddRestaurant";
                case "3":
                    Console.Write("Please enter phone ");
                    newRestaurant.Phone = Convert.ToInt32(Console.ReadLine());
                    return "AddRestaurant";
                case "4":
                    Console.Write("Please enter a name! ");
                    newRestaurant.Name = Console.ReadLine() is string input ? input :
                        throw new InvalidDataException("end of input");
                    return "AddRestaurant";
                /// Add more cases for any other attributes of Restaurant
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddRestaurant";
            }
        }
    }
 }