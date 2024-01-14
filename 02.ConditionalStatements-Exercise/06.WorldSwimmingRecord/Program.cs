
double recordInSeconds = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double timeInSecondsForOneMeter = double.Parse(Console.ReadLine());

double timeForSwim = distanceInMeters * timeInSecondsForOneMeter;
double timesDelay = Math.Floor(distanceInMeters / 15);
double finalTimeForSwiming = timeForSwim + (timesDelay * 12.5);

if (finalTimeForSwiming < recordInSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {finalTimeForSwiming:F2} seconds.");
}
else
{
    double neededTime = finalTimeForSwiming - recordInSeconds;
    Console.WriteLine($"No, he failed! He was {neededTime:F2} seconds slower.");
}

