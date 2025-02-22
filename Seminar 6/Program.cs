﻿// Семинар 6. Двумерные массивы и рекурсия

// Задача 39. Напишите программу, которая перевернет одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и тд).

// Console.Clear();
// int[] array = { 1, 2, 3, 4, 5 };
// int[] copyOfArray = CopyRevertArray(array);
// PrintArray(copyOfArray);
// PrintArray(array);
// int[] CopyRevertArray(int[] array)
// {
//     int[] copy = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         copy[i] = array[array.Length - 1 - i];
//     }
//     return copy;
// }
// void RevertArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }
// void PrintArray(int[] array)
// {
//     System.Console.WriteLine(string.Join(", ", array));
// }


// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существоваться треугольник
// со сторонами такой длины.
// *Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.Clear();

// int[] arrayTriangle = new int[3] { 10, 4, 5 };

// bool isTriangle(int[] array)
// {
//     bool flag = true;
//     for (int i = 0; flag && i < array.Length; i++)
//     {
//         flag = arrayTriangle[i] < (array.Sum() - array[i]);
//     }
//     return flag;
// }
// Console.WriteLine(isTriangle(arrayTriangle));


// Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int[] NumberTranslation(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[^(i + 1)];
        array[^(i + 1)] = temp;
    }
    return array;
}
int[] GetBinaryArray(int a)
{
    int[] array = new int[(int)Math.Log2(a) + 1];
    for (int i = 0; i < array.Length; i++)
    {
        array[^(i + 1)] = a % 2;
        a /= 2;
    }
    return array;
}
Console.WriteLine(GetBinaryArray(45));
