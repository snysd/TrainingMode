using System;

namespace TrainingMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine($"Hello {rand.Next()}!");
            Console.ReadKey();
            Class1.Elevator();
        }
    }
}
