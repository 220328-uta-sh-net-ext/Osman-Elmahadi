using ConsoleRestaurantApi;
using System.Net.Http;
using System.Net.Http.Headers;

using var client = new HttpClient();
client.BaseAddress = new Uri("http://localhost:5087/api/restaurant");

try{
var response=client.GetAsync("restaurant");
response.Wait();

var result = response.Result;

if(result.IsSuccessStatusCode){
    var readTask=result.Content.ReadAsAsync<List<Restaurant>>();
    readTask.Wait();

    var restaurants = readTask.Result;
    foreach (var r in restaurants)
    {
        Console.WriteLine(r.Name);
    }
    
}
}
catch(System.Net.Http.HttpRequestException ex){
    Console.WriteLine(ex.Message);
}
catch(Exception ex){
    Console.WriteLine(ex.Message);
}
