namespace RestaurantUI;
class MainMenu : IMenu
{
    public void Display()
    {
        Console.WriteLine("Welcome to this Restuarant Application.");
        Console.WriteLine("Please choose to login or create a user.");
        Console.WriteLine("Press <5> Search Restaurant Menu");
        Console.WriteLine("Press <4> Add Restaurants Menu");
        Console.WriteLine("Press <3> Get All Restaurant ");
        //Console.WriteLine("Press <2> Do something else here like add user");
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
           // case "2":
                //return "Displaying Main menu to the user";
            case "3":
                return "Get All Restaurant ";
            case "4":
                return "Add Restaurants Menu";
            case "5":
                return "Search Restaurant Menu";
            case "6":
                return "user";
            default:
                Console.WriteLine("Please input a valid response");
                Console.WriteLine("Please press <enter> to continue");
                Console.ReadLine();
                return "MainMenu";

        }
    }
}





    

