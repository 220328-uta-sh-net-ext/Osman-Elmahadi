using RestaurantDL;

namespace RestaurantUI;
public static class MenuFactory
{
    public static IMenu GetMenu(string menuString)
    {
        menuString = menuString.ToLower();

        IRepo repo = new FileRepo();
        IBL bl = new RRBL(repo);

        switch (menuString)
        {
            case "main":
                return new MainMenu(bl);

            case "restaurant":
                return new RestaurantMenu(bl);

            case "review":
                return new ReviewMenu(bl);

            default:
                return new MainMenu(bl);
        }
    }
}