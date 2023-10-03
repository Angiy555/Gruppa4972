//Задание 61
/*Вывести первые N строк треугольника Паскаля.
Сделать вывод в виде равнобедренного треугольника*/
//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//Факториал
long Factoreal(int n)
{
    long res = 1;
    for(int i=1;i<=n;i++)
    {
        res=res*i;
    }
    return res;
}
//Построение треугольника Паскаля
void PrintPascalTriangle(int nRow)
{
    for(int i=0;i<nRow;i++)
    {
        for(int k =0;k<nRow-i;k++)
        {
            Console.Write(" ");
        }

        for(int j =0; j<=i;j++)
        {
           Console.Write(" ");
           Console.Write(Factoreal(i)/(Factoreal(j)*Factoreal(i-j)));
        }
        Console.WriteLine();
    }
}
//Выводим решение
Console.Clear();
int countRow = ReadData("Введите количество строк треугольника Паскаля: ");
PrintPascalTriangle(countRow);