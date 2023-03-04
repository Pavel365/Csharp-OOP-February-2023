using MilitaryElite.Core;
using MilitaryElite.Core.Interfaces;
using System;

namespace MilitaryElite
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
