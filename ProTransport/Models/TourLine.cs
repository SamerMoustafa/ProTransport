using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTransport.Models
{
    [Table("tours_lines")]
    class TourLine
    {
        [Key]
        public int Id { get; set; }
        public int From { get; set; }
        public int To { get; set; }
    }
}
