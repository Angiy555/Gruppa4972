//Задание 11
/*Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает вторую
цифру этого числа.*/

System.Random numberGenerator = new System.Random();
int num = numberGenerator.Next(100,1000);//Получаем случайное трехзначное число

Console.WriteLine(num);//Выводим его

int twoNum = num%100;//Отбрасываем первую цифру
int secondDigit = twoNum/10;//Получаем вторую цифру
//Выводим вторую цифру
Console.WriteLine("Вторая цифра числа: " + secondDigit);

