//Задание 67
/*Вывести сумму цифр числа рекурсией*/
//Ввод данных
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
// Суммирование цифр числа
int SumDigitRec(int num)
{

    if (num == 0)
    {
        return 0;
    }
    else
    {
        return num % 10 + SumDigitRec(num / 10);
    }

}
//Выводим решение
Console.Clear();
int number = ReadData("Введите число: ");

PrintResult($"Сумма всех цифр в числе {number} равна {SumDigitRec(number)}.");