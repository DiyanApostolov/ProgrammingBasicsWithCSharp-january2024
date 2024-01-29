
//1. Четем от конзолата броя на групите, които очакваме
int n = int.Parse(Console.ReadLine());

//2. създаваме променливи за катерачите, които изкачват всеки 1 от върховете  и една за общоя брой катерачи 
int countP1 = 0;
int countP2 = 0;
int countP3 = 0;
int countP4 = 0;
int countP5 = 0;

int total = 0;

//3. Създаваме цикъл, който да се изпълнява за всяка една група
for (int group = 1; group <= n; group++)
{
    int count = int.Parse(Console.ReadLine());
    total += count;

    //===> до 5 човека –  Мусала 
    if (count <= 5)
        countP1 += count;
    //===> от 6 до 12 човека –  Монблан 
    else if (count <= 12)
        countP2 += count;
    //===> от 13 до 25 човека –  Килиманджаро
    else if (count <= 25)
        countP3 += count;
    //===> от 26 до 40 човека –   К2 
    else if (count <= 40)
        countP4 += count;
    //===> от 41 или повече човека –  Еверест 
    else
        countP5 += count;
}

//4. Отпечатваме резултата за всеки връх на конзолата
Console.WriteLine($"{(double)countP1/total*100:f2}%");
Console.WriteLine($"{(double)countP2/total*100:f2}%");
Console.WriteLine($"{(double)countP3/total*100:f2}%");
Console.WriteLine($"{(double)countP4/total*100:f2}%");
Console.WriteLine($"{(double)countP5/total*100:f2}%");
