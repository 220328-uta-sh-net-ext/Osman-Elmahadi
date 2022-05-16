using Microsoft.Data.SqlClient;
using RestaurantModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantModels;
using System.Data;

namespace RestaurantDL
{

    public class SqlRepository : IRepo
    {
        /// <summary>
        /// This is referencing the connection string from program.cs
        /// which is referencing the connection string from the .txt file.
        /// </summary>
        readonly string connectionString;
        public SqlRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
          /// <summary>
          /// Implementation for method that returns all restaurants from the database.
          /// </summary>
          /// <returns></returns>
        /*public List<Restaurant> GetAllRestaurantsConnected()
        {
            string commandString = "SELECT * FROM Restaurant;";


            using SqlConnection connection = new(connectionString);

            using IDbCommand command = new SqlCommand(commandString, connection);
            connection.Open();

            using IDataReader reader = command.ExecuteReader();

            var restaurants = new List<Restaurant>();

            while (reader.Read())
            {


                restaurants.Add(new Restaurant
                {

                    Name = reader.GetString(0),
                    Type = reader.GetString(0),
                    City = reader.GetString(2),
                    State = reader.GetString(3),
                    Phone = reader.GetInt32(4),
                    Reviews = reader.GetInt32(5)
                });
            }
            return restaurants;
        }
            /// <summary>
            /// Implementation for the method that adds restaurants to the SQL database on azure.
            /// </summary>
            /// <param name="r"></param>
            /// <returns></returns>*/
        public List<Restaurant> GetAllRestaurants()
        {
            string commandString = "SELECT * FROM Restaurants;";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            //IDataAdapter adapter = new SqlDataAdapter(command);
            //DataSet dataSet = new();
            connection.Open();
            // adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.
            //connection.Close();
            using SqlDataReader reader = command.ExecuteReader();

            var restaurants = new List<Restaurant>();
            //DataColumn levelColumn = dataSet.Tables[0].Columns[1];
            while (reader.Read())
            {
                restaurants.Add(new Restaurant
                {
                    Name = reader.GetString(0),
                    Reviews = reader.GetString(1),
                    City = reader.GetString(2),
                    State = reader.GetString(3),
                    Rating = reader.GetInt32(4)
                });
            }
            return restaurants;
        }
        /// <summary>
        /// Implementation for the method that adds restaurants to the SQL database on azure.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public Restaurant AddRestaurant(Restaurant rest)
        {
            string commandString = "INSERT INTO Restaurants (Name, Reviews, City, State, Rating)" +
                "VALUES (@name, @reviews, @city, @state, @rating);";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@name", rest.Name);
            command.Parameters.AddWithValue("@reviews", rest.Reviews);
            command.Parameters.AddWithValue("@city", rest.City);
            command.Parameters.AddWithValue("@state", rest.State);
            command.Parameters.AddWithValue("@rating", rest.Rating);
            connection.Open();
            command.ExecuteNonQuery();

            return rest;
        }

        public User AddUser(User u)
        {
            throw new NotImplementedException();
        }

        public List<User>? GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<List<Restaurant>> GetAllRestaurantsAsync()
        {
            throw new NotImplementedException();
        }
    }

}
