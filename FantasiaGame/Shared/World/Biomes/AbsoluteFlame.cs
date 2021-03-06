using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{

    // True terror, massive lava crevices, volcanoes, very terrible terrain.
    // Generally unpleasant. Hopefully with high risk comes high reward, and there can be treasures kept by strong monsters and geology.
    public class AbsoluteFlame : Biome
    {

        public override string ID { get; } = "AbsoluteFlame";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 20;
        public override double Humidity { get; } = 0;
        public override double Temperature { get; } = 40;
        public override Color BiomeColor { get; } = Color.DarkSlateGray;
        public override Color MapBiomeColor { get; } = Color.OrangeRed;
        public override double Weight { get; } = 10;

    }

}
