using RestaurantUI;
using Serilog;

//MenuFactory.GetMenu("main").Start();
bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "SearchRestaurant":
            //call Search Restaurant method
            Log.Debug("Displaying SearchRestaurant menu to the user");
            menu = new SearchRestaurantMenu();
            break;
        case "AddRestaurant":
            Log.Debug("Displaying AddRestaurant Menu to the user");
            menu = new AddRestaurantMenu();
            break;
        case "GetAllRestaurants":
            Log.Debug("Displaying all Restaurants to the user");
            Console.WriteLine("--------------Retreiving all Restaurants---------------");
            RRBL.GetAllRestaurant();
            break;
        case "MainMenu":
            Log.Debug("Displaying Main menu to the user");
            menu=new MainMenu();
            break;
        case "Exit":
            Log.Debug("Exiting the application");
            Log.CloseAndFlush();
            repeat = false;
            break;
        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}