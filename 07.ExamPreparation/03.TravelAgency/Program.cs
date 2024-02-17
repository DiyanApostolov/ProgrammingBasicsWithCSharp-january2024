
string nameOfCity = Console.ReadLine();
string packageType = Console.ReadLine();
string vipDiscount = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

if (days <= 0)
{
    Console.WriteLine("Days must be positive number!");
    return;
}
if (days > 7)
{
    days--;
}

double price = 0;

switch (nameOfCity)
{
	case "Bansko" or "Borovets":
        if (packageType == "withEquipment")
        {
            price = 100 * days;

            if (vipDiscount == "yes")
                price *= 0.9;
        }
        else if (packageType == "noEquipment")
        {
            price = 80 * days;

            if (vipDiscount == "yes")
                price *= 0.95;
        }
        else
        {
            Console.WriteLine("Invalid input!");
            //return;
        }
        break;
    case "Varna" or "Burgas":
        if (packageType == "withBreakfast")
        {
            price = 130 * days;

            if (vipDiscount == "yes")
                price *= 0.88;
        }
        else if (packageType == "noBreakfast")
        {
            price = 100 * days;

            if (vipDiscount == "yes")
                price *= 0.93;
        }
        else
        {
            Console.WriteLine("Invalid input!");
            //return;
        }
        break;
    default:
        Console.WriteLine("Invalid input!");
        break;
}

if (price > 0)
{
    Console.WriteLine($"The price is {price:F2}lv! Have a nice time!");
}

