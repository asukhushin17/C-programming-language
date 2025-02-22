﻿// // Лекция 3. Функции (методы): продолжение

// // Виды методов:

// // Метод 1
// void Method1 ()
// {
//     System.Console.WriteLine("Автор ...");
// }
// //Method1();

// // Метод 2
// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }
// //Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i=0;
//     while (i < count)
//     {
//         System.Console.WriteLine(msg);
//         i++;
//     }
// }
// //Method21(msg: "Текст сообщения", count: 4);

// // Метод 3
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// //int year = Method3();
// //System.Console.WriteLine(year);

// // Методы 4
// // string Method4(int count, string text)
// // {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
//}
//string res = Method4(10, "0");
//System.Console.WriteLine(res);

// Циклы и не только "While", но еще и "For"

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "0");
// System.Console.WriteLine(res);

// Цикл в цикле - Таблица умножения!

// for(int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         System.Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     System.Console.WriteLine();
// }

// Задача 1. Работа с текстом. Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы 
//"к" заменить большими буквами "К", а большие буквы "С" заменить на маленькие "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежили бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // srting s = "qwerty"
// //             012345
// // s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = Replace(text, 'с', 'С');
// System.Console.WriteLine(newText);

// Упорядочивание массива!

// 6 8 3 2 1 4 5 7

int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);