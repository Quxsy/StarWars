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
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnPlanet_Click(object sender, EventArgs e)
        {
            string url = $"https://swapi.py4e.com/api/planets/{txtPlanetID.Text}/";

            string json = await JsonHelper.GetJsonAsync(url);

            if (json == null)
            {
                MessageBox.Show("Planet not found.");
                return;
            }

            Planet planet = JsonConvert.DeserializeObject<Planet>(json);

            lblPlanetName.Text = planet.name;
            lblRotationPeriod.Text = planet.rotation_period;
            lblOrbitalPeriod.Text = planet.orbital_period;
            lblDiameter.Text = planet.diameter;
            lblClimate.Text = planet.climate;
            lblGravity.Text = planet.gravity;
            lblTerrain.Text = planet.terrain;
            lblSurfaceWater.Text = planet.surface_water;
            lblPopulation.Text = planet.population;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnPerson_Click(object sender, EventArgs e)
        {
            string url = $"https://swapi.py4e.com/api/people/{txtPersonID.Text}/";

            string json = await JsonHelper.GetJsonAsync(url);

            if (string.IsNullOrEmpty(json))
            {
                MessageBox.Show("Person not found.");
                return;
            }

            Person person = JsonConvert.DeserializeObject<Person>(json);

            lblPersonName.Text = person.name;
            lblHeight.Text = person.height;
            lblMass.Text = person.mass;
            lblHairColor.Text = person.hair_color;
            lblSkinColor.Text = person.skin_color;
            lblEyeColor.Text = person.eye_color;
            lblBirthYear.Text = person.birth_year;
            lblGender.Text = person.gender;

            string homeJson = await JsonHelper.GetJsonAsync(person.homeworld);
            Planet home = JsonConvert.DeserializeObject<Planet>(homeJson);
            lblHomeworld.Text = home.name;

            lstStarships.Items.Clear();

            if (person.starships != null && person.starships.Length > 0)
            {
                foreach (string shipUrl in person.starships)
                {
                    string jsonShip = await JsonHelper.GetJsonAsync(shipUrl);
                    Starship ship = JsonConvert.DeserializeObject<Starship>(jsonShip);

                    lstStarships.Items.Add(ship.name);
                }
            }
            else
            {
                lstStarships.Items.Add("No starships");
            }
        }

        private async void btnSpecies_Click(object sender, EventArgs e)
        {
            string url = $"https://swapi.py4e.com/api/species/{txtSpeciesID.Text}/";

            string json = await JsonHelper.GetJsonAsync(url);

            if (string.IsNullOrEmpty(json))
            {
                MessageBox.Show("Species not found.");
                return;
            }

            Species species = JsonConvert.DeserializeObject<Species>(json);

            lblSpeciesName.Text = species.name;
            lblClassification.Text = species.classification;
            lblDesignation.Text = species.designation;
            lblAvgHeight.Text = species.average_height;
            lblSkinColors.Text = species.skin_colors;
            lblHairColors.Text = species.hair_colors;
            lblEyeColors.Text = species.eye_colors;
            lblLifespan.Text = species.average_lifespan;
            lblLanguage.Text = species.language;

            if (!string.IsNullOrEmpty(species.homeworld))
            {
                string homeJson = await JsonHelper.GetJsonAsync(species.homeworld);
                Planet home = JsonConvert.DeserializeObject<Planet>(homeJson);
                lblHomeworlds.Text = home.name;
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
    }
}
