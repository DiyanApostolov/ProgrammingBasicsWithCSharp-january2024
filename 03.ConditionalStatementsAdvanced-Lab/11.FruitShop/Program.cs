
//плод banana	apple	orange	grapefruit	kiwi	pineapple	grapes
//цена	2.50	1.20	0.85	1.45	    2.70	5.50	    3.85
//цена	2.70	1.25	0.90	1.60	    3.00	5.60	    4.20

string fruit = Console.ReadLine();
string dayOfWeek = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double finalPrice = 0;

switch (dayOfWeek)
{
	case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        if (fruit == "banana")
            finalPrice = quantity * 2.50;
        else if (fruit == "apple")
            finalPrice = quantity * 1.20;
        else if (fruit == "orange")
            finalPrice = quantity * 0.85;
        else if (fruit == "grapefruit")
            finalPrice = quantity * 1.45;
        else if (fruit == "kiwi")
            finalPrice = quantity * 2.70;
        else if (fruit == "pineapple")
            finalPrice = quantity * 5.50;
        else if (fruit == "grapes")
            finalPrice = quantity * 3.85;
        else
            Console.WriteLine("error");
        break;
    case "Saturday":
    case "Sunday":
        if (fruit == "banana")
            finalPrice = quantity * 2.70;
        else if (fruit == "apple")
            finalPrice = quantity * 1.25;
        else if (fruit == "orange")
            finalPrice = quantity * 0.90;
        else if (fruit == "grapefruit")
            finalPrice = quantity * 1.60;
        else if (fruit == "kiwi")
            finalPrice = quantity * 3;
        else if (fruit == "pineapple")
            finalPrice = quantity * 5.60;
        else if (fruit == "grapes")
            finalPrice = quantity * 4.20;
        else
            Console.WriteLine("error");
        break;
    default:
        Console.WriteLine("error");
        break;
}

if (finalPrice > 0)
{
    Console.WriteLine($"{finalPrice:F2}");
}
