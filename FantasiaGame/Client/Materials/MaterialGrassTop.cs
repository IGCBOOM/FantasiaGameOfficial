using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Client.Renderer;

namespace FantasiaGame.Client.Materials
{
    public class MaterialGrassTop : Material
    {

        public override string ID { get; } = "grass_top";

        public override string TexturePath { get; } = "fantasia/grass_top.png";

    }
}
