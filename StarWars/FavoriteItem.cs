using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    // Represents an item saved to the user's favorites list
    public class FavoriteItem
    {
        public string Name { get; set; }
        public string Category { get; set; }

        // Constructor initializes a favorite item
        public FavoriteItem(string name, string category)
        {
            Name = string.IsNullOrWhiteSpace(name) ? "Unknown" : name;
            Category = string.IsNullOrWhiteSpace(category) ? "Unknown" : category;
        }
    }
}
