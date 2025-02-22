﻿// Семинар 8

// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

// Console.Clear();

// int[,] ChangeArray(int[,] array)
// {
//     int temp;
//     int rows = array.GetLength(0);
//     int cols = array.GetLength(1);
//     for (int i = 0; i < cols; i++)
//     {
//         temp = array[0, i];
//         array[0, i] = array[rows - 1, i];
//         array[rows - 1, i] = temp;
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] array = new int[,] {{1, 4, 7, 2},
//                            {5, 9, 2, 3},
//                            {8, 4, 2, 4}};

// ChangeArray(array);
// PrintArray(array);


// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести сообщение для пользователя.
// [nXn]
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Console.Clear();

// int[,] ChangeArray(int[,] array)
// {
//     int temp;
//     int rows = array.GetLength(0);
//     int cols = array.GetLength(1);
//     int[,] arrayCopy = new int[cols, rows];
//     for (int i = 0; i < cols; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//              arrayCopy[i, j]= array[j, i];
//             // array[i, j] = array[j, i];
//             // array[j, i] = temp;
//         }
//     }
//     return arrayCopy;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] array = new int[,] {{1, 4, 7, 2},
//                            {5, 9, 2, 3},
//                            {8, 4, 2, 4},
//                            {5, 2, 6, 7,}};

// int[,] copyArray = ChangeArray(array);
// PrintArray(copyArray);


// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Пример. Есть набор данных:

// { 1, 9, 9, 0, 2, 8, 0, 9 }
// Частотный массив можно представить так:
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// Console.Clear();

// void FindRepeatElementsInArray(int[,] array)
// {
//     int rows = array.GetLength(0);
//     int cols = array.GetLength(1);

//     int element = array[0, 0];
//     int count = 0;
//     for (int k = 0; k < rows; k++)
//     {
//         for (int i = 0; i < cols; i++)
//         {
//             element = array[k, i];
//             for (int j = 0; j < rows; j++)
//             {
//                 for (int m = 0; m < cols; m++)
//                 {
//                     if (array[j, m] == element)
//                     {
//                         count++;
//                     }
//                 }
//             }
//             System.Console.WriteLine($"{array[k, i]} встречается {count}");
//             count = 0;
//         }
//     }
//     System.Console.WriteLine(count);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] array = new int[,] {{1, 4, 7, 2},
//                            {5, 9, 2, 3}};

// FindRepeatElementsInArray(array);


void SpiralFillArray(int[,] array, int i = 0, int j = 0, int num = 1, int direction = 0)
{
    if (i < 0 || i >= array.GetLength(0)
     || j < 0 || j >= array.GetLength(1)
     || array[i, j] != 0)
    {
        return;
    }

    int[,] step = {
        { 0, 1, 0, -1 },    // rows (i) -> right, down i+1, left, up i-1
        { 1, 0, -1, 0 }     // columns (j) -> rigth j+1, down, left j-1, up
    };

    array[i, j] = num++;

    for (int t = 0; t < 4; t++)
        {
        SpiralFillArray(
            array,
            i + step[0, (direction + t) % 4],
            j + step[1, (direction + t) % 4],
            num,
            (direction + t) % 4
        );
    }
}

int[,] array = new int[5, 6];
SpiralFillArray(array);
//PrintArray(array);
