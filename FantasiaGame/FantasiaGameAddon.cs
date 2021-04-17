using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasiaAPI;

namespace FantasiaGame
{
    public class FantasiaGameAddon : Addon
    {

        public override string ID { get; } = "fantasia";

        public override string Authors { get; } = "BOOM, deR1t, and Beepo";

        public override void Init()
        {

            Logger.Info("Fantasia Game Initialized!");

            base.Init();

        }

        protected override void Close()
        {



            base.Close();

        }

    }
}
