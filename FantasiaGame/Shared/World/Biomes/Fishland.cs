using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Shared.Worlds.Generation.Biomes;

namespace FantasiaGame.Shared.World.Biomes
{

    // An island with the underwater plants growing on top (on special light blue soil, good for growing underwater plants on land).
    // oh yeah and any friendly underwater life can walk around on land in the biome 😎
    // "everybody gangsta till the fish start walkin" -Jon (during terraria rain)
    public class Fishland : Biome
    {

        public override string ID { get; } = "fishland";
        public override string BiomeType { get; } = "terra";
        public override double Height { get; } = 0;
        public override double Humidity { get; } = 70; // This is for biome placement, not literal humidity!
        public override double Temperature { get; } = 24;
        public override Color BiomeColor { get; } = Color.DeepSkyBlue;
        public override Color MapBiomeColor { get; } = Color.Aquamarine;
        public override double Weight { get; } = 50;

    }

}
