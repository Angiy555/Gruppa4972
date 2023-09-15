﻿//Задание 20
/*Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние
между ними в 3D пространстве.*/
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
//Расчет расстояния в 2D пространстве
double DistanceCal(int xA, int yA, int zA, int xB, int yB, int zB)
{
    double res = Math.Sqrt(Math.Pow(Math.Abs(xA - xB), 2) + 
    Math.Pow(Math.Abs(yA - yB), 2) + Math.Pow(Math.Abs(zA - zB), 2));
    return res;
}
//Вывод результата
PrintResult("Расстояние между точками А и В: " + 
DistanceCal(ReadData("Введите точку xA: "), 
ReadData("Введите точку yA: "), ReadData("Введите точку zA: "),
ReadData("Введите точку xB: "), 
ReadData("Введите точку yB: "), ReadData("Введите точку zB: ")));
