using System;
using Newtonsoft.Json;

namespace StarWars
{
    // Represents a Planet object retrieved from the Star Wars API (SWAPI)
    public class Planet
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rotation_period")]
        public string RotationPeriod { get; set; }

        [JsonProperty("orbital_period")]
        public string OrbitalPeriod { get; set; }

        [JsonProperty("diameter")]
        public string Diameter { get; set; }

        [JsonProperty("climate")]
        public string Climate { get; set; }

        [JsonProperty("gravity")]
        public string Gravity { get; set; }

        [JsonProperty("terrain")]
        public string Terrain { get; set; }

        [JsonProperty("surface_water")]
        public string SurfaceWater { get; set; }

        [JsonProperty("population")]
        public string Population { get; set; }

        // Constructor initializes Planet object
        public Planet(
            string name,
            string rotationPeriod,
            string orbitalPeriod,
            string diameter,
            string climate,
            string gravity,
            string terrain,
            string surfaceWater,
            string population)
        {
            Name = name;
            RotationPeriod = rotationPeriod;
            OrbitalPeriod = orbitalPeriod;
            Diameter = diameter;
            Climate = climate;
            Gravity = gravity;
            Terrain = terrain;
            SurfaceWater = surfaceWater;
            Population = population;
        }
    }
}