// Loop through numbers from 0 to 101 (inclusive)
for (int i = 0; i <= 101; i++)
{
    // Check if the current number is divisible by both 3 & 5
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} FizzBuzz"); // if yes, print 'fizzbuzz'
    // Check if current number is only divisible by 3
    else if (i % 3 == 0)
        Console.WriteLine($"{i} Fizz"); // if yes print fizz
    // Check if current number is only divisible by 5
    else if (i % 5 == 0)
        Console.WriteLine($"{i} Buzz");// if yes print buzz
    else 
        Console.WriteLine($"{i}");// if none of the above just print the number itself.
}