using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.World.Biomes
{

    // Yucky terrain, gravel, etc.
    // Shrubs & hills.
    public class SemiaridDesert : Biome
    {

        public override string ID { get; } = "semiarid_desert";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 14.8;
        public override double Humidity { get; } = 10;
        public override double Temperature { get; } = 30;
        public override Color BiomeColor { get; } = Color.DarkOliveGreen;

    }

}
