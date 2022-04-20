﻿namespace Restaurant_reviewModels
{
    
    public class RestaurantReview
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int AverageRating { get; set; }

        //Resturant has a name, Adress, Rating 

        private List<Restaurant> _reviews;
        public List<Restaurant> Reviews
        {
            get { return _reviews; }

            set
            {
                if (value.Count <= 5)
                    _reviews = value;
                else
                    throw new Exception("Rating can not larger that 5.");
            }
        }

        public RestaurantReview()
        {
            Name = "Leena Deli";
            Address = " 1370 Afton St";
            AverageRating = 0;

        }
        public override string ToString()
        {
            return $"Name: {Name}\nAddress: {Address}\nAverage Rating: {AverageRating}";
        }
    }
}
