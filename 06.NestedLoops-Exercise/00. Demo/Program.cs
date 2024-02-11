
int num = int.Parse(Console.ReadLine()); //6-цифрено
int currentNum;

for (int i = 1;  i <= 6; i++)
{
    currentNum = num % 10;
    Console.WriteLine(currentNum);
    num = num / 10;
}
