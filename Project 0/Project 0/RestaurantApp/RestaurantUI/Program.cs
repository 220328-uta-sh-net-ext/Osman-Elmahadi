using RestaurantUI;
using Serilog;
using RestaurantBL;
using RestaurantDL;


//create and configure our logger
Log.Logger = new LoggerConfiguration()
    
    .WriteTo.File("./Logs/user.txt").MinimumLevel.Debug().MinimumLevel.Information()// we want to save the ;ogs in this file
    .CreateLogger();

// other approaches to this besides "gitignored file"...
//  - command-line arguments (in this file with top-level statements, invisible "args" variable
//  - environment variab
//string connectionStringFilePath = "../../../../RestaurantDL/connection-string.txt";
string connectionStringFilePath = "../RestaurantDL/connection-string.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);

IRepo repository = new SqlRepository(connectionString);
IRestaurantLogic logic = new RestaurantLogic(repository);
//RestaurantOperations operations = new(repository);

bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
       
        case "Search Restaurant Menu":
            //call Search Restaurant method
            Log.Debug("Displaying Search Restaurant Menu ");
            Console.WriteLine("input <name> <city> <state>");
            //WriteLine(<name> <city> <state>);
            //What you are looking for <name> <city> <state>
            //get user input us using ReadL(); set = k
            string k = "name";
            Console.WriteLine($"input Restaurant {k} here:");
            string n = Console.ReadLine();
            //menu = new SearchRestaurantMenu(logic);
            List<RestaurantModels.Restaurant>? results = logic.SearchRestaurant(n,k);
            if (k == "name")
                results = logic.SearchRestaurant(n, k);
            else if (k == "state")
                results = logic.SearchRestaurant(n, k);
            else if (k == "city")
                results = logic.SearchRestaurant(n, k);
            else Console.WriteLine("Error ...");

            if (results.Count > 0)
            {
                foreach (RestaurantModels.Restaurant? r in results)
                {
                    Console.WriteLine(r.ToString());

                }
            }
            else
                Console.WriteLine("Restaurant Not Found");
            break;
        case "Add Restaurants Menu":
            Log.Debug("Displaying Add Restaurants Menu to the user");
            menu = new AddRestaurantMenu(logic);
            break;
        case "Get All Restaurant ":
            Log.Debug("Displaying Get All Restaurant ");
            Console.WriteLine("--------------Retreiving all restaurants---------------");
            //operations.GetAllRestaurants();
             results = logic.SearchRestaurant("","");
        
            if (results.Count > 0)
            {
                foreach (RestaurantModels.Restaurant? r in results)
                {
                    Console.WriteLine(r.ToString());
                    
                }
            }
            else
                Console.WriteLine("Restaurant Not Found");

           

            break;
        case "Displaying Main menu to the user ":
            Log.Debug("Displaying Main menu to the user ");
            menu = new MainMenu();
            break;
        case "Login":
            Log.Debug("Displaying Login");
            break;
        case "MainMenu":
            menu = new MainMenu();
            Log.Debug("Displaying Login");
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