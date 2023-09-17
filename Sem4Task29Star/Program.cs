//Задание 29**
/*Дополнительно: Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал
Игорь, Антон, Сергей -> Антон*/
//Вводим данные
string ReadDataString(string msg)
{
    Console.Write(msg);
    string nameLine = "";
    nameLine = Console.ReadLine() ?? "0";
    return nameLine;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
//Генерируем имя из строки
string GenerateName(string nameL)
{
    string[] name = nameL.Split(',');
    Random index = new Random();
    int inexGen = index.Next(0, name.Length - 1);    
    string res = name[inexGen];
    return res;
}
//Результат
Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
PrintResult("Выбрано имя: " + 
GenerateName(ReadDataString("Введите имена через запятую: ")));
