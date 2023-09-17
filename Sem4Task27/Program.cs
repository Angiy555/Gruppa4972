//Задание 27
/*Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.*/
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

//Сумма цифр в числе
int SumNumber(int num)
{
    int res = 0;
    while(num > 0)
    {
        res = res + num%10;
        num = num/10;
    }
    return res;
}
//Выводим результат
PrintResult("Сумма цифр равна: " + SumNumber(ReadData("Введите число: ")));
