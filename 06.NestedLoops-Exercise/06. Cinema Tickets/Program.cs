
//1. Създаваме проименливи, в които да пазим:
// общия брой продадени стандартни, студентски и детски билети
int studentsTickets = 0;
int standardTickets = 0;
int kidTickets = 0;

string filmName = Console.ReadLine();


while (filmName != "Finish")
{
    int freeTickets = int.Parse(Console.ReadLine());

    string ticketsType = string.Empty;
    int buyTickets = 0;

    while (buyTickets < freeTickets)
    {
        ticketsType = Console.ReadLine();
        
        if (ticketsType == "End")
            break;
        
        buyTickets++;

        if (ticketsType == "student")
            studentsTickets++;
        else if (ticketsType == "standard")
            standardTickets++;
        else
            kidTickets++;
    }

    Console.WriteLine($"{filmName} - {(double)buyTickets/freeTickets*100:f2}% full.");
    filmName = Console.ReadLine();
}


//4. Намираме общия брой продадени билети от всички прожекции и отпечатваме
int totalTickets = studentsTickets + standardTickets + kidTickets;

Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{(double)studentsTickets / totalTickets*100:f2}% student tickets.");
Console.WriteLine($"{(double)standardTickets / totalTickets * 100:f2}% standard tickets.");
Console.WriteLine($"{(double)kidTickets / totalTickets * 100:f2}% kids tickets.");
