using CustomExceptions;
using System.Text.RegularExpressions;
using System.Data;

namespace RestaurantModels;

public class Restaurant
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int Reviews { get; set; }
    public int Rating { get; set; }
    public string Note { get; set; }
    public int Phone { get; set; }
    public string Address { get; set; }

    List<RestaurantReviews> _RestaurantReviews;
    public List<RestaurantReviews> RestaurantReviews
    {
        get => _RestaurantReviews;

        set
        {
            if (value.Count <= 4)
                _RestaurantReviews = value;
            else
                throw new Exception("Restaurant cannot hold more than 3 RestaurantReviews");
        }
    }

    //Default constructor to add default values to the properties
    public Restaurant()
    {
        Name = "?";
        Type = "";
        City = "";
        State = "";
        Phone = 0;
        Reviews = 0;

        _RestaurantReviews = new List<RestaurantReviews>()
        {
            new RestaurantReviews()
        };
    }
    public override string ToString()
    {
        string result = $"Name: {Name}\nType: {Type}\nCity: {City}\nState: {State}\nPhone: {Phone}\nReviews: {Reviews}";
        if (RestaurantReviews is not null && RestaurantReviews.Count > 0)
        {
            result += "\nRestaurantReviews: " + string.Join(", ", RestaurantReviews.Select(a => a.Name));
        }
        return result;
    }
}
