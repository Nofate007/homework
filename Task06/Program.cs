/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

int userNumber1 = new int();                              //  объявляем переменную и присваиваем значение
Console.Write("Введите число ");         
userNumber1 = Convert.ToInt32(Console.ReadLine());        // считывае из консоли значени6е "строки" и получаем из "строки"  "число" 
Console.WriteLine(userNumber1);    


int chet = 1;

chet = userNumber1 %2;
//Console.Write("число ");   
//Console.WriteLine(chet);   

if (chet == 0)
{
    Console.Write("Введeное число четное");  
}
else
{
    Console.Write("Введeное число нечетное");  
}