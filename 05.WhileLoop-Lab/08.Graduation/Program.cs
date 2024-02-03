
string name = Console.ReadLine();

int klas = 1;
double allGrades = 0;
int badGrades = 0;

while (klas <= 12)
{
    double currentGrade = double.Parse(Console.ReadLine());

	if (currentGrade < 4.00)
	{
		badGrades++;

		if (badGrades < 2)
		{
			continue;
		}
		else
		{
            Console.WriteLine($"{name} has been excluded at {klas} grade");
            return;
		}
	}

	klas++;
	allGrades += currentGrade;
}

//if (klas >= 12)
//{
    double averageGrade = allGrades / 12;
    Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
//}

