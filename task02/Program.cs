/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int userNumber1 = new int();                              //  объявляем переменную и присваиваем значение
Console.Write("Введите первое число ");         
userNumber1 = Convert.ToInt32(Console.ReadLine());        // считывае из консоли значени6е "строки" и получаем из "строки"  "число" 
Console.WriteLine(userNumber1);    


int userNumber2 = new int();                              //  объявляем переменную и присваиваем значение
Console.Write("Введите второе число ");         
userNumber2 = Convert.ToInt32(Console.ReadLine());        // считывае из консоли значени6е "строки" и получаем из "строки"  "число" 
Console.WriteLine(userNumber2);    



if (userNumber1 > userNumber2)
{
    Console.Write("максимальное число : ");  
    Console.WriteLine(userNumber1);    
}
else
{
    Console.Write("максимальное число : ");  
    Console.WriteLine(userNumber2);    
}