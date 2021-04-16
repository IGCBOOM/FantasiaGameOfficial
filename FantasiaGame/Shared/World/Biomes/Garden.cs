using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{

    // A grassy, hilly biome with very tall grass, and massive flowers instead of trees.
    // Random walls sometimes made out of thick, tall grass that's harvestable and hard to break.
    public class Garden : Biome
    {

        public override string ID { get; } = "garden";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 16.5;
        public override double Humidity { get; } = 50;
        public override double Temperature { get; } = 24;
        public override Color BiomeColor { get; } = Color.LightGreen;

    }

}
