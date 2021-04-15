using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.World.Biomes
{
    public class TemperateForest : Biome
    {

        public override string ID { get; } = "temperateforest";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 15;
        public override double Humidity { get; } = 70;
        public override double Temperature { get; } = 22;

    }

}
