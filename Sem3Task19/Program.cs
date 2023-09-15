//Задание 19
/*Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.*/
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
//Проверка на палиндром
void CheckingPolindrom(int number)
{
    int res = number;
    if(number > 9999 && number < 100000)
    {
        int [] polNum = new int [5];
        for(int i =0; i < 5; i++)
        {
            polNum[i] = number%10;
            number = number/10;
        }
        if(polNum[0] == polNum[4] && polNum[1] == polNum[3]) 
        {
            PrintResult("Число " + res + " является палиндромом");
        }
        else
        {
            PrintResult("Число " + res + " не является палиндромом");
        }
    }
    else
    {
        PrintResult("Введено не пятизначное число");
    }
}
//Выполнение
CheckingPolindrom(ReadData("Введите пятизначное число: "));

