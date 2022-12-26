using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pipool.Models
{
    public class Car
    {
        public ObjectId carid { get; set; }
        public string Brand { get; set; }
        public string carplatenumber { get; set; }
        public string color { get; set; }
        
        public int maxpersone { get; set; }
        public int year { get; set; }
        
        
    }
    public class CarDTO
    {
       public string Brand { get; set; }
        public String type { get; set; }
        public string carplatenumber { get; set; }
        public string color { get; set; }

        public int maxpersone { get; set; }
        public int year { get; set; }
        public string Userid { get; set; }

    }
}
