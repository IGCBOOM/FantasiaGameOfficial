using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    public class DeepOcean : Biome
    {

        public override string ID { get; } = "deep_ocean";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = -20;
        public override double Humidity { get; } = 50; // This is for biome placement, not literal humidity!
        public override double Temperature { get; } = 23;
        public override Color BiomeColor { get; } = Color.MidnightBlue;

    }

}
