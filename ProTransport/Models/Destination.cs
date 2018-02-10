﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace ProTransport.Models
{
    class Destination
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
        public string Type { get; set; }
             
    }
}
