//Задание 69
/*Возвести число m в степень n рекурсией*/
//Ввод данных
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
//Возведение числа в степень рекурсией
long MyPow(int a,int b)
{
    if(b==2)return a*a;
    if(b==1)return a;

    if(b%2==0)
    {
       return MyPow(a,b/2)*MyPow(a,b/2);
    }
    else
    {
       return MyPow(a,b/2)*MyPow(a,b/2+1);
    }
}
//Выводим решение
Console.Clear();
int number = ReadData("Введите число: ");
int stepen = ReadData("Введите степень числа: ");

PrintResult($"Число {number} в степени {stepen} = {MyPow(number, stepen)}");