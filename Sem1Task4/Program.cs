Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите третье число: ");
int numC = int.Parse(Console.ReadLine()??"0");

int max = numA;

if (numB > max) {max = numB;}
if (numC > max) {max = numC;}
Console.WriteLine("");

Console.Write("Максимальное число: " + max);

