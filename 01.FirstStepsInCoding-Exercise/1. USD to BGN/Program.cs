//1. Четем от конзолата USD
double usd = double.Parse(Console.ReadLine());

//2. Намираме BGN: преобразуваме USD => BGN (1 USD = 1.79549 BGN.) 
double bgn = usd * 1.79549;

//3. Отпечатваме резултата на конзолата (BGN)
Console.WriteLine(bgn);
