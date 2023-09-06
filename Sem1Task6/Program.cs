Console.Write("Введите число: ");
int numA = int.Parse(Console.ReadLine()??"0");

int numEven = numA%2;

if (numEven == 0)
{
    Console.Write("Введенное число четное");
}
else
{
    Console.Write("Введенное число не четное");
}