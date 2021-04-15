using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.World.Biomes
{

    // Rocky garbage.
    // Low humidity, but still rains a bunch.
    public class ColdDesert : Biome
    {

        public override string ID { get; } = "cold_desert";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 12.5;
        public override double Humidity { get; } = 20;
        public override double Temperature { get; } = 24;
        public override Color BiomeColor { get; } = Color.DarkSeaGreen;

    }

}
