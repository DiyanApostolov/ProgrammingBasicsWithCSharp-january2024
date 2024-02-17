
int countOfPeople = int.Parse(Console.ReadLine());

int back = 0;
int chest = 0;
int legs = 0;
int abs = 0;
int proteinShake = 0;
int proteinBar = 0;

for (int i = 0; i < countOfPeople; i++)
{
    string input = Console.ReadLine();

	if (input == "Back")
		back++;
	else if (input == "Chest")
		chest++;
    else if (input == "Legs")
        legs++;
    else if (input == "Abs")
        abs++;
    else if (input == "Protein shake")
        proteinShake++;
    else if (input == "Protein bar")
        proteinBar++;
}

double trainig = (back + chest + legs + abs) / (double)countOfPeople * 100;
double proteinPurchase = (proteinShake + proteinBar) / (double)countOfPeople * 100;

Console.WriteLine($"{back} - back");
Console.WriteLine($"{chest} - chest");
Console.WriteLine($"{legs} - legs");
Console.WriteLine($"{abs} - abs");
Console.WriteLine($"{proteinShake} - protein shake");
Console.WriteLine($"{proteinBar} - protein bar");
Console.WriteLine($"{trainig:F2}% - work out");
Console.WriteLine($"{proteinPurchase:F2}% - protein");
