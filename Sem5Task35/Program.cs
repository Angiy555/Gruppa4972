//Задание 35
/*Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].*/
//Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//Печатаем число
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
//Печатаем массив
void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i ++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
    System.Console.WriteLine();
}
//Генерируем массив 0 и 1
int[] GeneratArray(int len, int lowBorder, int highBorder)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for(int i = 0; i < len; i ++)
    {
        arr[i] = rnd.Next(lowBorder, highBorder + 1);
    }
    return arr;
}
//Находим количество элементов в заданном диапазоне
int CountElement(int[] arr, int lowRang, int highRang)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= lowRang && arr[i] <= highRang)
        {count++;}
    }
    return count;
}
//вывод результатов
Console.Clear();
int[] array = GeneratArray(ReadData("Введите размер массива: "),
ReadData("Введите нижний предел числа: "),
ReadData("Введите верхний предел числа: "));

int count = CountElement(array,ReadData("Введите нижний предел: "), 
ReadData("Введите верхний предел: "));

PrintArray(array);
PrintResult(count + " элементов в заданном диапазоне");
