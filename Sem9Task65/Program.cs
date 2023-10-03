//Задание 65
/*Вывести строку чисел в порядке возростания от m до n*/
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
// Формирование строки с числами
string SearchForNaturalElementsRec (int m, int n)
{
    return n >= m ? $"{m} " + SearchForNaturalElementsRec(m + 1, n) : "";
}
//Выводим решение
Console.Clear();
int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
PrintResult((m>n)?SearchForNaturalElementsRec(n, m):SearchForNaturalElementsRec(m, n));