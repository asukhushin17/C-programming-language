﻿// Дополнительная Задача 9
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int MulDigit(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
    {
        System.Console.Write("Кратно одновременно 7 и 23, число: ");
    }
    else
    {
        System.Console.Write("Не кратно одновременно 7 и 23, число: ");
    }
    return number;
}
int myNumber = 165;
System.Console.WriteLine(MulDigit(myNumber));
