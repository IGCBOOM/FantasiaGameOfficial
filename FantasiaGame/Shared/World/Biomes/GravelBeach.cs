using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{

    // Intended for beaches that are cold and dry.
    // So warm beaches don't generate off the side of arctic ice.
    public class GravelBeach : Biome
    {

        public override string ID { get; } = "gravel_beach";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 3;
        public override double Humidity { get; } = 30;
        public override double Temperature { get; } = 20;
        public override Color BiomeColor { get; } = Color.Olive;

    }

}
