using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI.Client.Renderer;

namespace FantasiaGame.Client.Materials
{
    public class MaterialDirt : Material
    {

        public override string ID { get; } = "dirt";

        public override string TexturePath { get; } = "fantasia/dirt.png";

    }
}
