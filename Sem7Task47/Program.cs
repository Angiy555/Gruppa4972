//Задание 47
/*Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.*/
//Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//Печатаем матицу
void PrintMatrix (double[,] matrix)
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
//Заполнение матрицы случайными вещественными числами
double[,] FillMatrixGenDouble(int countRow, int countColumn, int lowBorder, int highBorder)
{
    System.Random rnd = new System.Random();
    double[,] matrix = new double[countRow, countColumn];
    for(int i = 0; i < countRow; i++)
    {
        for(int j = 0; j < countColumn; j++)
        {
            matrix[i, j] = Math.Round(rnd.Next(lowBorder, highBorder + 1) 
        + rnd.NextDouble(),2);
        }
    }
    return matrix;
}
//Выводим решение
Console.Clear();
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

double [,] mtrx = FillMatrixGenDouble(row, column, 1, 100);
PrintMatrix(mtrx);

