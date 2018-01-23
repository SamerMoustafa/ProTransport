using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D

namespace ProTransport.Models
{
    class Bank
    {
        [Key]
        public int  Id  {get; set;}
        public string Name {get; set;}
        public string  Address{get; set;}
        public string Phone{get; set;}
        public string Mail{get; set;}
    }
}
