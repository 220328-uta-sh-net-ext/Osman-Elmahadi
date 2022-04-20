using RestaurantReviewUI;
bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
  
        {
            case "Login":
                //call RestaurantLogin method
                Console.WriteLine("RestaurantLogin() Method implementation is in progress\n");
                break;
            case "Display Restaurant":
                //call RestaurantLogin method
                Console.WriteLine("RestaurantDisplay() Method implementation is in progress\n");
                break;
            case "Create Restaurant":
                //call RestaurantLogin method
                Console.WriteLine("RestaurantCreate() Method implementation is in progress\n");
                break;
            case "Create User":
                //call RestaurantLogin method
                Console.WriteLine("RestaurantUser() Method implementation is in progress\n");
                break;
            case "Exit":
                repeat = false;
                break;
            default:
                Console.WriteLine("View does not exist");
                Console.WriteLine("Please press <enter> to continue");
                Console.ReadLine();
                break;
        }
    }           