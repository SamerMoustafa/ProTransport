using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTransport.Models
{
    [Table("tours_lines_prices")]
    class TourLinePrice
    {
        [Key]
        public int Id { get; set; }
        public int TourLine { get; set; }
        public String Type { get; set; }
        public int Price { get; set; }

    }
}
