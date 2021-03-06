﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planets.Models;

namespace Planets.Services
{
    public interface IPlanetRepository
    {
        Planet[] GetAllPlanets(string system);
        Planet GetPlanet(int planetId, string system);
    }
}
