//Задание 49
/*Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.*/
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
            Console.Write(matrix[i, j] + "\t ");
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
//Меняем четный индекс на квадрат значения
void EvenToSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i%2 ==  0 && j%2 == 0) matrix[i,j] = matrix[i,j]*matrix[i,j];
        }
        
    }
}
//Выводим решение
Console.Clear();
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int [,] mtrx = FillMatrixGen(row, column,1,20);
PrintMatrix(mtrx);
Console.WriteLine();
EvenToSquare(mtrx);
PrintMatrix(mtrx);
