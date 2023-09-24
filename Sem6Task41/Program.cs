//Задание 41
/*Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
//Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//Печатаем результат
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
//Сборка массива
int[] AssemblingArray(int length)
{
    int[] arr = new int[length];
    for(int i =0; i < length; i++)
    {
        arr[i] = ReadData("Введите " + (i + 1) + " элемент: ");
    }
    return arr;
}
//Подсчет положительных элементов
int CountPositiveNumber(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {count++;}
    }
    return count;
}
//вывод результатов
Console.Clear();
int[] array = AssemblingArray(ReadData("Введите количество элементов: "));
PrintArray(array);
PrintResult("Введено " + CountPositiveNumber(array) + " положительных элементов");
