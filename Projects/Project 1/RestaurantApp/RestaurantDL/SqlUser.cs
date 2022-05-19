using Microsoft.Data.SqlClient;
using RestaurantModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RestaurantDL
{

    public class SqlUser : IuserRepo
    {
        /// <summary>
        /// This is referencing the connection string from program.cs
        /// which is referencing the connection string from the .txt file.
        /// </summary>
        readonly string connectionString;
        public SqlUser(string connectionString)
        {
            this.connectionString = connectionString;
        }
        /// <summary>
        /// Implementation for method that returns all restaurants from the database.
        /// </summary>
        /// <returns></returns>
        
        public List<User> GetAllUsers()
        {
            string commandString = "SELECT * FROM _Users;";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            //IDataAdapter adapter = new SqlDataAdapter(command);
            //DataSet dataSet = new();
            connection.Open();
            // adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.
            //connection.Close();
            using SqlDataReader reader = command.ExecuteReader();

            var users = new List<User>();
            //DataColumn levelColumn = dataSet.Tables[0].Columns[1];
            while (reader.Read())
            {
                users.Add(new User
                {
                    Name = reader.GetString(0),
                    Email = reader.GetString(1),
                    Password= reader.GetString(2)
                   
                });
            }
            return users;
        }
        /// <summary>
        /// Implementation for the method that adds restaurants to the SQL database on azure.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public User AddUser(User rest)
        {
            string commandString = "INSERT INTO _User (Name, Email, Password) " +
                "VALUES (@name, @email, @password);";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@name", rest.Name);
            command.Parameters.AddWithValue("@email", rest.Email);
            command.Parameters.AddWithValue("@password", rest.Password);
           
            connection.Open();
            command.ExecuteNonQuery();

            return rest;
        }

    }

}
