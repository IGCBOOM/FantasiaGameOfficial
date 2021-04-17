using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    public class TemperateForest : Biome
    {

        public override string ID { get; } = "temperate_forest";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 15;
        public override double Humidity { get; } = 70;
        public override double Temperature { get; } = 22;
        public override Color BiomeColor { get; } = Color.ForestGreen;
        public override Color MapBiomeColor { get; } = Color.ForestGreen;
        public override double Weight { get; } = 50;

    }

}
