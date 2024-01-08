//1. Четем вход от конзолата:
int pages = int.Parse(Console.ReadLine());//Брой страници в текущата книга 
int pagesPerHour = int.Parse(Console.ReadLine()); //Страници, които прочита за 1 час
int days = int.Parse(Console.ReadLine()); //Броят на дните, за които трябва да прочете книгата

//2. Намираме общо време за четене на книгата
int time = pages / pagesPerHour;

//3. Намираме колко са необходимите часове на ден  
int hoursPerDay = time / days;

//4. Отпечатваме резултата на конзолата
Console.WriteLine(hoursPerDay);

