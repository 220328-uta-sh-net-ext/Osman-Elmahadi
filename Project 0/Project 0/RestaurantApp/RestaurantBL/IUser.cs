using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBL;
/// <summary>
/// Business Layer is responsible for further validation or processing of data obtained from either the database or the user
/// What kind of processing? That all depends on the type of functionality you will be doing
/// It can also hold any computation logic like calculating average, max or min values etc....
/// </summary>
public interface IUserLogic
{
    /// <summary>
    /// Add pokemon to the database
    /// initial addition of a pokemon will give some sort of a randon stats
    /// Can only have a total of 4 pokemons in the Database
    /// </summary>
    /// <param name="r"></param>
    /// <returns></returns>
    User AddUser(User u);

    /// <summary>
    /// We will give the list of restaurants that are related to searched name
    /// </summary>
    /// <param name="name">This name parameter is used to filter restaurants</param>
    /// <returns>Give the list of filtered Restaurants via name</returns>
    List<User> SearchUser(string name, string n);

}
