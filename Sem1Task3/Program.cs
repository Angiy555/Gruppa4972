Console.Write("Введите число номер дня недели: ");
int numDay = int.Parse(Console.ReadLine()??"0");

switch (numDay-1)
{
    case 0: Console.Write("Вами введен: ПОНЕДЕЛЬНИК");break;
    case 1: Console.Write("Вами введен: ВТОРНИК");break;
    case 2: Console.Write("Вами введена: СРЕДА");break;
    case 3: Console.Write("Вами введен: ЧЕТВЕРГ");break;
    case 4: Console.Write("Вами введена: ПЯТНИЦА");break;
    case 5: Console.Write("Вами введена: СУББОТА");break;
    case 6: Console.Write("Вами введено: ВОСКРЕСЕНИЕ");break;
    default: Console.Write("Введен неверный номер недели"); break;   
}