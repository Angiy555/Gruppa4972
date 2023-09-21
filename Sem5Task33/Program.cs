//Задание 33
/*Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.*/
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
//Проверяем присутствие числа
string CheckNum(int[] arr, int num)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num)
        {return "Есть, индекс: " + i;}        
    }
    return "нет ";
}
//вывод результатов
Console.Clear();
int[] array = GeneratArray(ReadData("Введите размер массива: "),
ReadData("Введите нижний предел числа: "),
ReadData("Введите верхний предел числа: "));

PrintArray(array);
PrintResult(CheckNum(array, ReadData("Введите искомое число: ")));

