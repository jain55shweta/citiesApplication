using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.service;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Controllers
{
    [Route("api/cities/poi")]
    public class PointsOfInterestController : Controller
    {
        [HttpGet("{cityId}")]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
            {
                return NotFound();
            }
            return new JsonResult(city.PointsOfInterest);
        }

        [HttpDelete("{cityId}/{id}")]
        public IActionResult DeletePointsOfInterest(int cityId,int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
            {
                return NotFound();
            }
            var pointOfInterestFromDataStore = city.PointsOfInterest.FirstOrDefault(c => c.Id == id);
            if (pointOfInterestFromDataStore == null)
            {
                return NotFound();
            }
            var prfevCount = city.PointsOfInterest.Count;
            var x=city.PointsOfInterest.Remove(pointOfInterestFromDataStore);
            var postCount = city.PointsOfInterest.Count;

            IDataRepository database= new MongoDbRepository();
            var mailingService = new SendingMail(database);
            mailingService.Send("deleted pointsOfInterest",
                $"pointOfInterest {pointOfInterestFromDataStore.Name} with id {pointOfInterestFromDataStore.Id} Was deleted.",
                "jain55shweta@gmail.com",
                "jain99shwe@gmailcom");

            return new JsonResult(pointOfInterestFromDataStore);
        }
    }
}