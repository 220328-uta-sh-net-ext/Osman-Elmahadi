namespace RestaurantUI;

public class ReviewMenu : IMenu
{
    private readonly IBL _bl;
    public ReviewMenu(IBL bl)
    {
        _bl = bl;
    }

    public void Display()
    {
        throw new NotImplementedException();
    }

    public void Start() { }

    public string UserChoice()
    {
        throw new NotImplementedException();
    }
}