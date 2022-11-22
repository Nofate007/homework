/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


// Создадим функция получения случайного числа в отрезке
int GetRandomNumberInRange (int start, int end)         // start end - задаем граничные параметры для отрезка (входный знвчения)
{
    int resulut = 0;                                    //  вводим переменную result равную 0
    resulut = new Random().Next(start, end + 1);        //  присваиваем ее значение из отрезка (+1 для того чтобы включить последнее(последнее не включается))
    return resulut;                                     //  выводим значение (выходные знвчения)
}


// Создадим функция получения второй цифры числа

int GetDigitTwo(int number)                                // (входный знвчения)
{
    int digitProm = number / 10;                           // выдаст вторую и третью цифру трехзначного числа (слева)
//    Console.WriteLine(digitProm);                          // выводим и смотрим вторую и третью цифру трехзначного числа (слева)
    int digitTwo = digitProm %10;                          // выдаст вторую и цифру трехзначного числа (слева)
    return digitTwo;                                       //  выводим значение второй цифры (выходные знвчения)
}                          




int randomNumber = GetRandomNumberInRange(100,1000);
Console.WriteLine("случайное трхзначное число");
Console.WriteLine(randomNumber);

int outdata = GetDigitTwo(randomNumber);
Console.WriteLine("вторая цифра трхзначного числа");
Console.WriteLine(outdata);



