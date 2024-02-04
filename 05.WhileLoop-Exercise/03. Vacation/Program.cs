
double neededMoney = double.Parse(Console.ReadLine());
double avaliableMoney = double.Parse(Console.ReadLine());

int daysCount = 0;
int spendCount = 0;

while (avaliableMoney < neededMoney)
{
    string input = Console.ReadLine();
    double money = double.Parse(Console.ReadLine());

    daysCount++;

    if (input == "spend")
    {
        spendCount++;

        if (spendCount == 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(daysCount);
            break;
        }

        avaliableMoney -= money;

        if (avaliableMoney < 0)
            avaliableMoney = 0;
    }
    else //save
    {
        spendCount = 0;
        avaliableMoney += money;
    }
}

if (avaliableMoney >= neededMoney)
    Console.WriteLine($"You saved the money for {daysCount} days.");

