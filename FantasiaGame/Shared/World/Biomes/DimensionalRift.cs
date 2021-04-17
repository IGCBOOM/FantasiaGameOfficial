using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{

    public class DimensionalRift : Biome
    {

        public override string ID { get; } = "dimensional_rift";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 80;
        public override double Humidity { get; } = 30;
        public override double Temperature { get; } = 0;
        public override Color BiomeColor { get; } = Color.DarkSlateGray;
        public override Color MapBiomeColor { get; } = Color.Black;
        public override double Weight { get; } = 20;

    }

}
