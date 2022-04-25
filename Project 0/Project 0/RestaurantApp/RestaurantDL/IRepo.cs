namespace RestaurantDL;
public interface IRepo
{
    List<Restaurant> GetAllRestaurants();

    void AddRestaurant(Restaurant restaurantToAdd);

    void AddReview(int restaurantId, Review reviewToAdd);

    List<Restaurant> SearchRestaurants(string searchTerm);

    bool IsDuplicate(Restaurant restaurant);
}

