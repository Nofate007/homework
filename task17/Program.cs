﻿/*
Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

int GetQuarterFromCoordinate(int x, int y)
{
    int quarter = 0;
    if (x > 0 && y > 0)
    {
        quarter = 1;
    }
    else if (x < 0 && y > 0)
    {
        quarter = 2;
    }
    else if (x < 0 && y < 0)
    {
        quarter = 3;
    }
    else if (x > 0 && y < 0)
    {
        quarter = 4;
    }
    return quarter;
}
int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void showInformationAboutQuarter(int x, int y, int quarter)
{
    if (quarter != 0)
    {
        Console.WriteLine($"Точка с координатами [{x}:{y}] находиться в {quarter} четверти ");
    }
    else
    {
        Console.WriteLine($"Точка с координатами [{x}:{y}] находиться оси координат ");
    }
}
int x = getNumberFromUser("Введите X:");
int y = getNumberFromUser("Введите Y:");
int quarter = GetQuarterFromCoordinate(x, y);
showInformationAboutQuarter(x, y,quarter);


