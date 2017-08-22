using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using Planets.Business;
using Planets.Models;
using Planets.Services;

// Model too simple to have need of a context here. Would have used a try-catch-finally block to call it
namespace Planets.Controllers
{
    public class PlanetController : ApiController
    {
        PlanetGenerator generator = new PlanetGenerator();
        private IPlanetRepository _repo;
        public PlanetController(IPlanetRepository repo)
        {
            _repo = repo;
        }

        public PlanetController()
        {
            _repo = new PlanetRepository(); // Just use repo
            
        }
        /// <summary>
        /// Gets all planets
        /// </summary>
        /// <returns>An array of Planet objects</returns>
        public Planet[] Get(string system="Solar")
        {
            //return _repo.GetAllPlanets(system);       <-- using just repo
            // using Factory
            PlanetarySystem mySystem;
            switch (system)
            {
                case "Solar":
                    mySystem = new Solar();
                    break;
                // other cases
                default:
                    mySystem = new Cnc55();
                    break;
            }
            var planets = generator.GeneratePlanets(mySystem, new Planet());

            return planets;
        }

        /// <summary>
        /// Returns a single Planet based on Planet ID
        /// </summary>
        /// <param name="id">Id of planet needed</param>
        /// <param name="systemName">System name</param>
        /// <returns>A single Planet</returns>
        public Planet GetPlanet(int id, string systemName="Solar")
        {
            var planet = _repo.GetPlanet(id, systemName);
            
            if (planet == null)
            {
                var message = string.Format("Planet with id = {0} not found", id);
                HttpError err = new HttpError(message);
                Console.Error.WriteLine(err);
                return null;
            }
            else
            {
                return planet;
            }
        }
    }
}
