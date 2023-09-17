//Задание 25
/* Напишите цикл, который принимает на вход два 
числа (A и B) и возводит число A в натуральную степень B.*/
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
//Возведение числа А в степень В
long PowNumber(int numA, int numB)
{
    long res = numA;
    for (int i = 1; i < numB; i ++)
    {
        res = res * numA;
    }
    return res;
}
//выводим результат
PrintResult("Число А в степени В равно: " + 
PowNumber(ReadData("Введите число А: "), 
ReadData("введите число В: ")));

