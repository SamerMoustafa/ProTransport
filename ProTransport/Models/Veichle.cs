using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTransport.Models
{
    class Veichle
    {
        [Key]
        public int Id { get; set; }
        public String Brand { get; set; }
        public String Type { get; set; }
        public String ChaceeId { get; set; }
        public String PlateId { get; set; }
        public String GPS_Serial { get; set; }
    }
}
