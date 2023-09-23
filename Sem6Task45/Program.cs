//Задание 45
/*Напишите программу, которая будет создавать копию
заданного массива с помощью поэлементного копирования.*/
//Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
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
//Копирование массива
int[] CopyArray(int[] arr)
{
    int[] copyArray = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        copyArray[i] = arr[i];
    }
    return copyArray;
}
//вывод результатов
Console.Clear();
int[] array = GeneratArray(ReadData("Введите размер массива: "),1,100);

PrintArray(array);
PrintArray(CopyArray(array));