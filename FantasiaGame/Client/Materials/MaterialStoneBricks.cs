using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Client.Renderer;

namespace FantasiaGame.Client.Materials
{
    public class MaterialStoneBricks : Material
    {

        public override string ID { get; } = "stone_bricks";

        public override string TexturePath { get; } = "fantasia/stone_bricks.png";

    }
}
