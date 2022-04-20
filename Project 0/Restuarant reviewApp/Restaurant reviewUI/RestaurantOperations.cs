using Restaurant_reviewDL;


namespace RestaurantReviewUI
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
