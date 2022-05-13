using RestaurantModels;

namespace RestaurantBL;
/// <summary>
/// Business Layer is responsible for further validation or processing of data obtained from either the database or the user
/// What kind of processing? That all depends on the type of functionality you will be doing
/// It can also hold any computation logic like calculating average, max or min values etc....
/// </summary>
public interface IRestaurantLogic//:IRestaurantSearch
{
    /// <summary>
    /// Add Restaurant to the database
    /// initial addition of a pokemon will give some sort of a randon stats
    /// Can only have a total of 4 Restaurants in the Database
    /// </summary>
    /// <param name="r"></param>
    /// <returns></returns>
    Restaurant AddRestaurant(Restaurant r);

    /// <summary>
    /// We will give the list of restaurants that are related to searched name
    /// </summary>
    /// <param name="name">This name parameter is used to filter restaurants</param>
    /// <returns>Give the list of filtered Restaurants via name</returns>
    List<Restaurant> SearchRestaurant(string name, string n);

}

/*public interface IRestaurantSearch
{
    /// <summary>
    /// This method returns all the restaurants from the database on Azure Sql. This is an asynchronus method so use await keyword 
    /// </summary>
    /// <returns>List<Restaurants></returns>
    Task<List<Restaurant>> SearchAllAsync();
    List<Restaurant> SearchAll();
}*/