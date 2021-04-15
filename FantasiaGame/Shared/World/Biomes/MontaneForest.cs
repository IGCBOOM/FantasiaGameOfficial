using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    public class MontaneForest : Biome
    {

        public override string ID { get; } = "montane_forest";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 67.0;
        public override double Humidity { get; } = 35;
        public override double Temperature { get; } = 13;
        public override Color BiomeColor { get; } = Color.MediumAquamarine;

    }

}
