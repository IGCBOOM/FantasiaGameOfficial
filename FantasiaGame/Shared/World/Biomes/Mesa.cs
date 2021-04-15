using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    public class Mesa : Biome
    {

        public override string ID { get; } = "mesa";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 60;
        public override double Humidity { get; } = 15;
        public override double Temperature { get; } = 29;
        public override Color BiomeColor { get; } = Color.OliveDrab;

    }

}
