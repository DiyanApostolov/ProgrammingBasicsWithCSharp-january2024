//1. Четем данните от кознолата (темепература и време от денонощието)
int degrees = int.Parse(Console.ReadLine());
string dayTime = Console.ReadLine();

//2. Създаме 2 променливи, които да пазят облеклото и обувките -
string outfit = string.Empty;
string shoes = string.Empty;

//3. Външна проверка за времето от денонощието ("Morning", "Afternoon", "Evening")
if (dayTime == "Morning")
{
    //=> вътрешна проверка за темп. (темп <= 18, ако не е => темп <=24, ако не - то е >= 25)
    if (degrees>=10 && degrees <= 18)
    {
        outfit = "Sweatshirt";
        shoes = "Sneakers";
    }
    else if (degrees <= 24)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else // degrees >=25
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
}
else if (dayTime == "Afternoon")
{
    if (degrees <= 18)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (degrees <= 24)
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else // degrees >=25
    {
        outfit = "Swim Suit";
        shoes = "Barefoot";
    }
}
else if (dayTime == "Evening")
{
    outfit = "Shirt";
    shoes = "Moccasins";
}

//4. Отпечатваме резултата на конзолата (outfit,shoes)
Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");