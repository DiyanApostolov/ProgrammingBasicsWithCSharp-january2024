
double priceForTrip = double.Parse(Console.ReadLine());
int countOfPuzzels = int.Parse(Console.ReadLine());
int countOfDolls = int.Parse(Console.ReadLine());
int countOfBears = int.Parse(Console.ReadLine());
int countOfMinions = int.Parse(Console.ReadLine());
int countOfTrucks = int.Parse(Console.ReadLine());

double priceForPuzzels = countOfPuzzels * 2.6;
double priceForDolls = countOfDolls * 3;
double priceForBears = countOfBears * 4.1;
double priceForMinions = countOfMinions * 8.20;
double priceForTrucks = countOfTrucks * 2;

double incom = priceForPuzzels + priceForDolls + priceForBears + priceForMinions + priceForTrucks;

int countOfToys = countOfPuzzels + countOfDolls + countOfBears + countOfMinions + countOfTrucks;

if (countOfToys >= 50)
{
    incom = incom - (incom * 25 / 100);

    //incom *= 0.75;  -> по-кратко изчисление за намаление с 25%
}

double rent = incom * 0.1;

double finalIncom = incom - rent;

if (finalIncom >= priceForTrip)
{
    double moneyLeft = finalIncom - priceForTrip;
    Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
}
else
{
    double neededMoney = priceForTrip - finalIncom;
    Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed.");
}
