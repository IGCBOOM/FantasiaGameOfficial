using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    public class Steppe : Biome
    {

        public override string ID { get; } = "steppe";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 35.0;
        public override double Humidity { get; } = 60;
        public override double Temperature { get; } = 20;
        public override Color BiomeColor { get; } = Color.LimeGreen;
        public override Color MapBiomeColor { get; } = Color.DarkSalmon;
        public override double Weight { get; } = 50;

    }

}
