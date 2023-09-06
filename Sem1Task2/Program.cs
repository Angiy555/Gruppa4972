Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine()??"0");

if (numA > numB)
{
    Console.Write("Первое число: " + numA + " больше второго числа: " + numB);
}
else
{
    Console.Write("Второе число: " + numB + " больше первого числа: " + numA);
}