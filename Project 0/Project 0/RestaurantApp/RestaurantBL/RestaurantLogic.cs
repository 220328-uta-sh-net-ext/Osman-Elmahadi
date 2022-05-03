using CustomExceptions;
using RestaurantDL;
using RestaurantModels;

namespace RestaurantBL;
public class RestaurantLogic : IRestaurantLogic
{
    const int MaxRestaurants = 4000;
    readonly IRepo repo;

    public RestaurantLogic(IRepo repo)
    {
        this.repo = repo;
    }

    public Restaurant AddRestaurant(Restaurant r)
    {
        var random = new Random();
        //process data to meet conditions
        //It will either substract or add a range from -5 to 5
       // r.Name = random.Next(-5, 5);
        r.Rating = random.Next(-5, 5);
        r.Note = "";

        //Validation process
        List<Restaurant>? restaurants = repo.GetAllRestaurants();
        if (restaurants.Count < MaxRestaurants)
        {
            return repo.AddRestaurant(r);
        }
        else
        {
            throw new Exception("You cannot exceed to add more than 4 restaurants");
        }
    }

    public List<Restaurant> SearchRestaurant(string name)
    {
        List<Restaurant>? restaurants = repo.GetAllRestaurants();
        /*var filteredPokemons=from r in restaurants               //Query Syntax
                                where r.Name.Contains(name)
                                select r;*/

        var filteredRestaurants = restaurants.Where(p => p.Name.Contains(name)).ToList(); // Method Syntax

     
        return filteredRestaurants;

    }

}

public interface IRestaurantBL
{
}