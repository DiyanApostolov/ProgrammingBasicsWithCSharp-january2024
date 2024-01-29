//1. Четем n от конзолата 
int n = int.Parse(Console.ReadLine());

//2. Създаваме променливи за броя на числата, които попадат във всеки от диапазоните (p1...p5)
int countP1 = 0;
int countP2 = 0;
int countP3 = 0;
int countP4 = 0;
int countP5 = 0;

//3. Създаваме цикъл, който да се изпълнява n на брой пъти
for (int i = 0; i < n; i++)
{
    //=> четем число от конзолата 
    int num = int.Parse(Console.ReadLine());

    //=> провеяваме в кой диапазон попада
    if (num < 200)
        countP1++;
    else if (num < 400)
        countP2++;
    else if (num < 600)
        countP3++;
    else if (num < 800)
        countP4++;
    else
        countP5++;
}


//4. Oтпечатваме резултата на конзолата в проценти
//=> count / n * 100 = {result:f2}%
Console.WriteLine($"{(double)countP1/n*100:f2}%");
Console.WriteLine($"{(double)countP2/n*100:f2}%");
Console.WriteLine($"{(double)countP3/n*100:f2}%");
Console.WriteLine($"{(double)countP4/n*100:f2}%");
Console.WriteLine($"{(double)countP5/n*100:f2}%");

