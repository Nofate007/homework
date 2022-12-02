﻿/*
Задача 63: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/
int getUserInt(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}

int StartIndex = 10;//getUserInt("Введите максимальный элемент ряда");
printRange(StartIndex);


void printRange(int index)
{
    if (index != 0)
    {
        printRange(index - 1);
        Console.Write(index + ",");
    }
} 