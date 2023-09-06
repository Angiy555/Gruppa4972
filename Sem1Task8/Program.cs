Console.Write("Введите число больше 1: ");
int numN = int.Parse(Console.ReadLine()??"0");
int numEven = 0;
if (numN > 1)
{
    Console.Write("Четные числа: ");
    for (int i = 2; i < numN; i++)
    {
        numEven = i%2;
        if (numEven == 0)
        {
            Console.Write(i + ",");
        }
    }
    if (numN%2 == 0)
    {
         Console.Write(numN);
    }
   
}
else
{
    Console.Write("Введено неверное число");
}


