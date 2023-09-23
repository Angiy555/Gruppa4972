//Задание 39
/*Напишите программу, которая перевернёт одномерный
массив (последний элемент будет на первом месте, а первый - на
последнем и т.д.)*/
//Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//Печать массива
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
//Переворот массива в новый массив
int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        outArr[arr.Length - 1 - i] = arr[i];
    }
    return outArr;
}
//Переворот массива в исходный
void SwapArray(int[] arr)
{
    int buffElement = 0;
    for(int i = 0; i < arr.Length/2; i++)
    {
        buffElement = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = buffElement;
    }
}
//вывод результатов
Console.Clear();
int[] array = GeneratArray(ReadData("Введите размер массива: "),
1, 100);

PrintArray(array);
PrintArray(SwapNewArray(array));
SwapArray(array);
PrintArray(array);