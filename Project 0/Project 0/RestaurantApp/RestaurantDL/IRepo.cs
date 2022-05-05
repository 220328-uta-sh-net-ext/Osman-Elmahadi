using RestaurantModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDL
{
    public interface IRepo
    {
        /// <summary>
        /// Adds a resturant to the database
        /// </summary>
        /// <param name="rest"></param>
        /// <returns></returns>
        Restaurant AddRestaurant(Restaurant rest);
        /// <summary>
        /// The method returns all restaurants from the database
        /// </summary>
        /// <returns></returns>
        List<Restaurant> GetAllRestaurants();
        User AddUser(User u);
        List<User>? GetAllUsers();
    }
}