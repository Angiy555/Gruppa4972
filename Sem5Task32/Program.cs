//Задание 32
/*Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.*/
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
//Инвертирование элементов массива
void InvertsArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}
//вывод результатов
Console.Clear();
int[] array = GeneratArray(ReadData("Введите размер массива: "),
ReadData("Введите нижний предел числа: "),
ReadData("Введите верхний предел числа: "));

PrintArray(array);
InvertsArray(array);
PrintArray(array);