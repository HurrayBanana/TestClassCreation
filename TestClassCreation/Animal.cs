using System;
using System.Collections.Generic;
using System.Text;

namespace TestClassCreation
{
    public class Animal
    {
        public Animal() { }

        public virtual void Eat()
        {
            Console.WriteLine("I would eat if i Could");
        }

        public virtual void Walk()
        {
            Console.WriteLine(", that is how I walk");
        }
    }

    public class Tiger : Animal
    {
        public Tiger()
        { }

        public override void Eat()
        {
            Console.WriteLine("I eat bones");
            //base.Eat();
        }
        public override void Walk()
        {
            Console.Write("with a spring in my step");
            base.Walk();
        }
    }

}
