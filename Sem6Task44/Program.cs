//Задание 44
/*Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.*/
//Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//Вывод числа Фибоначчи
void PrintFibonacheNumber(int num)
{
    int first = 0;
    int second = 1;
    int buff = 0;
    for(int i = 0; i < num; i++)
    {
        Console.Write(first + " ");
        buff = first + second;
        first = second;
        second = buff;
    }
}
//вывод результатов
Console.Clear();
int numRes = ReadData("Введите число: ");
PrintFibonacheNumber(numRes);
