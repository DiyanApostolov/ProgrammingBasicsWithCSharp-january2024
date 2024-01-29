

//1. Четем вход от конзолата
int age = int.Parse(Console.ReadLine());
double washingMachine = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

//2. Създаваме променлива, в която да пазим парите, които Лили спестява
int money = 0;

//3. Създаваме цикъл, който да премине през всеки един РД на Лили
for (int birthday = 1; birthday <= age; birthday++)
{
    //=> за всеки РД ще проверяваме дали е четен => IF (рождения ден е четен)
    if (birthday % 2 == 0)
        //==> ако е четен => към спестяванията += годините, които навършва * 5 - 1лв. (1 лев взима брат й)
        money += birthday * 5 - 1;
    else
        //==> ако e НЕчетен=>  към спестяванията += Единична цена на играчка 
        money += toyPrice;
}

//4. Проверяваме дали спестените пари са достатъчни, за да си купи пералня
if (money >= washingMachine)
    Console.WriteLine($"Yes! {money - washingMachine:f2}");
else
    Console.WriteLine($"No! {washingMachine - money:f2}");

