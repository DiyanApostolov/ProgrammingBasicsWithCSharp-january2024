﻿//1. Четем данни от кознолата 
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine()); //„+“, „-“, „*“, „/“ или „%“

if (operation == '+' || operation == '-' || operation == '*')
{
    int result =0;
    string evenOrOdd = "odd"; //ще пазим "odd" или "even"

    switch (operation)
    {
        case '+':
            result = num1 + num2;
            break;
        case '-':
            result = num1 - num2;
            break;
        case '*':
            result = num1 * num2;
            break;
    }

    if (result % 2 == 0)
        evenOrOdd = "even";

    Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");
}
else //имаме „/“ или „%“
{
    if (num2 == 0)
        Console.WriteLine($"Cannot divide {num1} by zero");
    else if (operation == '/')
    {
        // намираме резултатът (поне 1 от числата трябва да е double)
        double result = (double)num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {result:f2}");
    }
    else //%
    {
        int result = num1 % num2;
        Console.WriteLine($"{num1} % {num2} = {result}");
    }

}
