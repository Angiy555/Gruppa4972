//Задание 55
/*Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.*/
//Вводим данные
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
//Заменяет строки матрицы на столбцы
 void ReplacementRowOnColumnMatrix(int[,] matrix)
{
     if(matrix.GetLength(0) == matrix.GetLength(1))
     {
      for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = i+1; j < matrix.GetLength(1); j++)
         {
             int temp = matrix[j,i];
             matrix[j,i] = matrix[i,j];
             matrix[i,j] = temp;
         }

     }
     } 
     else 
     {
         PrintResult("Эту матрицу нельзя перевернуть");
     }
}

//Выводим решение
Console.Clear();
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int [,] mtrx = FillMatrixGen(row, column,1,20);
PrintMatrix(mtrx);
Console.WriteLine();
ReplacementRowOnColumnMatrix(mtrx);
PrintMatrix(mtrx);
