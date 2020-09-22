using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BecareAPI.Models
{
    public class Local
    {
        public Local(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
