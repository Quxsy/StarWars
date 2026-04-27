using System;

namespace StarWars
{
    // Represents a Star Wars starship retrieved from the SWAPI
    public class Starship
    {
        // Name of the starship
        public string Name { get; set; }

        // Constructor for initializing starship object
        public Starship(string name)
        {
            Name = name;
        }
    }
}