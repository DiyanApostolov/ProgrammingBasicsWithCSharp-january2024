//1. Четем от конзолата радиани
double radians = double.Parse(Console.ReadLine());

//2. Преобразуваме радианите в градуси => : градус = радиан * 180 / π.
double degrees = radians * 180 / Math.PI;

//3. Отпечатванме резултата на конзолата
Console.WriteLine(degrees);