using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Client.Renderer;
using FantasiaAPI.Shared.Blocks;
using FantasiaAPI.Shared.Worlds;
using FantasiaGame.Client.Materials;

namespace FantasiaGame.Shared.World.Blocks
{

    public class BlockBricks : Block
    {

        public override string ID { get; } = "bricks";

        public override Dictionary<Direction, Material> Textures { get; } = new Dictionary<Direction, Material>
        {
            {Direction.All, new MaterialBricks()}
        };

    }

}
