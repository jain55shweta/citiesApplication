using CityInfo.Entity;
using CityInfo.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace CityInfo.service
{
    public class SendingMail  
    {
        private IDataRepository _dataRepository;

        public SendingMail(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
            
        }
        public void Send(string subject, string message, string _mailTo, string _mailFrom)
        {
            Debug.WriteLine($"mail from {_mailFrom } to {_mailTo} CloudMailService");
            Debug.WriteLine($"subject {subject}");
            Debug.WriteLine($"message {message}");

            var data = new MailDto(subject, message, _mailTo, _mailFrom);
           
            _dataRepository.Save(data);
        }
        public List<Mails> Receive()
        {
            var mailData = _dataRepository.GetAll();
            return mailData;
        }

        
    }
}
