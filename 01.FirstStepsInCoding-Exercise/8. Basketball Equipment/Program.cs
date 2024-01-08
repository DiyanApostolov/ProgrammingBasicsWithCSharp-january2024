//1. Четем от конзолата каква е таксата за 1г. 
int taxPerYear = int.Parse(Console.ReadLine());

//2. Намираме каква е цената за всеки компонент от екипировката
//- кецове – 40% по-малка от таксата за една година
double shoes = taxPerYear - taxPerYear * 0.4;
//- екип – 20% по-евтина от  кецовете
double outfit = shoes - shoes * 0.2;
//- топка –  1 / 4 от цената на екип
double ball = outfit / 4;
//- аксесоари –  1 / 5 от топка
double acc = ball / 5;

//3. Намираме колко общо са разходите за таксата + екипировката 
double sum = taxPerYear + shoes + outfit + ball + acc;

//4. Отепчатваме резултата на конзолата
Console.WriteLine(sum);
