int tabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

//2. Създаваме цикъл, който да се изпълнява от 1вия до последния отворен таб
for (int tab = 1; tab <= tabs; tab++)
{
    //=> четем от кознолата string - отворен сайт 
    string site = Console.ReadLine();

    //=> Проверяваме дали отворения сайт е някой, за който се начислява глоба и ако е - начисляваме я
    switch (site)
    {
        case "Facebook":
            salary -= 150;
            break;
        case "Instagram":
            salary -= 100;
            break;
        case "Reddit":
            salary -= 50;
            break;
        default:
            break;
    }

    if (salary <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        break;
    }
}

//3. проверяваме дали на служителя му е останала заплата
if (salary>0)
    Console.WriteLine(salary);