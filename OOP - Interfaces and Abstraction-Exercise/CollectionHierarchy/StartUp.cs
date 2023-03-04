using CollectionHierarchy.Core;
using CollectionHierarchy.Core.Interfaces;
using System;

namespace CollectionHierarchy
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
