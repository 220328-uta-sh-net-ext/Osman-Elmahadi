using Restaurant_reviewModels;
using System.Collections.Generic;
using System.IO;





namespace Restaurant_reviewDL
{
    public class Repository : IRepository
    {
        private string filePath = "../Restaurant_reviewDL/Database";
        private string jsonString;

        public void GetAllRestaurants()
        {
            throw new NotImplementedException();
        }

        public RestaurantReview AddRestaurantReview(RestaurantReview resta)
        {
            var restuaurants = GetRestaurantReview();
            restuaurants.Add(resta);
        }

        public List<Repository> GetRestaurantReview()
        {
            try
            {
         jsonString = File.ReadAllText(filePath+"RestaurantReview.json");
        }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Please check the path, " + ex.Message);
            }
            if (!string.IsNullOrEmpty(jsonString))
            {
                return JsonSerializer.Deserialize<List<Repository>>(jsonString);
            }
            else
            {
                return null;
            }
        }


    }
}