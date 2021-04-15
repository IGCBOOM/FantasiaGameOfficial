using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.World.Biomes
{
    public class CoastalDesert : Biome
    {

        public override string ID { get; } = "coastal_desert";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 5.5;
        public override double Humidity { get; } = 40;
        public override double Temperature { get; } = 27.5;
        public override Color BiomeColor { get; } = Color.OliveDrab;

    }

}
