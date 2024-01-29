int n = int.Parse(Console.ReadLine());
int sum = 0;
int maxNum = int.MinValue; 

for (int i = 1; i <= n; i++)
{
    int num = int.Parse(Console.ReadLine());
    sum += num;
    if (num > maxNum)
    {
        maxNum = num;
    }
}
sum -= maxNum;
if (sum == maxNum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(sum-maxNum)}");
}
