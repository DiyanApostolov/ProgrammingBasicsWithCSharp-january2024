
//1. Четем вид на фигурата от конзолата (square, rectangle, circle или triangle)
string figure = Console.ReadLine();

//Създаваме променлива, в която да пазим лицето на фигурата
double area = 0;

//2. Проверяваме кой е видът на фигурата:
if (figure == "square") 
{
    double a = double.Parse(Console.ReadLine());
    area = a * a;
}
else if (figure == "rectangle")
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    area = a * b;
}
else if (figure == "circle")
{
    double r = double.Parse(Console.ReadLine());
    area = Math.PI * r * r;
}
else //"triangle"
{
    double a = double.Parse((Console.ReadLine()));
    double h = double.Parse((Console.ReadLine()));
    area = a * h / 2;
}

//3. Отпечатваме лицето на фигурата 
Console.WriteLine($"{area:f3}");