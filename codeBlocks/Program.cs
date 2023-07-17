using System;

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0; // initialize total to 0 before processing the numbers
bool found = false; // initialize found to false; it will be set to true if 42 is found in the loop.

foreach (int number in numbers)
{

    total += number; // sum up the numbers.

    if (number == 42)
        found = true; // if the number 42 is found, set 'found' to true.w

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");