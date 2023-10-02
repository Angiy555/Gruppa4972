//Задание 62
/*Напишите программу, которая заполнит спирально массив 4 на 4.*/
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
// Создаем спиральную матрицу
int[,] GenerateSpiralMatrix(int n)
{
    int[,] spiralMatrix = new int[n, n];
    int num = 1;
    int rowStart = 0;
    int rowEnd = n - 1;
    int colStart = 0;
    int colEnd = n - 1;

    while (num <= n * n)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            spiralMatrix[rowStart, i] = num++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            spiralMatrix[i, colEnd] = num++;
        }
        colEnd--;

        for (int i = colEnd; i >= colStart; i--)
        {
            spiralMatrix[rowEnd, i] = num++;
        }
        rowEnd--;

        for (int i = rowEnd; i >= rowStart; i--)
        {
            spiralMatrix[i, colStart] = num++;
        }
        colStart++;
    }

    return spiralMatrix;
}
//Выводим решение
Console.Clear();
int [,] mtrx = GenerateSpiralMatrix(5);
PrintMatrix(mtrx);