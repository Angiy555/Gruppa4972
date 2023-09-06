Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine()??"0");

Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine()??"0");

if(numA == numB * numB)
{
    Console.WriteLine("Число А является квадратом числа В.");
}
else
{
    Console.WriteLine("Число А не является квадратом числа В.");
}