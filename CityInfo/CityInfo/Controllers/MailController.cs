using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.Entity;
using CityInfo.service;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace CityInfo.Controllers
{
    [Route("api/mail")]
    public class MailController : Controller
    {
        private IMongoDatabase _database;
        public IMongoCollection<Mails> Mails
        {
            get
            {
                return _database.GetCollection<Mails>("mails");
            }
        }

        public MailController()
        {
            
            var client = new MongoClient("mongodb://18.217.33.184:27017");
            if (client != null)
            {
                _database = client.GetDatabase("test");
            }

        }

        [HttpGet]
        public IActionResult Get()
        {

          // var data= _mailservice.Receive();

            return new JsonResult(Mails.Find(_ => true).ToList());
        }
    }
}