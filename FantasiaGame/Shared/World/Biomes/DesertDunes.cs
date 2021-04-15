using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    public class DesertDunes : Biome
    {

        public override string ID { get; } = "desert";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 15.5;
        public override double Humidity { get; } = 4.5;
        public override double Temperature { get; } = 37.5;
        public override Color BiomeColor { get; } = Color.OliveDrab;

    }

}
