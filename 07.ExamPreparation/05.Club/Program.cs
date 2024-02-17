
double neededIncome = double.Parse(Console.ReadLine());

string nameOfCocktail = Console.ReadLine();
double allIncom = 0;

while ( nameOfCocktail != "Party!")
{
    int countOfCockrails = int.Parse(Console.ReadLine());
    int priceForOneCockrail = nameOfCocktail.Length;

    double currentIncome = countOfCockrails * priceForOneCockrail;

    if (currentIncome % 2 == 1)
    {
        currentIncome *= 0.75;
    }

    allIncom += currentIncome;

    if (allIncom >= neededIncome)
    {
        Console.WriteLine("Target acquired.");
        break;
    }

    nameOfCocktail = Console.ReadLine();
}

if (nameOfCocktail == "Party!")
{
    Console.WriteLine($"We need {neededIncome - allIncom:F2} leva more.");
}

Console.WriteLine($"Club income - {allIncom:F2} leva.");