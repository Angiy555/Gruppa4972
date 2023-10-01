//Задание 59
/*Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
*/
//Ввод данных
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
// Поиск наименьшего элемента в массиве и его индекса
void FindMin(int[,] arr, ref int x, ref int y)
{
    int min = arr[0, 0];
    x = 0; y = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (min > arr[i, j])
            {
                 min = arr[i, j];
                x = i;
                y = j;
            }
        }
    }
}

int[,] CreateArr(int[,] arr, int x, int y)
{
    int k = 0; int m = 0;
    int[,] outArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       if (i == x)
         {
         }
         else
         {
            m = 0;
             for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j == y)
                 {
                 }
                 else
                 {
                    outArr[k, m] = arr[i, j];
                    m++;
                }
             }
            k++;
        }
     }
    return outArr;
}


//Выводим решение
Console.Clear();
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int [,] mtrx = FillMatrixGen(row, column,0,10);
PrintMatrix(mtrx);
Console.WriteLine();
int x = -1;
int y = -1;
FindMin(mtrx, ref x, ref y);
int[,] outArr = CreateArr(mtrx, x, y);
PrintMatrix(outArr);

