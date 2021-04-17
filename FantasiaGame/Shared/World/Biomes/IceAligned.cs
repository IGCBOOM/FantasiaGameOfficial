using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{
    // Iced over ocean (ice all the way down) with massive ice pyramids.
    // Special fancy looking ice to make breaking anything annoying.
    // Power of the sun is visibly being harvested something at the tops of bigger pyramids, which is what's keeping the place cold.
    public class IceAligned : Biome
    {

        public override string ID { get; } = "ice_aligned";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = -20;
        public override double Humidity { get; } = 4;
        public override double Temperature { get; } = -3;
        public override Color BiomeColor { get; } = Color.MediumPurple;
        public override Color MapBiomeColor { get; } = Color.MediumPurple;
        public override double Weight { get; } = 50;

    }

}
