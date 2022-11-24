/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/


int getDataFromUser(string textdata)
{
int outData = 0;
Console.WriteLine(textdata);
outData = Convert.ToInt32(Console.ReadLine());
return outData;
}



int tablitsaKubov (int inputData)
{
    for (int i=1; i<inputData+1; i++)
    {
        double kub = Math.Pow(i, 3);                //возведение числа в степень 
        Console.Write($"{kub} "); 
    }
return inputData;
}



Console.Write("Введите число N"); 
int number = getDataFromUser(" ");
Console.WriteLine("кубы чисел от 1 до N ");
double kub = tablitsaKubov(number);