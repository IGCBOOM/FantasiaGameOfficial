﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.World.Biomes
{
    public class TropicalForest : Biome
    {

        public override string ID { get; } = "tropicalforest";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 16.5;
        public override double Humidity { get; } = 90;
        public override double Temperature { get; } = 26;

    }

}
