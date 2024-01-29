//1. Четем вход от конзолата (тип прожекция, редове и колони)
string ticketsType = Console.ReadLine();
int row = int.Parse(Console.ReadLine());    
int col = int.Parse(Console.ReadLine());

//2. Намираме броя на местата в залата
double income = row * col;

//3. Проверяваме какъв е типа на прожекцията
switch (ticketsType)
{
    case "Premiere":
        //income = income * 12.00;
        income *= 12;
        break;
    case "Normal":
        //income = income * 7.50;
        income *= 7.5;
        break;
    case "Discount":
        //income = income * 5.00;
        income *= 5;
        break;
}

//4. Отпечатваме резултата на конзолата
Console.WriteLine($"{income:f2} leva"); 
