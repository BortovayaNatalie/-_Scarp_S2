﻿// Урок 2. Простые Алгоритмы
// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
using System;
class Program
{
    static void Main()
    {
    Console.Write("Введите число a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a % 7 == 0 && a % 23 == 0)
        {
            Console.WriteLine("да");
        }
    else
        {
            Console.WriteLine("нет");
        }
    }
}





// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

