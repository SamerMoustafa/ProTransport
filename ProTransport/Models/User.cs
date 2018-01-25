using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace ProTransport.Models
{
    class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Usename { get; set; }
        public string Paasword { get; set; }
        public string Role { get; set; }
    }
}
