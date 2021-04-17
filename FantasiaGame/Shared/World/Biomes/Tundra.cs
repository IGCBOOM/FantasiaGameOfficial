using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{

    // Tundras are flat-ish land that are too cold for trees to grow.
    // They can rarely melt snow, and have soggy terrain.
    public class Tundra : Biome
    {

        public override string ID { get; } = "tundra";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 13.5;
        public override double Humidity { get; } = 80;
        public override double Temperature { get; } = -2;
        public override Color BiomeColor { get; } = Color.YellowGreen;
        public override Color MapBiomeColor { get; } = Color.PaleGreen;
        public override double Weight { get; } = 50;

    }

}
