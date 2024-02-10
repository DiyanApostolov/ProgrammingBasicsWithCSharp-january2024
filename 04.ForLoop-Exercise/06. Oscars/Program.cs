string actorName = Console.ReadLine();
double pointsFromAcademy = double.Parse(Console.ReadLine());
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    string name = Console.ReadLine();
    double points = double.Parse(Console.ReadLine());
    pointsFromAcademy += (name.Length) * points / 2;

    if (pointsFromAcademy >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsFromAcademy:F1}!");
        break;
    }
}

if (pointsFromAcademy < 1250.5)
{
    Console.WriteLine($"Sorry, {actorName} you need {Math.Abs(pointsFromAcademy - 1250.5):F1} more!");
}
