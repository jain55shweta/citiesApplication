using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Models
{
    public class MailDto
    {
        public MailDto(string subject, string message, string mailTo, string mailFrom)
        {
            this.Subject = subject;
            this.Message = message;
            _mailTo = mailTo;
            _mailFrom = mailFrom;
        }

        public string Subject { set; get; }
        public string Message { set; get; }
        public string _mailTo { set; get; }
        public string _mailFrom { set; get; }
    }
}
