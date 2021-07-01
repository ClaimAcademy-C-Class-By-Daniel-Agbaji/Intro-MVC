using DemoMVC4EF.Data;
using DemoMVC4EF.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DemoMVC4EF.Controllers
{

    [ApiController]
    [Route("restaurantapi/[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public RestaurantController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Restaurant>> GetAllRestaurants()
        {
            var restaurants = _dataContext.TblRestaurant.ToList();

            return restaurants;
        }

        [HttpGet("{id}")]
        public ActionResult<Restaurant> GetRestaurantById(int id)
        {
            var restaurant = _dataContext.TblRestaurant.Find(id);

            return restaurant;
        }

    }
}
