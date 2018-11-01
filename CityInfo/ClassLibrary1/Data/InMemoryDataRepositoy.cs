using CityInfo.Entity;
using CityInfo.Models;
using CityInfo.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Data
{
    public class InMemoryDataRepositoy:IDataRepository
    {
        public static InMemoryDataRepositoy Current { get; } = new InMemoryDataRepositoy();
        public List<MailDto> mails { set; get; }

        public InMemoryDataRepositoy()
        {
            mails = new List<MailDto>()
            {
               
            };

        }

        public int Count()
        {
            return mails.Count;
        }
        public List<Mails> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(MailDto data)
        {
            //throw new NotImplementedException();
            mails.Add(data);
        }
        //public MailDto Add(MailDto mail)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
