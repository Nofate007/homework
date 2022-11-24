/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// длина отрезка в 3D пространстве равна Корень квадратный из ((x1-x2)^2+(y1-y2)^2+(z1-z2)^2),
int getNumberFromUser(string message)                                                       //введение координат
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
double FindDistance ( int x1, int x2, int y1, int y2, int z1, int z2)                       //получение длины в3Д
{
    double sum =  Math.Pow((x1 - x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2);
    double distance = Math.Sqrt(sum);
    Console.WriteLine(distance);
    return distance;
}
int x1 = getNumberFromUser("Введите X1:");
int y1 = getNumberFromUser("Введите Y1:");
int z1 = getNumberFromUser("Введите Z1:");
int x2 = getNumberFromUser("Введите X2:");
int y2 = getNumberFromUser("Введите Y2:");
int z2 = getNumberFromUser("Введите Z2:");

Console.WriteLine($"Расстояние между точками А и В равно ");
double distance = FindDistance (x1, x2, y1, y2, z1, z2);