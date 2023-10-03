//Задание 63
/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
промежутке от N до 1. Выполнить с помощью рекурсии.*/
//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//Выводим все натуральные числа в промежутке от N до 1
void GenLineRec(int num)
{
    Console.Write(num+" ");
    if(num<=1)
    {
    }
    else
    {
       GenLineRec(num-1);
    }
}
//Выводим решение
Console.Clear();

int num = ReadData("Введите число N: ");
GenLineRec(num);