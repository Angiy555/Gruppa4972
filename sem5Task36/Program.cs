//Задание 36
/*Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.*/
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
//Сумма элементов массива на нечетных позициях
int SumOddNum(int[] arr)
{
    int res = 0;
    for(int i = 1; i < arr.Length; i = i + 2)
    {
        res = res + arr[i];
    }
    return res;
}
//вывод результатов
Console.Clear();
int[] array = GeneratArray(ReadData("Введите размер массива: "),
1, 999);

PrintArray(array);
PrintResult("Сумма нечетных элементов равна: " + SumOddNum(array));

