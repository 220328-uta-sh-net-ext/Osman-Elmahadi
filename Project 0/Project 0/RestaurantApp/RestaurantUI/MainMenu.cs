namespace RestaurantUI;
public class MainMenu : IMenu
{
    private IBL _bl;

    public MainMenu(IBL bl)
    {
        _bl = bl;
    }

    public MainMenu()
    {
    }

    public void Start()
    {
        Console.WriteLine("Welcome to Restaurant Reviews!");
        Console.WriteLine("Please choose to login or create a user.");
        Console.WriteLine("Press <4> SearchRestaurant menu to the user");
        Console.WriteLine("Press <3> AddRestaurant Menu to the user");
        Console.WriteLine("Press <2> all Restaurants to the user");
        Console.WriteLine("Press <1> Main menu to the user");
        Console.WriteLine("Press <0> Exit");
    }

   
    public string UserChoice()
    {
        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "0":
                return "Exit";
            case "1":
                return "Main menu to the user";
            case "2":
                return "all Restaurants to the user";
            case "3":
                return "AddRestaurant Menu to the user";
            case "4":
                return "SearchRestaurant menu to the user";
            default:
                Console.WriteLine("Please input a valid response");
                Console.WriteLine("Please press <enter> to continue");
                Console.ReadLine();
                return "MainMenu";
        }
    }

    public void Display()
    {
        Console.WriteLine("Welcome to Restaurant Reviews!");
        Console.WriteLine("Please choose to login or create a user.");
        Console.WriteLine("Press <4> SearchRestaurant menu to the user");
        Console.WriteLine("Press <3> AddRestaurant Menu to the user");
        Console.WriteLine("Press <2> all Restaurants to the user");
        Console.WriteLine("Press <1> Main menu to the user");
        Console.WriteLine("Press <0> Exit");
    }
}



    

