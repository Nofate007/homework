/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B,  
и возводит число А в целую степень B с помощью рекурсии. 
A = 3; B = 5 -> 243 (3⁵) 
A = 2; B = 3 -> 8 
*/ 
int getUserInt(string message) 
{ 
    Console.ForegroundColor = ConsoleColor.DarkCyan; 
    Console.WriteLine(message); 
    Console.ResetColor(); 
    int userInt = Convert.ToInt32(Console.ReadLine()); 
    return userInt; 
} 
int numberA = getUserInt("Введите число A"); 
int numberB = getUserInt("Введите число B"); 
int degreeOfNumber = printRange(numberA, numberB); 
Console.WriteLine($"Число {numberA} в степени числа {numberB} равно {degreeOfNumber}"); 
int printRange(int numberA, int numberB) 
{ 
    if (numberB <= 0) 
    { 
        return 1; 
    } 
    return numberA * printRange(numberA, numberB - 1); 
}
