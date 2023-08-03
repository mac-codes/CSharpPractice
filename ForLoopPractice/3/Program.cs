for (int i = 0; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i.ToString().PadLeft(3)} FIZZBUZZ");
    else if (i % 3 == 0)
        Console.WriteLine($"{i.ToString().PadLeft(3)} FIZZ");
    else if (i % 5 == 0)
        Console.WriteLine($"{i.ToString().PadLeft(3)} BUZZ");
    else
        Console.WriteLine($"{i.ToString().PadLeft(3)}");
}