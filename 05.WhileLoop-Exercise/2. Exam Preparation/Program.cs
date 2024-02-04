int filedTimes = int.Parse(Console.ReadLine());

int evoluationSum = 0;
int evoluationCount = 0;
int filedCount = 0; 

string input = Console.ReadLine();
string lastExercise = string.Empty;
int evoluation;

while (input != "Enough")
{
    lastExercise = input;
    evoluation = int.Parse(Console.ReadLine());

    if (evoluation <= 4)
    {
        filedCount++;
        if (filedCount == filedTimes) 
        {
            Console.WriteLine($"You need a break, {filedCount} poor grades.");
            break;
        }
    }

    evoluationCount++;
    evoluationSum += evoluation;

    input = Console.ReadLine();
}

if (input == "Enough")
{
    Console.WriteLine($"Average score: {(double)evoluationSum/evoluationCount:f2}");
    Console.WriteLine($"Number of problems: {evoluationCount}");
    Console.WriteLine($"Last problem: {lastExercise}");
}


