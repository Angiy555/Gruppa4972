//Задание 25*
/*Написать калькулятор с операциями +, -, /, * и возведение в степень*/
//Вводим данные
double ReadData(string msg)
{
    Console.Write(msg);
    double num = double.Parse(Console.ReadLine() ?? "0");
    return num;
}
//Вводим знак
string ReadSign(string msg)
{
    Console.Write(msg);
    string res = Console.ReadLine() ?? "0";
    return res;
}
//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
//Возведение числа А в степень В
double PowNumber(double numA, double numB)
{
    double res = numA;
    for (int i = 1; i < numB; i ++)
    {
        res = res * numA;
    }
    return res;
}
//Сложение
double SumNumber(double numA, double numB)
{
    double res = numA + numB;
    return res;
}
//Вычитание
double SubNumber(double numA, double numB)
{
    double res = numA - numB;
    return res;
}
//Умножение
double MultiplicationNumber(double numA, double numB)
{
    double res = numA * numB;
    return res;
}
//Деление
double DivisionNumber(double numA, double numB)
{
    double res = numA / numB;
    return res;
}
//Калькулятор
double CalculatorNumber(double numA, string sing, double numB)
{
   double res = 0;
   if (sing == "+")
   {
        res = SumNumber(numA, numB);
        return res;
   }
   if(sing == "-")
   {
        res = SubNumber(numA, numB);
        return res;
   }
   if(sing == "*")
   {
        res = MultiplicationNumber(numA, numB);
        return res;
   }
   if(sing == "/")
   {
        res = DivisionNumber(numA, numB);
        return res;
   }
   if(sing == "^")
   {
        res = PowNumber(numA, numB);
        return res;
   }
   else
   {
        Console.Write("Введено не верное действие: ");
        return res;
   }
}

double numAR = ReadData("Введите число А: ");
string singR = ReadSign("Введите действие (+, -, *, /, ^): ");
double numBR = ReadData("Введите число B: ");
double res = CalculatorNumber(numAR, singR, numBR);
PrintResult("Результат: " + res);