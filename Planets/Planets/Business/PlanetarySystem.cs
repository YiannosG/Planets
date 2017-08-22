using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Planets.Interfaces;
using Planets.Models;
using Planets.Services;

namespace Planets.Business
{
    public class PlanetarySystem : IPlanetCreation
    {
        public SystemName Name { get; set; }
        public int NoOfPlanets { get; set; }

        public virtual Planet[] GetAllPlanets(Planet planet)
        {
            return null;
        }
    }

    public class Solar : PlanetarySystem
    {
        public override Planet[] GetAllPlanets(Planet planet)
        {
            PlanetRepository repository = new PlanetRepository();
            return repository.GetAllPlanets(Name.ToString());
        }
    }

    /// <summary>
    /// Another planetary system's planet could be implemented here
    /// </summary>
    public class Cnc55 : PlanetarySystem
    {
        public override Planet[] GetAllPlanets(Planet planet)
        {
            return base.GetAllPlanets(planet);
        }
    }

    public enum SystemName
    {
        Solar,
        Cnc55
    }

    public class PlanetarySystemFactory
    {
        public virtual IPlanetCreation GeneratePlanets(SystemName system, Planet planet)
        {
            IPlanetCreation generator = null;

            switch (system)
            {
                case SystemName.Solar:
                    generator = new Solar();
                    break;
                case SystemName.Cnc55:
                    generator = new Cnc55();
                    break;
            }
            return generator;
        }
    }
}