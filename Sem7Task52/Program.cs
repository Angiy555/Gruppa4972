//Задание 52
/*Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
*/
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
//Печатаем одномерный массив
void PrintArray(double[] arr)
{
    
    for(int i = 0; i < arr.Length; i ++)
    {
        Console.Write(arr[i] + "\t ");
    }
    
    System.Console.WriteLine();
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
//Поиск средних значений в столбце
double[] AveragesInColumn(int [,] matrix)
{

    double[] res = new double[matrix.GetLength(1)];
    double sum = 0;
    
    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];            
        }
        
        res[i] = sum/matrix.GetLength(1);
        sum = 0;
    }
     return res;
}

//Выводим решение
Console.Clear();
int row = ReadData("Введите номер строки: ");
int column = ReadData("Введите номер столбца: ");

int [,] mtrx = FillMatrixGen(row, column, 1, 100);
PrintMatrix(mtrx);
Console.WriteLine();
double[] array = AveragesInColumn(mtrx);
PrintArray(array);
