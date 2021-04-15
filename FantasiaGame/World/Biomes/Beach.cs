using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.World.Biomes
{
    public class Beach : Biome
    {

        public override string ID { get; } = "beach";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 3;
        public override double Humidity { get; } = 50;
        public override double Temperature { get; } = 27;
        public override Color BiomeColor { get; } = Color.LimeGreen;

    }

}
