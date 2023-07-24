# NOTES

1. Initialize Variables:
    * the code starts by declaring and initlizing several variables. `currentAssigments` is set to **5**, inidicating the total number of assignments students have.
    * `sophiaScores` are integer arrays the store the exam scores of each students.
    * `studentNames` is a **string array** the contains the name of each student.
    * `studentScores` is an integer array with a size of 10, which will be used to store the scored of the current processed student.
    * `currentStudentLetterGrade` is a string variable used to store the calculated letter grade for the current student.
2. Write Report Header:
    * The program prints a header for the report to the console, displaying the columns we want.
3. Main Loop:
    * The code then enters a loop that iteratoes over each students name in the `studentNames` array. for each iteration is does the following:
        1. Sets the `currentStudent` variable to the current students name, which is being processed in this iteration.
        2. Determines which students scores to use for the calculations. it checks the value of `currentStudent` and sets the `studentScores` array to the corresponding student scores.
        3. initialized/reset `sumAssigmentScores` and `currentStudentGrade` to **0**. the assignment score variable will be used to store the total sum of the students exam score. the student grade variable will the used to store the calculated grade for the current student.
        4. Calculates the total sum of exam scores for the current student by *iterating* over each score in `studentScores` array and adding it to `sumAssignmentScores`.
        5. Calculates the average grade of the student by dividing `sumAssignmentScores` by the total number of assignments (`currentAssignments`). The result is stored in the `currentStudentGrade` variable as a *decimal*.
        6. Determines the letter grade for the current student based on the calculated currentStudentGrade. The code uses a series of if-else statements to assign the appropriate letter grade to the currentStudentLetterGrade variable.
        7. Prints the student's name, grade (as a decimal), and letter grade to the console using Console.WriteLine.


#### additional stuff
* Why are integers being created inside the loop?
    > Inside the loop, two variables, sumAssignmentScores and currentStudentGrade, are initialized or reset for each student. This is done to calculate the total sum of exam scores for the current student (sumAssignmentScores) and then calculate the average grade (currentStudentGrade). Since these values need to be calculated separately for each student, they are created inside the loop. By initializing them to 0 for each student, the loop starts fresh for each student and correctly calculates their grades. If these variables were declared outside the loop, they would not be reset, and the calculations would accumulate results from all students, leading to incorrect grades.