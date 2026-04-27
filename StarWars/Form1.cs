using System;
using Newtonsoft.Json;
using StarWars;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWars
{
    public partial class Form1 : Form
    {
        List<FavoriteItem> favorites = new List<FavoriteItem>();

        string currentType = "";
        string currentName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnPlanet_Click(object sender, EventArgs e)
        {
            //INPUT VALIDATION
            if (!int.TryParse(txtPlanetID.Text, out int planetId))
            {
                MessageBox.Show("Please enter a valid Planet ID (number).");
                return;
            }

            string url = $"https://swapi.py4e.com/api/planets/{planetId}/";

            string json = await JsonHelper.GetJsonAsync(url);

            if (string.IsNullOrEmpty(json))
            {
                MessageBox.Show("Planet not found.");
                return;
            }

            Planet planet = JsonConvert.DeserializeObject<Planet>(json);

            currentType = "Planet";
            currentName = planet.Name;

            lblPlanetName.Text = planet.Name;
            lblRotationPeriod.Text = planet.RotationPeriod;
            lblOrbitalPeriod.Text = planet.OrbitalPeriod;
            lblDiameter.Text = planet.Diameter;
            lblClimate.Text = planet.Climate;
            lblGravity.Text = planet.Gravity;
            lblTerrain.Text = planet.Terrain;
            lblSurfaceWater.Text = planet.SurfaceWater;
            lblPopulation.Text = planet.Population;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnPerson_Click(object sender, EventArgs e)
        {
            //INPUT VALIDATION
            if (!int.TryParse(txtPersonID.Text, out int personId))
            {
                MessageBox.Show("Please enter a valid Person ID (number).");
                return;
            }

            string url = $"https://swapi.py4e.com/api/people/{personId}/";

            string json = await JsonHelper.GetJsonAsync(url);

            if (string.IsNullOrEmpty(json))
            {
                MessageBox.Show("Person not found.");
                return;
            }

            Person person = JsonConvert.DeserializeObject<Person>(json);

            PersonEntity personEntity = new PersonEntity(person.Name, person.Gender);

            currentType = "Person";
            currentName = person.Name;

            lblPersonName.Text = personEntity.GetDisplay();
            lblHeight.Text = person.Height;
            lblMass.Text = person.Mass;
            lblHairColor.Text = person.HairColor;
            lblSkinColor.Text = person.SkinColor;
            lblEyeColor.Text = person.EyeColor;
            lblBirthYear.Text = person.BirthYear;
            lblGender.Text = person.Gender;

            string homeJson = await JsonHelper.GetJsonAsync(person.Homeworld);
            Planet home = JsonConvert.DeserializeObject<Planet>(homeJson);
            lblHomeworld.Text = home.Name;

            lstStarships.Items.Clear();

            if (person.Starships != null && person.Starships.Length > 0)
            {
                foreach (string shipUrl in person.Starships)
                {
                    string jsonShip = await JsonHelper.GetJsonAsync(shipUrl);
                    Starship ship = JsonConvert.DeserializeObject<Starship>(jsonShip);

                    lstStarships.Items.Add(ship.Name);
                }
            }
            else
            {
                lstStarships.Items.Add("No starships");
            }
        }

        private async void btnSpecies_Click(object sender, EventArgs e)
        {
            //INPUT VALIDATION
            if (!int.TryParse(txtSpeciesID.Text, out int speciesId))
            {
                MessageBox.Show("Please enter a valid Species ID (number).");
                return;
            }

            string url = $"https://swapi.py4e.com/api/species/{speciesId}/";

            string json = await JsonHelper.GetJsonAsync(url);

            if (string.IsNullOrEmpty(json))
            {
                MessageBox.Show("Species not found.");
                return;
            }

            Species species = JsonConvert.DeserializeObject<Species>(json);

            currentType = "Species";
            currentName = species.Name;

            lblSpeciesName.Text = species.Name;
            lblClassification.Text = species.Classification;
            lblDesignation.Text = species.Designation;
            lblAvgHeight.Text = species.AverageHeight;
            lblSkinColors.Text = species.SkinColors;
            lblHairColors.Text = species.HairColors;
            lblEyeColors.Text = species.EyeColors;
            lblLifespan.Text = species.AverageLifespan;
            lblLanguage.Text = species.Language;

            if (!string.IsNullOrEmpty(species.Homeworld))
            {
                string homeJson = await JsonHelper.GetJsonAsync(species.Homeworld);
                Planet home = JsonConvert.DeserializeObject<Planet>(homeJson);
                lblHomeworlds.Text = home.Name;
            }
            else
            {
                lblHomeworlds.Text = "Unknown";
            }
        }

        private async void lstStarships_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPersonID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPerson.PerformClick();
                e.SuppressKeyPress = true; // stops the beep sound
            }
        }

        private void txtPlanetID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPlanet.PerformClick();
                e.SuppressKeyPress = true; // stops the beep sound
            }
        }

        private void txtSpeciesID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSpecies.PerformClick();
                e.SuppressKeyPress = true; // stops the beep sound
            }
        }

        private void btnAddFavorite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(currentName) || string.IsNullOrWhiteSpace(currentType))
            {
                MessageBox.Show("Nothing loaded to favorite.");
                return;
            }

            AddFavorite(currentName, currentType);
        }

        private void AddFavorite(string name, string type)
        {
            if (favorites.Any(f => f.Name == name && f.Category == type))
            {
                MessageBox.Show("Already added.");
                return;
            }

            FavoriteItem fav = new FavoriteItem(name, type);

            favorites.Add(fav);

            lstFavorites.Items.Add($"{fav.Name} ({fav.Category})");
        }
    }
}
