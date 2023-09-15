//Задание 18
/*Напишите программу, которая по
заданному номеру четверти, показывает
диапазон возможных координат точек в этой
четверти (x и y).*/
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
//Определение диапазона по четверти
string PointsIdent(int quarterNum)
{
    if (quarterNum == 1) return "Возможные значения: X > 0, Y > 0";
    if (quarterNum == 2) return "Возможные значения: X < 0, Y > 0";
    if (quarterNum == 3) return "Возможные значения: X < 0, Y < 0";
    if (quarterNum == 4) return "Возможные значения: X > 0, Y < 0";
    return "Неверное значение";
}

PrintResult(PointsIdent(ReadData("Введите номер четверти: ")));
