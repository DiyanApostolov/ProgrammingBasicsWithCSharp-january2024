//1. Четем вход от конзолата
int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine(); //"Spring", "Summer", "Autumn", "Winter"
int fishermen = int.Parse(Console.ReadLine());

double price = 0;

//2. Проверяваме какъв е сезона и начисляваме съответния наем 
switch (season)
{
	case "Spring":
		price = 3000;
		break;
	case "Summer":
    case "Autumn":
        price = 4200;
        break;
    case "Winter":
        price = 2600;
        break;
    default:
		break;
}

//3. Проверяваме каква ще е отстъпката спрямо броя рибари
if (fishermen <= 6)
    price *= 0.9; //10% отстъпка
    //price = price - price * 0.10;
    //price -= price * 0.1;
    //price = price * 0.9;
else if (fishermen <= 11)
    price *= 0.85; //15% отстъпка
else
    price *= 0.75; //25% отстъпка

//4. Проверяваме дали ще имат доп. отстъпка (5%) - ако рибарите са четен брой и НЕ е есен
if (fishermen % 2 == 0 && season != "Autumn")
    price *= 0.95; //5% отстъпка

//5. Проверяваме дали бюджета е достатъчен
if (budget >= price)
    Console.WriteLine($"Yes! You have {budget-price:f2} leva left.");
else
    Console.WriteLine($"Not enough money! You need {Math.Abs(budget-price):f2} leva.");