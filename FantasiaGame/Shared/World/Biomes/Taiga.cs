using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    public class Taiga : Biome
    {

        public override string ID { get; } = "taiga";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 16.5;
        public override double Humidity { get; } = 80;
        public override double Temperature { get; } = 3;
        public override Color BiomeColor { get; } = Color.MediumSeaGreen;
        public override Color MapBiomeColor { get; } = Color.MediumSeaGreen;
        public override double Weight { get; } = 50;

    }

}
