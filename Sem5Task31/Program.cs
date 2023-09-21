//Задание 31
/*Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.*/
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
//Определение суммы положительных и отрицательных элементов массива
(int, int) SumNegotivAndSumPositiv(int[] arr)
{
    int posSum = 0;
    int negSum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {posSum = posSum + arr[i];}
        else
        {negSum = negSum + arr[i];}        
    }
    return (posSum, negSum);
}
//вывод результатов
Console.Clear();
int[] array = GeneratArray(ReadData("Введите размер массива: "),
ReadData("Введите нижний предел числа: "),
ReadData("Введите верхний предел числа: "));

PrintArray(array);

(int pos, int neg) sum = SumNegotivAndSumPositiv(array);

Console.WriteLine("Сумма > 0 :"+sum.pos+" Сумма < 0 :"+sum.neg);