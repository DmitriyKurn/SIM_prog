﻿//  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int max = 0;

Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number > max)
{
    max = number;
}
if(number1 > max)
{
    max = number1;
}
if(number2 > max)
{
    max = number2;
}

Console.WriteLine("max = " + max);
