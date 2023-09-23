//Задание 42
/*: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.*/
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
//Преобразование чисел
string DecToBin(int num)
{
    string binLine = "";
    while(num > 0)
    {
        binLine = num%2 + binLine;
        num = num/2;
    }
    return binLine;
}
//вывод результатов
Console.Clear();
int numRes = ReadData("Введите число: ");
PrintResult("Число " + numRes + 
" в двоичной системе равен: " + DecToBin(numRes));
