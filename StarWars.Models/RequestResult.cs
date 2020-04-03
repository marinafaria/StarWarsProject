using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Models
{
    public class RequestResult
    {
        public int Count { get; set; }
        public string Previous { get; set; }
        public string Next { get; set; }
        public List<People> Results { get; set; }
    }
}
