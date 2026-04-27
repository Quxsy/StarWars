using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    // Derived class representing a Person in the Star Wars universe
    public class PersonEntity : StarWarsEntity
    {
        // Encapsulated property
        public string Gender { get; private set; }

        // Constructor uses base class (inheritance)
        public PersonEntity(string name, string gender)
            : base(name)
        {
            Gender = string.IsNullOrWhiteSpace(gender) ? "Unknown" : gender;
        }

        // Polymorphism: overrides base display behavior
        public override string GetDisplay()
        {
            return $"{Name} ({Gender})";
        }
    }
}