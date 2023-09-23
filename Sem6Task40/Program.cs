//Задание 40
/*Напишите программу, которая принимает на вход три числа и
проверяет, может ли существовать треугольник с сторонами такой длины.*/
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
//Проверка на треугольник
bool TrianglCheck(int pointA, int pointB, int pointC)
{
    bool res = true;
    if(pointA + pointB < pointC) return res = false;
    if(pointB + pointC < pointA) return res = false;
    if(pointC + pointA < pointB) return res = false;
    return res;
}
//вывод результатов
Console.Clear();
PrintResult("Треугольник: " + 
TrianglCheck(ReadData("Введите первую точку: "), 
ReadData("Введите вторую точку: "), 
ReadData("Введите третью точку: ")));


