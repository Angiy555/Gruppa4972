//Задание 58
/*Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.*/
//Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//Печатаем сообщение
void PrintResult(string msg)
{
    Console.WriteLine(msg);
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
//Произведение матриц
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixMult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for(int i = 0; i < matrixMult.GetLength(0); i++)
    {
        for(int j = 0; j < matrixMult.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrixMult[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return matrixMult;
}
//Выводим решение
Console.Clear();
int [,] mtrx1 = FillMatrixGen(2, 2, 1, 10);
int [,] mtrx2 = FillMatrixGen(2, 2, 1, 10);
int [,] mtrxMult = MultiplicationMatrix(mtrx1, mtrx2);
PrintResult("Матрица 1");
PrintMatrix(mtrx1);
Console.WriteLine();
PrintResult("Матрица 2");
PrintMatrix(mtrx2);
Console.WriteLine();
PrintResult("Произведение матриц");
PrintMatrix(mtrxMult);
