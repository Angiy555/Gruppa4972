//Задание 30
/*Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.*/
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
int[] GeneratArray(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for(int i = 0; i < len; i ++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}
//Выводим результат
PrintArray(GeneratArray(ReadData("Введите размер массива: ")));
