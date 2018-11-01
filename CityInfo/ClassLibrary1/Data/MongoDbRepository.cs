using System.Collections.Generic;
using CityInfo.Entity;
using CityInfo.Models;

namespace CityInfo.service
{
    public class MongoDbRepository:IDataRepository
    {
        private readonly Context _context = null;
        public MongoDbRepository()
        {
          //  _context = new Context(settings);
        }

        public void Save(MailDto data)
        {
            var entity = new Mails(data.Subject, data.Subject, data._mailFrom, data._mailTo);
           // _context.Mails.InsertOne(entity);
        }
        
        public List<Mails> GetAll()
        {
            //  return _context.Mails.Find(_=>true).ToList();
            List<Mails> mail = new List<Mails> { };
            return mail;
        }
    }
}

