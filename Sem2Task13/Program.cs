﻿//Задание 13*
/*Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей 
цифры нет.
* Сделать вариант для числа длиной до 10 цифр 
не используя char или string*/
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()??"0");//Принимаем первое число

if (num > 100)
{
    //Находим третью цифру и выводим ее
    Console.Write("Третья цифра числа: " + num + " является " + num/100%10);
}
else
{
    //Если у числа нет третьей цифры выводим сообщение
    Console.Write("У числа " + num +" нет третье цифры");
}