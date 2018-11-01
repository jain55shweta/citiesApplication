using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Entity
{
    public class Mails
    {
        private string subject1;
        private string subject2;

        public Mails(string subject1, string subject2, string mailFrom, string mailTo)
        {
            this.subject1 = subject1;
            this.subject2 = subject2;
            _mailFrom = mailFrom;
            _mailTo = mailTo;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Subject { get; set; }
        public String Message { get; set; }
        public string _mailTo { set; get; }
        public string _mailFrom { set; get; }

    }
}
