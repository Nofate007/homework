/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int getNumberFromUser(string message)
{
int result = 0;
Console.WriteLine(message);
result = Convert.ToInt32(Console.ReadLine());
return result;
}

int drome (int inputdata)
{
int number1 = inputdata /10000;
int number2 = inputdata /1000 %10;
int number3 = inputdata /100 %10;
int number4 = inputdata /10 %10;
int number5 = inputdata  %10;
if (number1 ==number5)
    {
        if (number2 == number4)
        {
            Console.WriteLine("Да, введеное число - палиндром");
        }
    }
else Console.WriteLine("Нет, введеное число - не палиндром");
return inputdata;
}

int inputdata = getNumberFromUser("Введите пятизначное число: ");
if  (inputdata > 9999 && inputdata < 100000)
{
    int data = drome(inputdata);
}
else Console.WriteLine ("Число не пятизначное");
Console.WriteLine();