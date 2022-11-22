﻿/*
задача 9
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Например:
78 -> 8
12-> 2
85 -> 8
*/



// Создадим функция получения случайного числа в отрезке
int GetRandomNumberInRange (int start, int end)         // start end - задаем граничные параметры для отрезка (входный знвчения)
{
    int resulut = 0;                                    //  вводим переменную result равную 0
    resulut = new Random().Next(start, end + 1);        //  присваиваем ее значение из отрезка (+1 для того чтобы включить последнее(последнее не включается))
    return resulut;                                     //  выводим значение (выходные знвчения)
}

// Создадим функция получения наибольшего числа
//(int - те число будет без запятых (отбросим остаток) при делении иначе надо использовать duble
int GetMaxDigitFromNumber(int number)                   // (входный знвчения)
{
    
    int max = number / 10;                              // выдаст первую цыфру двузначного числа. Будем считать ее максимальной (int - те число будет без запятых)
    int secondDigit = number % 10;                      // выдаст вторую цыфру двузначного числа (int - те число будет без запятых)
    if (secondDigit > max)
    {
        max = secondDigit;
    }
    return max;                                         //  выводим значение максимального (выходные знвчения)
}                          

// создадим основную части для послудующего цикла (будем получать несколько раз значение) VOID - говорит о том что ничего не возвращается
void main()
{
int randomNumber = GetRandomNumberInRange(10,99);       // получаем случайное число с помощью фунции GetRandomNumberInRange (вызов функции)
int maxDigit = GetMaxDigitFromNumber(randomNumber);      // получаем  число maxDigit c помощью GetMaxDigitFromNumber, передавая randomNumber

// Сделаем вывод знвчения
Console.WriteLine($"Для числа {randomNumber} большим цифрой является {maxDigit}");        // cw - Console.WriteLine();  $ - все переменные в фигурных скобках будут заменены на их значение
}


// создадим цикл , сколько раз будем повторять получение значения случайного число из отрезка [10, 99] и показывая наибольшую цифру числа.
for (int i =0; i<30; i++)   //i - счетчик повторения. повторяем 30 раз
{
    main();
}






