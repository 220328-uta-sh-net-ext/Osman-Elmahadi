using CustomExceptions;

namespace RestaurantModels;

public class RestaurantReviews
{
    public string Name { get; set; }

         int rating;
         public int Rating
    {
        get => rating;
         set
        {

            if (value > 0)
                rating = value;
            else
                throw new Exception("You cannot set PP lowwr that 0!");
        }
    }

    public string Note { get; set; }

}