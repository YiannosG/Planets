using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Planets.Models;

namespace Planets.Services
{
    /// <summary>
    /// Repository for objects of type Planet
    /// </summary>
    public class PlanetRepository : IPlanetRepository
    {
        public Planet[] GetAllPlanets()
        {
            return new Planet[]
            {
                new Planet
                {
                    Id = 1,
                    Name = "Mercury",
                    ImageFileName = "/Images/mercury.jpg",
                    Diameter = 4879,
                    DistanceFromSun = 57.9,
                    Mass = 0.330,
                    Gravity = 3.7,
                    LengthOfDay = 4222.6
                },
                new Planet
                {
                    Id = 2,
                    Name = "Venus",
                    ImageFileName = "/Images/venus.jpg",
                    Diameter = 12104,
                    DistanceFromSun = 108.2,
                    Mass = 4.87,
                    Gravity = 8.9,
                    LengthOfDay = 2802
                },
                new Planet
                {
                    Id = 3,
                    Name = "Earth",
                    ImageFileName = "/Images/earth.jpg",
                    Diameter = 12756,
                    DistanceFromSun = 149.6,
                    Mass = 5.97,
                    Gravity = 9.8,
                    LengthOfDay = 24
                },
                new Planet
                {
                    Id = 4,
                    Name = "Mars",
                    ImageFileName = "/Images/mars.jpg",
                    Diameter = 6792,
                    DistanceFromSun = 227.9,
                    Mass = 0.642,
                    Gravity = 3.7,
                    LengthOfDay = 24.7
                },
                new Planet
                {
                    Id = 5,
                    Name = "Jupiter",
                    ImageFileName = "/Images/jupiter.jpg",
                    Diameter = 142984,
                    DistanceFromSun = 778.6,
                    Mass = 1898,
                    Gravity = 23.1,
                    LengthOfDay = 9.9
                },
                new Planet
                {
                    Id = 6,
                    Name = "Saturn",
                    ImageFileName = "/Images/saturn.jpg",
                    Diameter = 120536,
                    DistanceFromSun = 1433.5,
                    Mass = 568,
                    Gravity = 9,
                    LengthOfDay = 10.7
                },
                new Planet
                {
                    Id = 7,
                    Name = "Uranus",
                    ImageFileName = "/Images/uranus.jpg",
                    Diameter = 51118,
                    DistanceFromSun = 2872.5,
                    Mass = 86.8,
                    Gravity = 8.7,
                    LengthOfDay = 17.2
                },
                new Planet
                {
                    Id = 8,
                    Name = "Neptune",
                    ImageFileName = "/Images/neptune.jpg",
                    Diameter = 49528,
                    DistanceFromSun = 4495.1,
                    Mass = 102,
                    Gravity = 11,
                    LengthOfDay = 16.1
                },
                new Planet
                {
                    Id = 9,
                    Name = "Pluto",
                    ImageFileName = "/Images/pluto.jpg",
                    Diameter = 2370,
                    DistanceFromSun = 5906.4,
                    Mass = 0.0146,
                    Gravity = 0.7,
                    LengthOfDay = 153.3
                }
            }; // end of planet array
        } // end of GetAllPlanets()

        public Planet GetPlanet(int planetId)
        {
            return GetAllPlanets().FirstOrDefault(x => x.Id == planetId);
        }
    }
}