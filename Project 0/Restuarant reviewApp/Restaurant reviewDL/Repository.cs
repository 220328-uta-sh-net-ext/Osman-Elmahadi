using Restaurant_reviewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Restaurant_reviewDL
{
    public class Repository : IRepository
    {
        private string filePath = "../Restaurant_reviewDL/Database/";
        private string jsonString;

        public void GetAllRestaurants()
        {
            throw new NotImplementedException();
        }

        public void AddRestaurantReview(RestaurantReview resta)
        {
            var restuaurants = GetRestaurantReview();
            //restuaurants.Add(resta);
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

        List<RestaurantReview> IRepository.GetAllRestaurants()
        {
            throw new System.NotImplementedException();
        }

        RestaurantReview IRepository.AddRestaurantReview(RestaurantReview resta)
        {
            throw new NotImplementedException();
        }
    }
}