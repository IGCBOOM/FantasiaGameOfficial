using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    public class Savanna : Biome
    {

        public override string ID { get; } = "savanna";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 11.5;
        public override double Humidity { get; } = 65;
        public override double Temperature { get; } = 23;
        public override Color BiomeColor { get; } = Color.Peru;
        public override Color MapBiomeColor { get; } = Color.Goldenrod;
        public override double Weight { get; } = 50;

    }

}
