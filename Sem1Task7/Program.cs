Console.Write("Введите трехзначное число: ");
int numN = int.Parse(Console.ReadLine()??"0");

int resalt = numN%10;

if (numN > 99 && numN < 1000)
{
    Console.Write("Последняя цифра числа: " + resalt);
}
else
{
    Console.Write("Введено не трехзначное число");
}