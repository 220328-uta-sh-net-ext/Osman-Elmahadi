using CustomExceptions;
using RestaurantDL;
using RestaurantModels;

namespace RestaurantBL;
public class RestaurantLogic : IRestaurantLogic
{
   
    readonly IRepo repo;

    public RestaurantLogic(IRepo repo)
    {
        this.repo = repo;
    }

    public Restaurant AddRestaurant(Restaurant r)
    {
       
        return repo.AddRestaurant(r);

    }

    public List<Restaurant> SearchRestaurant(string name,string n)
    {
        List<Restaurant>? restaurants = repo.GetAllRestaurants();
        /*var filteredPokemons=from r in restaurants               //Query Syntax
                                where r.Name.Contains(name)
                                select r;*/
        var filteredRestaurants = restaurants.Where(r => r.City.Contains(name)).ToList();
        if(n == "name")
        filteredRestaurants = restaurants.Where(r => r.Name.Contains(name)).ToList();
       else if (n == "state")
        filteredRestaurants = restaurants.Where(r => r.State.Contains(name)).ToList();
        else if (n == "city")
            filteredRestaurants = restaurants.Where(r => r.City.Contains(name)).ToList();
        // Method Syntax

     
        return filteredRestaurants;

    }

}

public interface IRestaurantBL
{
}