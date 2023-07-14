using System;

// initialize variables - graded assignments 
int currentAssignments = 5;
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 81, 96, 90 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// student names
string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };
int[] studentScores = new int[10];

// Write the report header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;

    //initialize/reset the sum of the scored assignemtns
    int sumAssignmentScores = 0;
    //initialize/reset the calculated average of exam + ec scores
    decimal currentStudentGrade;

    foreach (int score in studentScores)
    {
        // add the exam score to the sum
        sumAssignmentScores += score;
    }

    currentStudentGrade = (decimal) (sumAssignmentScores)/ currentAssignments;


    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
