// initialize variables - graded assignments
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write the Report Header to the console
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

    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;


    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    // initialize/reset a counter for the number of assignment 
    int gradedAssignments = 0;

    // loop through the scores array and complete calculations for currentStudent
    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            // add the exam score to the sum
            sumAssignmentScores += score;

        else
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();


//Finale code
//int examAssignments = 5;

//string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

//int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
//int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
//int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
//int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

//int[] studentScores = new int[10];

//string currentStudentLetterGrade = "";

//// display the header row for scores/grades
//Console.Clear();
//Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

///*
//The outer foreach loop is used to:
//- iterate through student names 
//- assign a student's grades to the studentScores array
//- calculate exam and extra credit sums (inner foreach loop)
//- calculate numeric and letter grade
//- write the score report information
//*/
//foreach (string name in studentNames)
//{
//    string currentStudent = name;

//    if (currentStudent == "Sophia")
//        studentScores = sophiaScores;

//    else if (currentStudent == "Andrew")
//        studentScores = andrewScores;

//    else if (currentStudent == "Emma")
//        studentScores = emmaScores;

//    else if (currentStudent == "Logan")
//        studentScores = loganScores;

//    int gradedAssignments = 0;
//    int gradedExtraCreditAssignments = 0;

//    int sumExamScores = 0;
//    int sumExtraCreditScores = 0;

//    decimal currentStudentGrade = 0;
//    decimal currentStudentExamScore = 0;
//    decimal currentStudentExtraCreditScore = 0;

//    /* 
//    the inner foreach loop: 
//    - sums the exam and extra credit scores
//    - counts the extra credit assignments
//    */
//    foreach (int score in studentScores)
//    {
//        gradedAssignments += 1;

//        if (gradedAssignments <= examAssignments)
//        {
//            sumExamScores = sumExamScores + score;
//        }

//        else
//        {
//            gradedExtraCreditAssignments += 1;
//            sumExtraCreditScores += score;
//        }
//    }

//    currentStudentExamScore = (decimal)(sumExamScores) / examAssignments;
//    currentStudentExtraCreditScore = (decimal)(sumExtraCreditScores) / gradedExtraCreditAssignments;

//    currentStudentGrade = (decimal)((decimal)sumExamScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments;

//    if (currentStudentGrade >= 97)
//        currentStudentLetterGrade = "A+";

//    else if (currentStudentGrade >= 93)
//        currentStudentLetterGrade = "A";

//    else if (currentStudentGrade >= 90)
//        currentStudentLetterGrade = "A-";

//    else if (currentStudentGrade >= 87)
//        currentStudentLetterGrade = "B+";

//    else if (currentStudentGrade >= 83)
//        currentStudentLetterGrade = "B";

//    else if (currentStudentGrade >= 80)
//        currentStudentLetterGrade = "B-";

//    else if (currentStudentGrade >= 77)
//        currentStudentLetterGrade = "C+";

//    else if (currentStudentGrade >= 73)
//        currentStudentLetterGrade = "C";

//    else if (currentStudentGrade >= 70)
//        currentStudentLetterGrade = "C-";

//    else if (currentStudentGrade >= 67)
//        currentStudentLetterGrade = "D+";

//    else if (currentStudentGrade >= 63)
//        currentStudentLetterGrade = "D";

//    else if (currentStudentGrade >= 60)
//        currentStudentLetterGrade = "D-";

//    else
//        currentStudentLetterGrade = "F";


//    // Student         Exam Score      Overall Grade   Extra Credit
//    // Sophia          92.2            95.88   A       92 (3.68 pts)

//    Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(((decimal)sumExtraCreditScores / 10) / examAssignments)} pts)");
//}

//// required for running in VS Code (keeps the Output windows open to view results)
//Console.WriteLine("\n\rPress the Enter key to continue");
//Console.ReadLine();
