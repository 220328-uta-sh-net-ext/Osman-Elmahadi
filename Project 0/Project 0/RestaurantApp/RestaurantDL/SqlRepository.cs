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

        readonly string connectionString;

        public SqlRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<Restaurant> GetAllRestaurantsConnected()
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

        public List<Restaurant> GetAllRestaurants()
        {
            string commandString = "SELECT * FROM Restaurant;";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            connection.Open();
            adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.
            connection.Close();

            var restaurants = new List<Restaurant>();
            DataColumn levelColumn = dataSet.Tables[0].Columns[2];
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                restaurants.Add(new Restaurant
                {
                    Name = (string)row[0],
                    Type = (string)row[0],
                    City = (string)row[levelColumn],
                    State = (string)row["Attack"],
                    Phone = (int)row[4],
                    Reviews = (int)row[5]
                });
            }
            return restaurants;
        }

        public Restaurant AddRestaurant(Restaurant rest)
        {
            string commandString = "INSERT INTO Restaurant (Name, Type, City, State, Phone, Reviews) " +
                "VALUES (@name, @type, @city, @state, @phone, @reviews);";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@name", rest.Name);
            command.Parameters.AddWithValue("@type", rest.Type);
            command.Parameters.AddWithValue("@city", rest.City);
            command.Parameters.AddWithValue("@state", rest.State);
            command.Parameters.AddWithValue("@phone", rest.Phone);
            command.Parameters.AddWithValue("@reviews", rest.Reviews);
            connection.Open();
            command.ExecuteNonQuery();

            return rest;
        }

        /// <summary>
        /// asdfasdf
        /// </summary>
        /// <param name="rest">the pokemon model to add</param>
        /// <returns>the added pokemon</returns>
        public Restaurant AddRestaurantUnsafe(Restaurant rest)
        {
            string commandString = "INSERT INTO Restaurant (Name, Type, City, State, Phone, Reviews) " +
               "VALUES (@name, @type, @city, @state, @phone, @reviews);";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);

            connection.Open();
            command.ExecuteNonQuery();

            return rest;
        }

        public RestaurantReviews AddReview(int restaurantId, RestaurantReviews reviewToAdd)
        {
            throw new NotImplementedException();
        }
    }
}