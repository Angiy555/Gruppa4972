//Задание 28
/*Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.*/
using System.Numerics;//добавляем библиотеку
//Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
//Получаем факториал числа
BigInteger FactorialNum(int num)
{
    BigInteger fact = 1;
    for(int i = 1; i <= num; i ++)
    {
        fact *= i;
    }
    return fact;
}
PrintResult("Факториал числа N: " + FactorialNum(ReadData("Введите число N: ")));