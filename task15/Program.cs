/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/


// Создадим функция получения случайного дня недели
int weekDay (int start, int end)  
{
    int resulut = 0;                                    
    resulut = new Random().Next(start, end + 1);        
    return resulut;                                     
}



int randomDay = weekDay(1,7);
Console.WriteLine("случайное число дня недели");
Console.WriteLine(randomDay);

if (randomDay > 5)
{
    Console.WriteLine("день недели является выходным");
}
else
{
    Console.WriteLine("день недели является рабочим");
}