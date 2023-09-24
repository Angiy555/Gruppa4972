//Задание 43
/*Напишите программу, которая найдёт точку пересечения двух 
прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/
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
//Решение уравнения y = k1 * x + b1, y = k2 * x + b2
void EquationStraightLine(double k1, double k2, double b1, double b2)
{
    double x = (-b1 + b2)/(k1 - k2);
    double y = k2*x + b2;    
    PrintResult("Точка пересечения равна {" + x + ";" + y + "}");
}
//Выполнение
Console.Clear();
double constK1 = ReadData("Введите к1: ");
double constK2 = ReadData("Введите к2: ");
double constB1 = ReadData("Введите b1: ");
double constB2 = ReadData("Введите b2: ");
EquationStraightLine(constK1, constK2, constB1, constB2);