//Задание 56
/* Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.*/
//Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//Печатаем матицу
void PrintMatrix (int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}
//Печатаем сообщение
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
//Заполняем матрицу случайными числами
int[,] FillMatrixGen(int countRow, int countColumn, int downBorder, int topBorder)
{
    System.Random rnd = new System.Random();
    int[,] matrix = new int[countRow, countColumn];
    for(int i = 0; i < countRow; i++)
    {
        for(int j = 0; j < countColumn; j++)
        {
            matrix[i, j] = rnd.Next(downBorder, topBorder);
        }
    }
    return matrix;
}
//Поиск строки с наименьшей суммой
int MinSumRow(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    int minSum = 0;
    int x = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i, j];
        }        
    }
    minSum = sum[0];
    for(int i = 1; i < sum.Length; i++)
    {        
        if(minSum > sum[i])
        {
            minSum = sum[i];
            x = i + 1;
        }
    }    
    return x;
}

//Выводим решение
Console.Clear();
int row = ReadData("Введите номер строки: ");
int column = ReadData("Введите номер столбца: ");

int [,] mtrx = FillMatrixGen(row, column, 1, 100);
PrintMatrix(mtrx);
Console.WriteLine();
int x = MinSumRow(mtrx);

PrintResult("Строка с минимальной сумой: " + x);
