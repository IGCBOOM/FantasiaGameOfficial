using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{

    // Rocky garbage.
    // Low humidity, but still rains a bunch.
    public class Glacier : Biome
    {

        public override string ID { get; } = "glacier";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 30;
        public override double Humidity { get; } = 80;
        public override double Temperature { get; } = -3;
        public override Color BiomeColor { get; } = Color.FloralWhite;

    }

}
