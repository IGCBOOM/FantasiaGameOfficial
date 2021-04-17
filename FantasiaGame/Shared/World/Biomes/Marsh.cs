using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    public class Marsh : Biome
    {

        public override string ID { get; } = "marsh";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 3;
        public override double Humidity { get; } = 75;
        public override double Temperature { get; } = 23;
        public override Color BiomeColor { get; } = Color.ForestGreen;
        public override Color MapBiomeColor { get; } = Color.MediumAquamarine;
        public override double Weight { get; } = 50;

    }

}
