namespace ConsoleRestaurantApi
{
    public class Restaurant
{
    public string Name { get; set; }
    public string Reviews { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int Rating { get; set; }
    public string Note { get; set; }
    public int Phone { get; set; }
    }
}


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

    public List<Restaurant> SearchAll()
    {
        throw new NotImplementedException();
    }

    public Task<List<Restaurant>> SearchAllAsync()
    {
        throw new NotImplementedException();
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

    public List<Restaurant> SearchRestaurant(string name)
    {
        throw new NotImplementedException();
    }
}

public interface IRestaurantBL
{
}