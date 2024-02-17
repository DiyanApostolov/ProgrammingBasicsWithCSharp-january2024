
double budget = double.Parse(Console.ReadLine());
double littresGas = double.Parse(Console.ReadLine());
string dayOfWeek = Console.ReadLine();

double moneyForGas = littresGas * 2.10;

double finalPrice = moneyForGas + 100;

if (dayOfWeek == "Saturday")
{
    finalPrice *= 0.9;
}
else if (dayOfWeek == "Sunday")
{
    finalPrice *= 0.8;
}

if (budget >= finalPrice)
{
    double moneyLeft = budget - finalPrice;
    Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv. ");
}
else
{
    double moneyNeeded = finalPrice - budget;
    Console.WriteLine($"Not enough money! Money needed: {moneyNeeded:f2} lv.");
}