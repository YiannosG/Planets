using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;
using Microsoft.Data.OData.Metadata;
using Planets.Models;
using Planets.Services;

// Model too simple to have need of a context here. Would have used a try-catch-finally block to call it
namespace Planets.Controllers
{
    public class PlanetController : ApiController
    {
        private IPlanetRepository _repo;
        public PlanetController(IPlanetRepository repo)
        {
            _repo = repo;
        }

        public PlanetController()
        {
            _repo = new PlanetRepository();
        }
        /// <summary>
        /// Gets all planets
        /// </summary>
        /// <returns>An array of Planet objects</returns>
        public Planet[] Get()
        {
            return _repo.GetAllPlanets();
        }

        /// <summary>
        /// Returns a single Planet based on Planet ID
        /// </summary>
        /// <param name="id">Id of planet needed</param>
        /// <returns>A single Planet</returns>
        public Planet GetPlanet(int id)
        {
            var planet = _repo.GetPlanet(id);
            
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
