using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using CityInfo.service;

namespace CityInfo.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {


        [HttpGet()]
        public IActionResult GetCities()
        {

           return new JsonResult(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (city == null)
            {

                  return NotFound();
            }
            // return OkObjectResult();
            return new JsonResult(city);
        }
    }
}
