//Задание 34
/* Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.*/
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
//Подсчитываем количество четных чисел в массиве
int EvenNum(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0)
        {count++;}
    }
    return count;
}
//вывод результатов
Console.Clear();
int[] array = GeneratArray(ReadData("Введите размер массива: "),
100, 999);

PrintArray(array);
PrintResult("В массиве " + EvenNum(array) + " четных чисел");
