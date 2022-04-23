using Restaurant_reviewDL;
using Restaurant_reviewModels;


namespace Restaurant_reviewUI
{
    internal class DisplayRestaurantOperations
    {
        static Repository repository= new Repository();

        public static void GetAllRestaurants()
        {
             repository.GetAllRestaurants();    
        }
    }
}
