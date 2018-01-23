using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTransport.Models
{
    class Driver
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }
        public int Locked { get; set; }
        public int FavouriteCar { get; set; }

    }
}
