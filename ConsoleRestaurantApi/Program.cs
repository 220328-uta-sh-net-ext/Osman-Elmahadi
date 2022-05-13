using ConsoleRestaurantApi;
using System.Net.Http;
using System.Net.Http.Headers;

using var client = new HttpClient();
client.BaseAddress = new Uri("http://localhost:5087/api/restaurant");

var response.wait();
