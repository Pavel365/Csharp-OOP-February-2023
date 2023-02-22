using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            StackOfStrings strings = new StackOfStrings();

            Console.WriteLine(strings.IsEmpty());

            strings.AddRange(new List<string>() { "1", "2", "3", "4", "5", "6" });

            Console.WriteLine(strings.IsEmpty());
        }
    }
}
