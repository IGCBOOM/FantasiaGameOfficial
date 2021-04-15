using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.World.Biomes
{
    public class Desert : Biome
    {

        public override string ID { get; } = "desert";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 15;
        public override double Humidity { get; } = 4;
        public override double Temperature { get; } = 38;
        public override Color BiomeColor { get; } = Color.OliveDrab;

    }

}
