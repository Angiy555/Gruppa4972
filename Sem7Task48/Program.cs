//Задание 48
/*Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.*/
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
//Заполняем матрицу
int[,] FillMatrix(int countRow, int countColumn)
{
    int[,] matrix = new int[countRow, countColumn];
    for(int i = 0; i < countRow; i++)
    {
        for(int j = 0; j < countColumn; j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}
//Выводим решение
Console.Clear();
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int [,] mtrx = FillMatrix(row, column);
PrintMatrix(mtrx);