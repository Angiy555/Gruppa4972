//Задание 60
/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.*/
//Поиск уникального числа трехмерной матрицы
int GetUniqueValue(int[,,] matrix, int min, int max, int i, int j, int k)
{
    Random rnd = new Random();
    int value = default;
    bool exist = true;
    while (exist)
    {
        bool _break = false;
        value = rnd.Next(min, max + 1);
        for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
        {
            if (_break) { break; }
            for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
            {
                if (_break) { break; }
                for (int k1 = 0; k1 < matrix.GetLength(2); k1++)
                {
                    if (matrix[i1, j1, k1] == value) { _break = true; break; }
                    if (i1 == i && j1 == j && k1 == k) { exist = false; }
                }
            }
        }
    }
    return value;
}
//Создание трехмерной матрицы с уникальными числами
int[,,] CreateMatrix3D(int row, int col, int dep, int min, int max)
{
    int[,,] matrix = new int[row, col, dep];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++) 
            { matrix[i, j, k] = GetUniqueValue(matrix, min, max, i, j, k); }
        }
    }
    return matrix;
}
//Печать трехмерной матрицы с индексами
void PrintMatrix3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("|");
            for (int k = 0; k < matrix.GetLength(2); k++)
             { Console.Write($"{matrix[i, j, k],1}({i},{j},{k})|"); }
            Console.WriteLine();
        }
    }
}
//Выполнение
Console.Clear();
int[,,] matrix3D = CreateMatrix3D(2, 2, 2, 10, 99);
PrintMatrix3D(matrix3D);