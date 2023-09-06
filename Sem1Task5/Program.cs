Console.Write("Введите число N: ");
int numN = int.Parse(Console.ReadLine()??"0");

int evnumN = -numN;

while (evnumN < numN)
{
    Console.Write(evnumN +",");
    evnumN++;
}
Console.WriteLine(numN);