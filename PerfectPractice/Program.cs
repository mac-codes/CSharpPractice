using System;

class Program
{
    static void Main()
    {
        // initialize variables - graded assignments 
        int currentAssignments = 5;

        // Updated student scores
        int[] sophiaScores = new int[] { 100, 86, 87, 98, 90 };
        int[] andrewScores = new int[] { 96, 89, 81, 92, 90 };
        int[] emmaScores = new int[] { 98, 85, 87, 90, 68 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

        // student names
        string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

        // Write the report header to the console
        Console.WriteLine("Student\tHighest Score\tLowest Score");

        // Loop through each student and find their highest and lowest scores
        for (int i = 0; i < studentNames.Length; i++)
        {
            int maxScore = int.MinValue; // Initialize maxScore to the smallest possible integer value
            int minScore = int.MaxValue; // Initialize minScore to the largest possible integer value

            // Find the highest and lowest scores for each student
            for (int j = 0; j < currentAssignments; j++)
            {
                if (sophiaScores[i] > maxScore)
                {
                    maxScore = sophiaScores[i];
                }
                if (andrewScores[i] > maxScore)
                {
                    maxScore = andrewScores[i];
                }
                if (emmaScores[i] > maxScore)
                {
                    maxScore = emmaScores[i];
                }
                if (loganScores[i] > maxScore)
                {
                    maxScore = loganScores[i];
                }

                if (sophiaScores[i] < minScore)
                {
                    minScore = sophiaScores[i];
                }
                if (andrewScores[i] < minScore)
                {
                    minScore = andrewScores[i];
                }
                if (emmaScores[i] < minScore)
                {
                    minScore = emmaScores[i];
                }
                if (loganScores[i] < minScore)
                {
                    minScore = loganScores[i];
                }
            }

            // Print the results for each student
            Console.WriteLine($"{studentNames[i]}\t{maxScore}\t\t{minScore}");
        }

        Console.WriteLine("\nPress the Enter key to continue");
        Console.ReadLine();
    }
}
