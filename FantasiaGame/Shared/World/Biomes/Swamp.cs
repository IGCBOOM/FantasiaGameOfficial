using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    public class Swamp : Biome
    {

        public override string ID { get; } = "swamp";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 3;
        public override double Humidity { get; } = 80;
        public override double Temperature { get; } = 23;
        public override Color BiomeColor { get; } = Color.ForestGreen;

    }

}
