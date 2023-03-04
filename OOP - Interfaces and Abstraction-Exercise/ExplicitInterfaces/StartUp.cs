using ExplicitInterfaces.Core;
using ExplicitInterfaces.Core.Interfaces;
using System;

namespace ExplicitInterfaces
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
