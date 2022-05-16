using CustomExceptions;
using System.Text.RegularExpressions;
using System.Data;

namespace RestaurantModels;

public class Restaurant
{
    public string Name { get; set; }
    public string Reviews { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int Rating { get; set; }
    public string Note { get; set; }
    public int Phone { get; set; }
    //public string Address { get; set; }

  
    //Default constructor to add default values to the properties
    public Restaurant()
    {
        Name = "?";
        Reviews = "?";
        City = "?";
        State = "?";
        Rating = 0;

    }
    public override string ToString()
    {
        string result = $"Name: {Name}\nReviews: {Reviews}\nCity: {City}\nState: {State}\nRating: {Rating}\n";
      /*  if (RestaurantReviews is not null && RestaurantReviews.Count > 0)
        {
            result += "\nRestaurantReviews: " + string.Join(", ", RestaurantReviews.Select(a => a.Name));
        }*/
        return result;
    }
}
