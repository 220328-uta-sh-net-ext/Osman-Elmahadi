using RestaurantDL;
using RestaurantModels;

namespace RestaurantUI;

class RestaurantOperations
{
    readonly IRepo repository;

    public RestaurantOperations(IRepo repository)
    {
        this.repository = repository;
    }

    public void GetAllRestaurants()
    {
        List<Restaurant>? restaurants = repository.GetAllRestaurants();
        foreach (Restaurant? rest in restaurants)
        {
            Console.WriteLine(rest);
            Console.WriteLine("=======================");
        }
    }
    /// <summary>
    /// only for testing purpose to check if restaurant was added
    /// </summary>
    public void AddDummyRestaurant()
    {
        var restaurant1 = new Restaurant()
        {
            Name = "Subway",
            City = "Houston",
            State = "TX",
            Reviews = 4,
            RestaurantReviews = new List<RestaurantReviews>() {
                new RestaurantReviews()
            {
                    Rating = 5,
                    Note = "friendly owner"
            }
        }
     };
        

    repository.AddRestaurant(restaurant1);
    }

}