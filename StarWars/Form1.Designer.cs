using System;

namespace StarWars
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPlanetID = new System.Windows.Forms.TextBox();
            this.btnPlanet = new System.Windows.Forms.Button();
            this.lblPlanetName = new System.Windows.Forms.Label();
            this.lblClimate = new System.Windows.Forms.Label();
            this.lblTerrain = new System.Windows.Forms.Label();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.lblRotationPeriod = new System.Windows.Forms.Label();
            this.lblOrbitalPeriod = new System.Windows.Forms.Label();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblGravity = new System.Windows.Forms.Label();
            this.lblSurfaceWater = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPerson = new System.Windows.Forms.Button();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblMass = new System.Windows.Forms.Label();
            this.lblHairColor = new System.Windows.Forms.Label();
            this.lblSkinColor = new System.Windows.Forms.Label();
            this.lblEyeColor = new System.Windows.Forms.Label();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblHomeworld = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btnSpecies = new System.Windows.Forms.Button();
            this.txtSpeciesID = new System.Windows.Forms.TextBox();
            this.lblSpeciesName = new System.Windows.Forms.Label();
            this.lblClassification = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblAvgHeight = new System.Windows.Forms.Label();
            this.lblSkinColors = new System.Windows.Forms.Label();
            this.lblHairColors = new System.Windows.Forms.Label();
            this.lblEyeColors = new System.Windows.Forms.Label();
            this.lblLifespan = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblHomeworlds = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.lstStarships = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtPlanetID
            // 
            this.txtPlanetID.Location = new System.Drawing.Point(354, 86);
            this.txtPlanetID.Name = "txtPlanetID";
            this.txtPlanetID.Size = new System.Drawing.Size(100, 20);
            this.txtPlanetID.TabIndex = 0;
            this.txtPlanetID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlanetID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlanetID_KeyDown);
            // 
            // btnPlanet
            // 
            this.btnPlanet.Location = new System.Drawing.Point(367, 112);
            this.btnPlanet.Name = "btnPlanet";
            this.btnPlanet.Size = new System.Drawing.Size(75, 23);
            this.btnPlanet.TabIndex = 1;
            this.btnPlanet.Text = "Planet";
            this.btnPlanet.UseVisualStyleBackColor = true;
            this.btnPlanet.Click += new System.EventHandler(this.btnPlanet_Click);
            // 
            // lblPlanetName
            // 
            this.lblPlanetName.AutoSize = true;
            this.lblPlanetName.Location = new System.Drawing.Point(405, 139);
            this.lblPlanetName.Name = "lblPlanetName";
            this.lblPlanetName.Size = new System.Drawing.Size(68, 13);
            this.lblPlanetName.TabIndex = 2;
            this.lblPlanetName.Text = "Planet Name";
            this.lblPlanetName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClimate
            // 
            this.lblClimate.AutoSize = true;
            this.lblClimate.Location = new System.Drawing.Point(405, 227);
            this.lblClimate.Name = "lblClimate";
            this.lblClimate.Size = new System.Drawing.Size(41, 13);
            this.lblClimate.TabIndex = 3;
            this.lblClimate.Text = "Climate";
            this.lblClimate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTerrain
            // 
            this.lblTerrain.AutoSize = true;
            this.lblTerrain.Location = new System.Drawing.Point(405, 271);
            this.lblTerrain.Name = "lblTerrain";
            this.lblTerrain.Size = new System.Drawing.Size(40, 13);
            this.lblTerrain.TabIndex = 4;
            this.lblTerrain.Text = "Terrain";
            this.lblTerrain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Location = new System.Drawing.Point(405, 315);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(57, 13);
            this.lblPopulation.TabIndex = 5;
            this.lblPopulation.Text = "Population";
            this.lblPopulation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRotationPeriod
            // 
            this.lblRotationPeriod.AutoSize = true;
            this.lblRotationPeriod.Location = new System.Drawing.Point(405, 161);
            this.lblRotationPeriod.Name = "lblRotationPeriod";
            this.lblRotationPeriod.Size = new System.Drawing.Size(80, 13);
            this.lblRotationPeriod.TabIndex = 6;
            this.lblRotationPeriod.Text = "Rotation Period";
            this.lblRotationPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrbitalPeriod
            // 
            this.lblOrbitalPeriod.AutoSize = true;
            this.lblOrbitalPeriod.Location = new System.Drawing.Point(405, 183);
            this.lblOrbitalPeriod.Name = "lblOrbitalPeriod";
            this.lblOrbitalPeriod.Size = new System.Drawing.Size(70, 13);
            this.lblOrbitalPeriod.TabIndex = 7;
            this.lblOrbitalPeriod.Text = "Orbital Period";
            this.lblOrbitalPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Location = new System.Drawing.Point(405, 205);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(49, 13);
            this.lblDiameter.TabIndex = 8;
            this.lblDiameter.Text = "Diameter";
            this.lblDiameter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGravity
            // 
            this.lblGravity.AutoSize = true;
            this.lblGravity.Location = new System.Drawing.Point(405, 249);
            this.lblGravity.Name = "lblGravity";
            this.lblGravity.Size = new System.Drawing.Size(40, 13);
            this.lblGravity.TabIndex = 9;
            this.lblGravity.Text = "Gravity";
            this.lblGravity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSurfaceWater
            // 
            this.lblSurfaceWater.AutoSize = true;
            this.lblSurfaceWater.Location = new System.Drawing.Point(405, 293);
            this.lblSurfaceWater.Name = "lblSurfaceWater";
            this.lblSurfaceWater.Size = new System.Drawing.Size(76, 13);
            this.lblSurfaceWater.TabIndex = 10;
            this.lblSurfaceWater.Text = "Surface Water";
            this.lblSurfaceWater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rotation Period:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Orbital Period:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Diameter:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Climate:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Gravity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Terrain:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Surface Water:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Population:";
            // 
            // btnPerson
            // 
            this.btnPerson.Location = new System.Drawing.Point(589, 109);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(75, 23);
            this.btnPerson.TabIndex = 21;
            this.btnPerson.Text = "Person";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(576, 83);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(100, 20);
            this.txtPersonID.TabIndex = 22;
            this.txtPersonID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPersonID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPersonID_KeyDown);
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Location = new System.Drawing.Point(626, 139);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(71, 13);
            this.lblPersonName.TabIndex = 23;
            this.lblPersonName.Text = "Person Name";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(626, 161);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 24;
            this.lblHeight.Text = "Height";
            // 
            // lblMass
            // 
            this.lblMass.AutoSize = true;
            this.lblMass.Location = new System.Drawing.Point(626, 183);
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(32, 13);
            this.lblMass.TabIndex = 25;
            this.lblMass.Text = "Mass";
            // 
            // lblHairColor
            // 
            this.lblHairColor.AutoSize = true;
            this.lblHairColor.Location = new System.Drawing.Point(626, 205);
            this.lblHairColor.Name = "lblHairColor";
            this.lblHairColor.Size = new System.Drawing.Size(53, 13);
            this.lblHairColor.TabIndex = 26;
            this.lblHairColor.Text = "Hair Color";
            // 
            // lblSkinColor
            // 
            this.lblSkinColor.AutoSize = true;
            this.lblSkinColor.Location = new System.Drawing.Point(626, 227);
            this.lblSkinColor.Name = "lblSkinColor";
            this.lblSkinColor.Size = new System.Drawing.Size(55, 13);
            this.lblSkinColor.TabIndex = 27;
            this.lblSkinColor.Text = "Skin Color";
            // 
            // lblEyeColor
            // 
            this.lblEyeColor.AutoSize = true;
            this.lblEyeColor.Location = new System.Drawing.Point(626, 249);
            this.lblEyeColor.Name = "lblEyeColor";
            this.lblEyeColor.Size = new System.Drawing.Size(52, 13);
            this.lblEyeColor.TabIndex = 28;
            this.lblEyeColor.Text = "Eye Color";
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Location = new System.Drawing.Point(626, 271);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(53, 13);
            this.lblBirthYear.TabIndex = 29;
            this.lblBirthYear.Text = "Birth Year";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(626, 293);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 30;
            this.lblGender.Text = "Gender";
            // 
            // lblHomeworld
            // 
            this.lblHomeworld.AutoSize = true;
            this.lblHomeworld.Location = new System.Drawing.Point(626, 314);
            this.lblHomeworld.Name = "lblHomeworld";
            this.lblHomeworld.Size = new System.Drawing.Size(60, 13);
            this.lblHomeworld.TabIndex = 31;
            this.lblHomeworld.Text = "Homeworld";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(582, 139);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "Name:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(579, 161);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "Height:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(585, 183);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 34;
            this.label22.Text = "Mass:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(564, 205);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 35;
            this.label23.Text = "Hair Color:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(562, 227);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 13);
            this.label24.TabIndex = 36;
            this.label24.Text = "Skin Color:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(565, 249);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 13);
            this.label25.TabIndex = 37;
            this.label25.Text = "Eye Color:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(564, 271);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 13);
            this.label26.TabIndex = 38;
            this.label26.Text = "Birth Year:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(575, 293);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 13);
            this.label27.TabIndex = 39;
            this.label27.Text = "Gender:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(557, 314);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(63, 13);
            this.label28.TabIndex = 40;
            this.label28.Text = "Homeworld:";
            // 
            // btnSpecies
            // 
            this.btnSpecies.Location = new System.Drawing.Point(85, 114);
            this.btnSpecies.Name = "btnSpecies";
            this.btnSpecies.Size = new System.Drawing.Size(75, 23);
            this.btnSpecies.TabIndex = 41;
            this.btnSpecies.Text = "Species";
            this.btnSpecies.UseVisualStyleBackColor = true;
            this.btnSpecies.Click += new System.EventHandler(this.btnSpecies_Click);
            // 
            // txtSpeciesID
            // 
            this.txtSpeciesID.Location = new System.Drawing.Point(72, 82);
            this.txtSpeciesID.Name = "txtSpeciesID";
            this.txtSpeciesID.Size = new System.Drawing.Size(100, 20);
            this.txtSpeciesID.TabIndex = 42;
            this.txtSpeciesID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSpeciesID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSpeciesID_KeyDown);
            // 
            // lblSpeciesName
            // 
            this.lblSpeciesName.AutoSize = true;
            this.lblSpeciesName.Location = new System.Drawing.Point(122, 140);
            this.lblSpeciesName.Name = "lblSpeciesName";
            this.lblSpeciesName.Size = new System.Drawing.Size(76, 13);
            this.lblSpeciesName.TabIndex = 44;
            this.lblSpeciesName.Text = "Species Name";
            // 
            // lblClassification
            // 
            this.lblClassification.AutoSize = true;
            this.lblClassification.Location = new System.Drawing.Point(122, 161);
            this.lblClassification.Name = "lblClassification";
            this.lblClassification.Size = new System.Drawing.Size(68, 13);
            this.lblClassification.TabIndex = 45;
            this.lblClassification.Text = "Classification";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(122, 183);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 46;
            this.lblDesignation.Text = "Designation";
            // 
            // lblAvgHeight
            // 
            this.lblAvgHeight.AutoSize = true;
            this.lblAvgHeight.Location = new System.Drawing.Point(122, 205);
            this.lblAvgHeight.Name = "lblAvgHeight";
            this.lblAvgHeight.Size = new System.Drawing.Size(81, 13);
            this.lblAvgHeight.TabIndex = 47;
            this.lblAvgHeight.Text = "Average Height";
            // 
            // lblSkinColors
            // 
            this.lblSkinColors.AutoSize = true;
            this.lblSkinColors.Location = new System.Drawing.Point(122, 227);
            this.lblSkinColors.Name = "lblSkinColors";
            this.lblSkinColors.Size = new System.Drawing.Size(55, 13);
            this.lblSkinColors.TabIndex = 48;
            this.lblSkinColors.Text = "Skin Color";
            // 
            // lblHairColors
            // 
            this.lblHairColors.AutoSize = true;
            this.lblHairColors.Location = new System.Drawing.Point(122, 249);
            this.lblHairColors.Name = "lblHairColors";
            this.lblHairColors.Size = new System.Drawing.Size(53, 13);
            this.lblHairColors.TabIndex = 49;
            this.lblHairColors.Text = "Hair Color";
            // 
            // lblEyeColors
            // 
            this.lblEyeColors.AutoSize = true;
            this.lblEyeColors.Location = new System.Drawing.Point(122, 271);
            this.lblEyeColors.Name = "lblEyeColors";
            this.lblEyeColors.Size = new System.Drawing.Size(52, 13);
            this.lblEyeColors.TabIndex = 50;
            this.lblEyeColors.Text = "Eye Color";
            // 
            // lblLifespan
            // 
            this.lblLifespan.AutoSize = true;
            this.lblLifespan.Location = new System.Drawing.Point(122, 293);
            this.lblLifespan.Name = "lblLifespan";
            this.lblLifespan.Size = new System.Drawing.Size(47, 13);
            this.lblLifespan.TabIndex = 51;
            this.lblLifespan.Text = "Lifespan";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(122, 315);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(55, 13);
            this.lblLanguage.TabIndex = 52;
            this.lblLanguage.Text = "Language";
            // 
            // lblHomeworlds
            // 
            this.lblHomeworlds.AutoSize = true;
            this.lblHomeworlds.Location = new System.Drawing.Point(122, 338);
            this.lblHomeworlds.Name = "lblHomeworlds";
            this.lblHomeworlds.Size = new System.Drawing.Size(60, 13);
            this.lblHomeworlds.TabIndex = 53;
            this.lblHomeworlds.Text = "Homeworld";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(78, 140);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(38, 13);
            this.label31.TabIndex = 54;
            this.label31.Text = "Name:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(45, 161);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(71, 13);
            this.label32.TabIndex = 55;
            this.label32.Text = "Classification:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(50, 183);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(66, 13);
            this.label33.TabIndex = 56;
            this.label33.Text = "Designation:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(32, 205);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(84, 13);
            this.label34.TabIndex = 57;
            this.label34.Text = "Average Height:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(58, 227);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(58, 13);
            this.label35.TabIndex = 58;
            this.label35.Text = "Skin Color:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(60, 249);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(56, 13);
            this.label36.TabIndex = 59;
            this.label36.Text = "Hair Color:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(61, 271);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(55, 13);
            this.label37.TabIndex = 60;
            this.label37.Text = "Eye Color:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(66, 293);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(50, 13);
            this.label38.TabIndex = 61;
            this.label38.Text = "Lifespan:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(58, 315);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(58, 13);
            this.label39.TabIndex = 62;
            this.label39.Text = "Language:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(53, 338);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(63, 13);
            this.label40.TabIndex = 63;
            this.label40.Text = "Homeworld:";
            // 
            // lstStarships
            // 
            this.lstStarships.FormattingEnabled = true;
            this.lstStarships.Location = new System.Drawing.Point(565, 330);
            this.lstStarships.Name = "lstStarships";
            this.lstStarships.Size = new System.Drawing.Size(120, 95);
            this.lstStarships.TabIndex = 64;
            this.lstStarships.SelectedIndexChanged += new System.EventHandler(this.lstStarships_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstStarships);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.lblHomeworlds);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblLifespan);
            this.Controls.Add(this.lblEyeColors);
            this.Controls.Add(this.lblHairColors);
            this.Controls.Add(this.lblSkinColors);
            this.Controls.Add(this.lblAvgHeight);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.lblClassification);
            this.Controls.Add(this.lblSpeciesName);
            this.Controls.Add(this.txtSpeciesID);
            this.Controls.Add(this.btnSpecies);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblHomeworld);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBirthYear);
            this.Controls.Add(this.lblEyeColor);
            this.Controls.Add(this.lblSkinColor);
            this.Controls.Add(this.lblHairColor);
            this.Controls.Add(this.lblMass);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblPersonName);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.btnPerson);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSurfaceWater);
            this.Controls.Add(this.lblGravity);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.lblOrbitalPeriod);
            this.Controls.Add(this.lblRotationPeriod);
            this.Controls.Add(this.lblPopulation);
            this.Controls.Add(this.lblTerrain);
            this.Controls.Add(this.lblClimate);
            this.Controls.Add(this.lblPlanetName);
            this.Controls.Add(this.btnPlanet);
            this.Controls.Add(this.txtPlanetID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblPerson_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.TextBox txtPlanetID;
        private System.Windows.Forms.Button btnPlanet;
        private System.Windows.Forms.Label lblPlanetName;
        private System.Windows.Forms.Label lblClimate;
        private System.Windows.Forms.Label lblTerrain;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Label lblRotationPeriod;
        private System.Windows.Forms.Label lblOrbitalPeriod;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblGravity;
        private System.Windows.Forms.Label lblSurfaceWater;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblMass;
        private System.Windows.Forms.Label lblHairColor;
        private System.Windows.Forms.Label lblSkinColor;
        private System.Windows.Forms.Label lblEyeColor;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblHomeworld;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnSpecies;
        private System.Windows.Forms.TextBox txtSpeciesID;
        private System.Windows.Forms.Label lblSpeciesName;
        private System.Windows.Forms.Label lblClassification;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblAvgHeight;
        private System.Windows.Forms.Label lblSkinColors;
        private System.Windows.Forms.Label lblHairColors;
        private System.Windows.Forms.Label lblEyeColors;
        private System.Windows.Forms.Label lblLifespan;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblHomeworlds;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ListBox lstStarships;
    }
}

