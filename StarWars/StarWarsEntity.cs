using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    // Base class representing a general Star Wars entity (Person, Planet, Species, etc.)
    // Demonstrates inheritance and supports polymorphic display behavior.
    public class StarWarsEntity
    {
        // Encapsulated property for the entity's name
        public string Name { get; set; }

        // Constructor initializes the Name property
        public StarWarsEntity(string name)
        {
            Name = name;
        }

        // Virtual method allows derived classes to override display formatting
        public virtual string GetDisplay()
        {
            return Name;
        }
    }
}