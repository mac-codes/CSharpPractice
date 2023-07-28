```csharp
// find each students highest and lowest scores and print them accordingly.
using System;

class Program
{

    static void main()
    {

        // initialize variables - graded assignments 
        int currentAssignments = 5;
        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

        // student names
        string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

        // Write the report header to the console
        Console.WriteLine("Student\tHighest Score\tLowest Score\n");

        // Loop through each student and find their highest & lowest score
        for (int i = 0; i < studentNames.Length; i++)
        {
            int maxScore = sophiaScores[i];
            int minScore = sophiaScores[i];

            for (int j = 0; j < currentAssignments; j++)
            {
                if (sophiaScores[i] > maxScore)
                {
                    maxScore = sophiaScores[i];
                }
                if (sophiaScores[i] < minScore)
                {
                    minScore = sophiaScores[i];
                }
            }
            Console.WriteLine($"{studentNames[i]}\t{maxScore}\t\t{minScore}");
        }
        Console.WriteLine("\nPress the Enter key to continue");
        Console.ReadLine();
    }
}
```
WHAT IS DIFFERENT????
also output is only doing one grade for both scores listed.