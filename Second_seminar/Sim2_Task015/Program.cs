// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.(использовать И и ИЛИ)
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int number)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("этот день выходной");
    }
    else if (number < 1 || number > 7)
    {
        Console.WriteLine("это вообще не день недели");
    }
    else Console.WriteLine("этот день не выходной");
}

CheckingTheDayOfTheWeek(number);
