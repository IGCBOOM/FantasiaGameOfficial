﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    public class Trench : Biome
    {

        public override string ID { get; } = "trench";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = -45;
        public override double Humidity { get; } = 50; // This is for biome placement, not literal humidity!
        public override double Temperature { get; } = 23;
        public override Color BiomeColor { get; } = Color.Black;
        public override Color MapBiomeColor { get; } = Color.Navy;
        public override double Weight { get; } = 50;

    }

}
