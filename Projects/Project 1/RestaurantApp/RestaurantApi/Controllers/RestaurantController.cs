using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantModels;
using RestaurantBL;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Memory;

namespace RestaurantApi.Controllers
{
    //Routes are used to configure the endpoints of the api, we can keep it predefined as in the standard or even customized it
    [Route("api/[controller]")]
    //anything in the [] is known as decorator/attribute : its like processing the before the class or method
    [ApiController]

    public class RestaurantController : ControllerBase// Controller base class has the logic to interact with HTTP and communication with client
    {
        private IRestaurantLogic _restBL;
        private IMemoryCache memoryCache;
        public RestaurantController(IRestaurantLogic _restBL, IMemoryCache memoryCache)
          {
           this._restBL = _restBL;
            this.memoryCache = memoryCache;
          }



        private static List<Restaurant> _restaurants = new List<Restaurant> {
            new Restaurant{ Name="Salt n Straw", Reviews = "", City = "Portland", State = "OR", Rating = 1},
            new Restaurant{ Name="Subway", Reviews = "", City = "Houston", State = "TX", Rating = 2}
             };
        [HttpGet]//http method
        [ProducesResponseType(200, Type=typeof(List<Restaurant>))]
        public ActionResult<List<Restaurant>> Get()
        { 
            List<Restaurant> restaurants = new List<Restaurant>();
            try
            {
            
                if (!memoryCache.TryGetValue("restList", out restaurants))
                {
                    restaurants = _restBL.SearchAll();
                    memoryCache.Set("restList", restaurants, new TimeSpan(0, 1, 0));
                }
            }
            catch (SqlException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex) { 
                return BadRequest(ex.Message);
            }
                return Ok(restaurants);
        }
        //Action Methods : ways to access or manipulate the resources, it uses the HTTP Verbs/methods (GET, PUT, POST, DELETE, PATCH, HEAD etc....)
        [HttpGet("name")]//http method
        [ProducesResponseType(200, Type = typeof(Restaurant))]
        [ProducesResponseType(404)]
        public ActionResult<Restaurant> Get(string name)// primitive type so model binder will look for these values as querystring
        {
            var rest = _restBL.SearchRestaurant(name, name);
            if (rest.Count<=0)
                return NotFound($"Restaurant {name} you are looking for is not in the database");
            return Ok(rest);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] Restaurant rest)// Complex type so model binder will look for these values from request body
        {
            if (rest == null)
                return BadRequest("Invalid restaurant, please try again with valid values");
            _restBL.AddRestaurant(rest);
            return CreatedAtAction("Get",rest);
        }

        [HttpPut]
        public ActionResult Put([FromBody] Restaurant rest, [FromQuery] string name) //non-Default
        {
            if (name == null)
                return BadRequest("Cannot modify pokemon without name");
            try
            {
                var restaurant = _restaurants.Find(x => x.Name.Contains(name));
                if (restaurant == null)
                    return NotFound("Restaurant not found");
                restaurant.Name = rest.Name;
                restaurant.Reviews = rest.Reviews;
                restaurant.City = rest.City;
                restaurant.State = rest.State;
                restaurant.Rating = rest.Rating;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Created("Get", rest);
        }
        [HttpDelete]
        public ActionResult Delete(string name)
        {
            if (name == null)
                return BadRequest("Cannot modify restaurant without name");
            var restaurant = _restaurants.Find(x => x.Name.Contains(name));
            if (restaurant == null)
                return NotFound("Restaurant not found");
            _restaurants.Remove(restaurant);
            return Ok($"Restaurant {name} Deleted");
        }
    }
}
  