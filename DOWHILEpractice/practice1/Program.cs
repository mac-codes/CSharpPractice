using System;

class Program
{
    static void Main()
    {
        string? readResult; // Declare a variable to hold the user's input
        string valueEntered = ""; // Initialize a variable to an empty string
        int numValue = 0; // Initialize a variable to hold the converted integer value
        bool validNumber = false; // Initialize a variable to false to track if input is valid

        Console.WriteLine("Enter a number between 5 and 10:");

        do
        {
            readResult = Console.ReadLine(); // Read the user's input
            if (readResult != null)
            {
                valueEntered = readResult; // Store the non-null value as string
            }

            validNumber = int.TryParse(valueEntered, out numValue);
            // Convert inputed string to integer check if its a valid number

            if (validNumber == true)
            {
                if (numValue <= 5 || numValue >= 10)
                {
                    validNumber = false; // mark input as invalid if not between 5 & 10.
                    Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
                }
            }
            else
            {
                Console.WriteLine($"You entered an invalid number. Please try again.");
            }
        } while (validNumber == false); // Loop until a valid number is entered

        Console.WriteLine($"You entered {numValue}. Thank you.");
    }
}