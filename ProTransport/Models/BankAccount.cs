using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace ProTransport.Models
{
    class BankAccount
    {
        [Key]
        public int Id { get; set; }
        public int BankId { get; set; }
        public string Holder { get; set; }
        public string Le { get; set; }
        public string Usd { get; set; }
        public string Euro { get; set; }
    }
}
