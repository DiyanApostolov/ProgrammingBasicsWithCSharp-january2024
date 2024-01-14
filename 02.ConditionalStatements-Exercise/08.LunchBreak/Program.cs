
string nameOfMovie = Console.ReadLine();
int timeOfMovie = int.Parse(Console.ReadLine());
int timeOfBreak = int.Parse(Console.ReadLine());

double timeForLunch = timeOfBreak / 8.0;    
double timeForRest = timeOfBreak / 4.0;

double allNeededTime = timeOfMovie + timeForLunch + timeForRest;

double difference = Math.Abs(allNeededTime - timeOfBreak);

if (allNeededTime <= timeOfBreak)
{
    Console.WriteLine($"You have enough time to watch {nameOfMovie} and left with {Math.Ceiling(difference)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {nameOfMovie}, you need {Math.Ceiling(difference)} more minutes.");
}