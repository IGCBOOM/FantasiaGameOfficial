using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Client.Renderer;

namespace FantasiaGame.Client.Materials
{
    public class MaterialShrub : Material
    {

        public override string ID { get; } = "shrub";

        public override string TexturePath { get; } = "fantasia/shrub.png";

    }
}
