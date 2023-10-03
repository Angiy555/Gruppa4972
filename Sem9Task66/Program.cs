//Задание 66
/*Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.*/
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
int SumLineRec(int m, int n)
{
    if (m == 0) return (n * (n + 1)) / 2;            // Если M равно нулю
    else if (n == 0) return (m * (m + 1)) / 2;       // Если N равно нулю
    else if (m == n) return m;                       // Если M=N
    else if (m < n) return n + SumLineRec(m, n - 1); // Если M<N
    else return n + SumLineRec(m, n + 1);           // Если M>N
}

//Выводим решение
Console.Clear();
int n = ReadData("Введите число N: ");
int m = ReadData("Введите число M: ");
PrintResult($"Сумма числе от {n} до {m} равна {SumLineRec(m, n)}.");
