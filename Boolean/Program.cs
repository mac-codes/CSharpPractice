using System;

namespace LogicalOperationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a" == "a"); // Outputs: True
            Console.WriteLine("a" == "A"); // Outputs: False
            Console.WriteLine(1 == 2);    // Outputs: False

            string myValue = "a";
            Console.WriteLine(myValue == "a"); // Outputs: True

            string value1 = " a";
            string value2 = "A ";
            Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); // Outputs: True

            Console.WriteLine(1 > 2); // Outputs: False
            Console.WriteLine(1 < 2); // Outputs: True
            Console.WriteLine(1 >= 1); // Outputs: True
            Console.WriteLine(1 <= 1); // Outputs: True

            string pangram = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(pangram.Contains("fox")); // Outputs: True
            Console.WriteLine(!pangram.Contains("cow")); // Outputs: True
        }
    }
}
