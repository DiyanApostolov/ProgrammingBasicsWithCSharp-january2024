
int countOfEasterBread = int.Parse(Console.ReadLine());

int bestChefPoints = 0;
string bestChefName = "";

for (int i = 0; i < countOfEasterBread; i++)
{
    string nameOtChef = Console.ReadLine();
    string input = Console.ReadLine();

    int allEasterBreadPoints = 0;

    while (input != "Stop")
    {
        int currentPoints = int.Parse(input);
        allEasterBreadPoints += currentPoints;

        input = Console.ReadLine();
    }

    Console.WriteLine($"{nameOtChef} has {allEasterBreadPoints} points.");

    if (allEasterBreadPoints > bestChefPoints)
    {
        bestChefName = nameOtChef;
        bestChefPoints = allEasterBreadPoints;
        Console.WriteLine($"{nameOtChef} is the new number 1!");
    }
}

Console.WriteLine($"{bestChefName} won competition with {bestChefPoints} points!");