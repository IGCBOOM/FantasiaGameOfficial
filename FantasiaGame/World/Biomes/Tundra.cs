using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.World.Biomes
{
    /// <summary>
    /// Tundras are flat-ish land that are too cold for trees to grow.<br/>
    /// They can rarely melt snow, and have soggy terrain.
    /// </summary>
    public class Tundra : Biome
    {

        public override string ID { get; } = "tundra";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 13.5;
        public override double Humidity { get; } = 80;
        public override double Temperature { get; } = -2;
        public override Color BiomeColor { get; } = Color.YellowGreen;

    }

}
