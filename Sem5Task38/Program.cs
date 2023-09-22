//Задание 38
/*Задайте массив вещественных чисел. Найдите разницу
между максимальным и минимальным элементов массива.*/
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
//Печатаем вещественный массив
void PrintArray(double[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i ++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
    System.Console.WriteLine();
}
//Генерируем вещественный массив
double[] GeneratArray(int len, int lowBorder, int highBorder)
{
    double[] arr = new double[len];
    Random rnd = new Random();
    for(int i = 0; i < len; i ++)
    {
        arr[i] = Math.Round(rnd.Next(lowBorder, highBorder + 1) 
        + rnd.NextDouble(),2);
    }
    return arr;
}
//Разница между максимальным и минимальным элементом массива
double DifferenceElementsMaxMin(double[] arr)
{
    double maxNum = arr.Max();
    double minNum = arr.Min();
    return maxNum - minNum;
}
//вывод результатов
Console.Clear();
double[] array = GeneratArray(ReadData("Введите размер массива: "),
1, 999);

PrintArray(array);
PrintResult("Разница между max и min элементом равна: " + 
DifferenceElementsMaxMin(array));
