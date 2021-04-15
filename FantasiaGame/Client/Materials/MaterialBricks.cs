using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Client.Renderer;

namespace FantasiaGame.Client.Materials
{
    public class MaterialBricks : Material
    {

        public override string ID { get; } = "brick";

        public override string TexturePath { get; } = "fantasia/bricks.png";

    }
}
