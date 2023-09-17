//Задание 29*
/*Напишите программу, которая задаёт массив из 8 
элементов и выводит их на экран.*/
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
    Console.Write(arr[arr.Length - 1] + "]");
}
//Генерируем массив 0 и 1
int[] GeneratArray(int len, int numLimit)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for(int i = 0; i < len; i ++)
    {
        arr[i] = rnd.Next(0, numLimit);
    }
    return arr;
}
//выводим результат
PrintArray(GeneratArray(ReadData("Введите размер массива: "), 
ReadData("Введите предел числа: ")));
