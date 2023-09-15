//Задание 22
/*Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.*/
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

//Строим строку из чисел в степени
string BuildNumLinePow(int n, int pow)
{
    string res = "";
    for(int i = 1; i <= n; i++)
    {
        res = res + Math.Pow(i, pow) + " ";
    }
    return res;
}

int n = ReadData("Ведите число: ");
PrintResult("Квадрат числа от 1 до n: " + BuildNumLinePow(n, 2));
