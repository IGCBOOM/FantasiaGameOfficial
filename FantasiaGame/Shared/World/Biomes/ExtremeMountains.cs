using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    public class ExtremeMountains : Biome
    {

        public override string ID { get; } = "extreme_mountains";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 100.0;
        public override double Humidity { get; } = 15;
        public override double Temperature { get; } = 0;
        public override Color BiomeColor { get; } = Color.MediumSeaGreen;

    }

}
