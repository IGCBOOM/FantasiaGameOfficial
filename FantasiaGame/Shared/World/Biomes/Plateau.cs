using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    public class Plateau : Biome
    {

        public override string ID { get; } = "plateau";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 55.0;
        public override double Humidity { get; } = 45;
        public override double Temperature { get; } = 19;
        public override Color BiomeColor { get; } = Color.SandyBrown;

    }

}
