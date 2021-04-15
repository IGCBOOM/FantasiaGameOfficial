using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Client.Renderer;

namespace FantasiaGame.Client.Materials
{

    public class MaterialStone : Material
    {

        public override string ID { get; } = "stone";

        public override string TexturePath { get; } = "fantasia/stone.png";

    }

}
