
int juryNumber = int.Parse(Console.ReadLine());
string presentationName = Console.ReadLine();

double averageGradeSum = 0;
double totalGradeSum = 0;
double averageGradeSumTotal = 0;
int presentationCount = 0;

while (presentationName != "Finish")
{
    double presentationGradeSum = 0;
    for (int i = 0; i < juryNumber; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        presentationGradeSum += grade;
    }

    averageGradeSum = presentationGradeSum / juryNumber;
    Console.WriteLine($"{presentationName} - {averageGradeSum:f2}.");

    totalGradeSum += averageGradeSum;
    presentationCount++;

    presentationName = Console.ReadLine();
}

averageGradeSumTotal = totalGradeSum / presentationCount;
Console.WriteLine($"Student's final assessment is {averageGradeSumTotal:F2}.");
