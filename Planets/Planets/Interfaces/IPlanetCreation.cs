using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planets.Models;

namespace Planets.Interfaces
{
    /// <summary>
    /// Defines contract that all planets should adhere to
    /// </summary>
    public interface IPlanetCreation
    {
        Planet[] GetAllPlanets(Planet planet);
    }
}
