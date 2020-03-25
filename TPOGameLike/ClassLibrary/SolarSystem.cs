using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class SolarSystem : IDbEntity
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public virtual List<Planet> Planets { get; set; }
        public SolarSystem()
        {
            this.Planets = new List<Planet>();
        }
    }
}
