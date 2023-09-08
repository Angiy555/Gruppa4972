//Задание 16
/*Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.*/
Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine()??"0");//Принимаем первое число

Console.Write("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine()??"0");//Принимаем второе число

bool test1 = (firstNum == secondNum * secondNum);
bool test2 = (secondNum == firstNum * firstNum);

if (test1)
{
    Console.WriteLine("Первое число квадрат второго");
}
if (test2)
{
    Console.WriteLine("Второе число квадрат первого");
}
if (!(test1 || test2))
{
    Console.WriteLine("Первое число не квадрат второго и второе число не квадрат первого");
}