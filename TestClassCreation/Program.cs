using System;

namespace TestClassCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Tiger dave = new Tiger();
            dave.Eat();
            dave.Walk();
        }
    }
}
