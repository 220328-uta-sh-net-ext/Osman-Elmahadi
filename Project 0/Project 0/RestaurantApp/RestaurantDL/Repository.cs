using RestaurantModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using RestaurantModels;

namespace RestaurantDL;

public class Repository : IRepo
{
    readonly string filePath = "../../../../RestaurantDL/Database/";
    string? jsonString;
    public Restaurant AddRestaurant(Restaurant rest)//Serialization
    {
        List<Restaurant>? restaurants = GetAllRestaurants();
        restaurants.Add(rest);
        string? restaurantString = JsonSerializer.Serialize<List<Restaurant>>(restaurants, new JsonSerializerOptions { WriteIndented = true });
        try
        {
            File.WriteAllText(filePath + "Restaurant.json", restaurantString);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("Please check the path, " + ex.Message);
        }
        catch (FileNotFoundException ex)
{
    Console.WriteLine("Please check the file name, " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
return rest;
    }

    public RestaurantReviews AddReview(int restaurantId, RestaurantReviews reviewToAdd)
    {
        throw new NotImplementedException();
    }

    public List<Restaurant> GetAllRestaurants()// Deserialization
{
    try
    {
        jsonString = File.ReadAllText(filePath + "Restaurant.json");
    }
    catch (DirectoryNotFoundException ex)
    {
        Console.WriteLine("Please check the path, " + ex.Message);
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine("Please check the file name, " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    if (!string.IsNullOrEmpty(jsonString))
        return JsonSerializer.Deserialize<List<Restaurant>>(jsonString)!;
    throw new InvalidDataException("json data missing or invalid");
}
}