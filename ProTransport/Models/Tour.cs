using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTransport.Models
{
    class Tour
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int DriverId { get; set; }
        public int CarId { get; set; }
        public int ContainersCount { get; set; }
        public String ContainersType { get; set; }
        public int ShippingLine { get; set; }
        public String BillNo { get; set; }
        public String BookingNo { get; set; }
    }
}
