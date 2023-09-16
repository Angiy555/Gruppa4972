//Задание 26
/*Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.*/
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
//Определяет количество цифр
int NumberLength(int num)
{
    int length = 0;
    while(num > 0)
    {
        num /= 10;
        length ++;
    }
    return length;
}
//Выводим результат
PrintResult("В числе " + NumberLength(ReadData("Введите число: " )) + " цифр");
