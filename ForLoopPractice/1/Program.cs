using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Increment +1");
        for (int i = 0; i < 11; i++)
        {
            
            Console.WriteLine(i);
            if (i == 7) break;
        }
        Console.WriteLine("Increment +3");
        for (int i = 0; i < 11; i += 3)
        {
            if (i == 7) continue;
            Console.WriteLine(i);
        }
        Console.WriteLine("Decrement -1");
         // Third loop WAS infiinite (i < 11) until
         // I modified the condition to (i < 0)
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}
