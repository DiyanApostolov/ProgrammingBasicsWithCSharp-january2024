int cakeSize = int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine());

string input = Console.ReadLine();

while (input != "STOP")
{
    cakeSize -= int.Parse(input);

    if (cakeSize <= 0)
    {
        Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
        break;
    }

    input = Console.ReadLine();
}

if (input == "STOP")
    Console.WriteLine($"{cakeSize} pieces are left.");