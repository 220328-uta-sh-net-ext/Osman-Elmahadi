using System.Collections.Generic;
using Restaurant_reviewModels;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_reviewDL
{
    public interface IRepository
    {
        /// <summary>
        /// Add RestaurantReview to the database
        /// </summary>
        /// <param name="resta"></param>
        /// <returns>The RestaurantReview added</returns>
       RestaurantReview AddRestaurantReview(RestaurantReview resta);
        /// <summary>
        /// This method return all the RestaurantReviews from the database
        /// </summary>
        /// <returns>Returns a collection of RestaurentReview as Generic List</returns>
        List<RestaurantReview> GetAllRestaurants();
        
    }
}
