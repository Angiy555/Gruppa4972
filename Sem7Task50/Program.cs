//Задание 50
/*Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.*/
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
//Печатаем результат
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
//поиск элемента матрицы
int ElementSearchMatrix(int[,] matrix, int row, int column)
{
    int res;
    if(matrix.GetLength(1) < row || matrix.GetLength(0) < column)
    {
        PrintResult("такого элемента нет");
        res = -1;
    }
    else
    {
        res = matrix[row -1, column -1];
    }
    
    return res;
}
//Выводим решение
Console.Clear();
int row = ReadData("Введите номер строки: ");
int column = ReadData("Введите номер столбца: ");

int [,] mtrx = FillMatrixGen(6, 6, 1, 100);
PrintMatrix(mtrx);
int element = ElementSearchMatrix(mtrx, row, column);
PrintResult("Значение элемента равно: " + element);
