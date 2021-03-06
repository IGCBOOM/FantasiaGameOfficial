using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    public class MangroveForest : Biome
    {

        public override string ID { get; } = "mangrove_forest";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 2;
        public override double Humidity { get; } = 80;
        public override double Temperature { get; } = 29;
        public override Color BiomeColor { get; } = Color.Chartreuse;
        public override Color MapBiomeColor { get; } = Color.LightSeaGreen;
        public override double Weight { get; } = 50;

    }

}
