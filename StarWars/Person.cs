using System;
using Newtonsoft.Json;

namespace StarWars
{
    // Represents a Person object retrieved from the Star Wars API (SWAPI)
    public class Person
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("mass")]
        public string Mass { get; set; }

        [JsonProperty("hair_color")]
        public string HairColor { get; set; }

        [JsonProperty("skin_color")]
        public string SkinColor { get; set; }

        [JsonProperty("eye_color")]
        public string EyeColor { get; set; }

        [JsonProperty("birth_year")]
        public string BirthYear { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("homeworld")]
        public string Homeworld { get; set; }

        [JsonProperty("starships")]
        public string[] Starships { get; set; }

        // Constructor initializes Person object
        public Person(
            string name,
            string height,
            string mass,
            string hairColor,
            string skinColor,
            string eyeColor,
            string birthYear,
            string gender,
            string homeworld,
            string[] starships)
        {
            Name = name;
            Height = height;
            Mass = mass;
            HairColor = hairColor;
            SkinColor = skinColor;
            EyeColor = eyeColor;
            BirthYear = birthYear;
            Gender = gender;
            Homeworld = homeworld;
            Starships = starships;
        }
    }
}