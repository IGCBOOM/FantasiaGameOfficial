using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    public class RedMapleForest : Biome
    {

        public override string ID { get; } = "red_maple_forest";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 5; // preferably next to rivers
        public override double Humidity { get; } = 80;
        public override double Temperature { get; } = 24.5;
        public override Color BiomeColor { get; } = Color.ForestGreen; // the trees need special treatment.
        //TODO: make this uncommon whenever the rarity thing is added.
    }

}
