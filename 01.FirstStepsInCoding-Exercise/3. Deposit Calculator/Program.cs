//1. Четем данни от конзолата:
double deposit = double.Parse(Console.ReadLine()); // Депозирана сума
int term = int.Parse(Console.ReadLine()); //Срок на депозита(в месеци)
double rate = double.Parse(Console.ReadLine()) / 100; //Годишен лихвен процент

//2. Създаме променлива, в която да пазим крайната сума
double sum;
// => намираме крайната сума по формулата:
sum = deposit + term * (deposit * rate / 12);

//3. Отпечатваме резултата на конзолата
Console.WriteLine(sum);