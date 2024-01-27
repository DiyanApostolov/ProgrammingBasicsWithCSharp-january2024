
int n = int.Parse(Console.ReadLine());

int leftSum = 0;
int rightSum = 0;

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    leftSum += currentNumber;
}

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    rightSum += currentNumber;
}

if (leftSum == rightSum)
{
    Console.WriteLine($"Yes, sum = {leftSum}");
}
else
{
    int difference = Math.Abs(leftSum - rightSum);
    Console.WriteLine($"No, diff = {difference}");
}