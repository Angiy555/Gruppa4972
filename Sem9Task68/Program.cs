//Задание 68
/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/
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
//Выводим сумму натуральных числ в промежутке от M до N
int FunctionAkkermanaRec(int n, int m)
{
    if (n == 0) {return m + 1;}
    else
    {
        if ((n != 0) && (m == 0))
        {
            return FunctionAkkermanaRec(n - 1, 1);
        }
        else
        {
            return FunctionAkkermanaRec(n - 1, FunctionAkkermanaRec(n, m - 1));
        }
    }
}

//Выводим решение
Console.Clear();
int n = ReadData("Введите число N: ");
int m = ReadData("Введите число M: ");
PrintResult($"Функция Аккермана от {n} до {m} равна {FunctionAkkermanaRec(n, m)}.");