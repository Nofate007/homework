﻿/*
Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник с сторонами такой длины.
*/
double inputUserData(string userMessage)
{

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(userMessage);
    Console.ResetColor();
    double userData = Convert.ToDouble(Console.ReadLine());
    return userData;
}
bool isTriangleExists(double side1, double side2, double side3)
{
    bool isSide1Smaller = side1 < side2 + side3;
    bool isSide2Smaller = side2 < side1 + side3;
    bool isSide3Smaller = side3 < side2 + side1;
    bool isExists = (isSide1Smaller && isSide2Smaller && isSide3Smaller);
    return isExists;
void showInfoAboutTriangle(double side1, double side2, double side3, bool triangleExist)
{
    string existString = "не существует";
    if (triangleExist)
    {
        existString = "существует";
    }
    Console.WriteLine($"треугольник со сторонами {side1},{side2},{side3} {existString}");
}

double side1 = inputUserData("Введите длину первой стороны треугольника");
double side2 = inputUserData("Введите длину вторую стороны треугольника");
double side3 = inputUserData("Введите длину третью стороны треугольника");
bool triangleExist = isTriangleExists(side1, side2, side3);
showInfoAboutTriangle(side1, side2, side3,triangleExist);
