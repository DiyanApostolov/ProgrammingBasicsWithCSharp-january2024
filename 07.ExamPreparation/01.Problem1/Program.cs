
using System;

int countOfPeople = int.Parse(Console.ReadLine());
double entrancePrice = double.Parse(Console.ReadLine());
double chairPrice = double.Parse(Console.ReadLine());
double umbrellaPrice = double.Parse(Console.ReadLine());

double allTicketPrice = countOfPeople * entrancePrice;
double priceForUmbrellas = Math.Ceiling((double)countOfPeople / 2) * umbrellaPrice;
double priceForChairs = Math.Ceiling(countOfPeople * 0.75) * chairPrice;

double finalPrice = allTicketPrice + priceForUmbrellas + priceForChairs;

Console.WriteLine($"{finalPrice:F2} lv.");