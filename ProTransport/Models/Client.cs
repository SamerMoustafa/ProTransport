using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace ProTransport.Models
{
    class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyMail { get; set; }
        public string AccountantPhone { get; set; }
        public string AccountantMail { get; set; }
    }
}
