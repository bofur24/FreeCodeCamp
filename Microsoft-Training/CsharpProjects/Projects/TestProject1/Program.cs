using System;

namespace TestProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int roll = dice.Next(1, 7);
            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);

            Console.WriteLine($"First roll: {roll}");
            Console.WriteLine($"Second roll: {roll1}");
            Console.WriteLine($"Third roll: {roll2}");
            Console.WriteLine($"Last roll: {roll3}");
        }
    }
}
