using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Planets.Interfaces;
using Planets.Models;

namespace Planets.Business
{
    public class PlanetGenerator
    {
        private IPlanetCreation _generator = null;

        public Planet[] GeneratePlanets(PlanetarySystem system, Planet planet)
        {
            PlanetarySystemFactory factory = new PlanetarySystemFactory();
            // Logic to let user decide which system's planet to generate
            // ---> Here <----
            // Hardcoding 0 for Solar for now
            this._generator = factory.GeneratePlanets(0, planet);

             var planets = this._generator.GetAllPlanets(planet);

            return planets;
        }
    }
}