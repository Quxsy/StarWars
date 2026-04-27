using System;
using Newtonsoft.Json;

namespace StarWars
{
    // Represents a Species object retrieved from the Star Wars API (SWAPI)
    public class Species
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("average_height")]
        public string AverageHeight { get; set; }

        [JsonProperty("skin_colors")]
        public string SkinColors { get; set; }

        [JsonProperty("hair_colors")]
        public string HairColors { get; set; }

        [JsonProperty("eye_colors")]
        public string EyeColors { get; set; }

        [JsonProperty("average_lifespan")]
        public string AverageLifespan { get; set; }

        [JsonProperty("homeworld")]
        public string Homeworld { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        // Constructor initializes Species object
        public Species(
            string name,
            string classification,
            string designation,
            string averageHeight,
            string skinColors,
            string hairColors,
            string eyeColors,
            string averageLifespan,
            string homeworld,
            string language)
        {
            Name = name;
            Classification = classification;
            Designation = designation;
            AverageHeight = averageHeight;
            SkinColors = skinColors;
            HairColors = hairColors;
            EyeColors = eyeColors;
            AverageLifespan = averageLifespan;
            Homeworld = homeworld;
            Language = language;
        }
    }
}