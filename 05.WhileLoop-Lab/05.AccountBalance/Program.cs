
string input = Console.ReadLine();
double bankAccount = 0;

while (input != "NoMoreMoney")
{
    double currentInput = double.Parse(input);

    if (currentInput < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    bankAccount += currentInput;
    Console.WriteLine($"Increase: {currentInput:F2}");

    input = Console.ReadLine();
}

Console.WriteLine($"Total: {bankAccount:F2}");
