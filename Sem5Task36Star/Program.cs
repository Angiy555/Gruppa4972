//Задание 36*
/*Найдите все пары в массиве и выведите пользователю*/
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
//Сортировка пузырьком
void BubbelSort(int[] arr)
{
    int temp = 0;
    for (int write = 0; write < arr.Length; write++) {
        for (int sort = 0; sort < arr.Length - 1; sort++) 
        {
            if (arr[sort] > arr[sort + 1]) 
            {
                temp = arr[sort + 1];
                arr[sort + 1] = arr[sort];
                arr[sort] = temp;
            }
        }
    }    
}
//Печатаем пары массива
void PrintPair(int[] arr)
{
    Console.WriteLine("Пары массива: ");
    BubbelSort(arr);
    for (int i = 0; i < arr.Length-1; i++) 
    {        
        if(arr[i] == arr[i + 1])
        {
            Console.WriteLine(arr[i] + " " + arr[i + 1]);
            i += 2;
        }               
    }    
}
//вывод результатов
Console.Clear();
int[] array = GeneratArray(ReadData("Введите размер массива: "),
1, 10);

PrintArray(array);
PrintPair(array);

