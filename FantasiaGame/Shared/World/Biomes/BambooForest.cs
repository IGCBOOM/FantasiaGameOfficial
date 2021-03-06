using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    public class BambooForest : Biome
    {

        public override string ID { get; } = "bamboo_forest";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 16.5;
        public override double Humidity { get; } = 86;
        public override double Temperature { get; } = 26;
        public override Color BiomeColor { get; } = Color.LimeGreen;
        public override Color MapBiomeColor { get; } = Color.LimeGreen;
        public override double Weight { get; } = 50;

    }

}
