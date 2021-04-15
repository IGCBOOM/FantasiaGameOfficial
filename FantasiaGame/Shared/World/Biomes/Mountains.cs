using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    public class Mountains : Biome
    {

        public override string ID { get; } = "mountains";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 75.0;
        public override double Humidity { get; } = 30;
        public override double Temperature { get; } = 12;
        public override Color BiomeColor { get; } = Color.SeaGreen;

    }

}
