using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Animal
    {
        private const string KittensGender = "Female";

        public Kitten(string name, int age) 
            : base(name, age, KittensGender)
        {

        }

        public override string ProduceSound() => "Meow";
    }
}
