using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Planets.Models
{
    public class Planet
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageFileName { get; set; }

        /// <summary>
        /// in 10⁶ km
        /// </summary>
        public double DistanceFromSun { get; set; }

        /// <summary>
        /// in 10²⁴ kg
        /// </summary>
        public double Mass { get; set; }

        /// <summary>
        /// in km
        /// </summary>
        public int Diameter { get; set; }

        /// <summary>
        /// in m/s²
        /// </summary>
        public double Gravity { get; set; }

        /// <summary>
        /// in hours
        /// </summary>
        public double LengthOfDay { get; set; }
    }
}