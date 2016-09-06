using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
     public class LocationEntry
     {
            public string UserCity { get; set; }
            public string UserState { get; set; }
     }
    
    public class MyWeather
    {
        public int lon { get; set; }
        public string lat { get; set; }
    }

    public class SuperData
    {
        //public string cName { get; set;  }
        public string temp { get; set; }
        public string humidity { get; set; }
        public string rainprob { get; set; }
        public string sunset { get; set; }
    }
}