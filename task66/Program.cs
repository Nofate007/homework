/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetDataFromUser(string message)
{
int result = 0;
Console.WriteLine(message);
result = Convert.ToInt32(Console.ReadLine());
return result;
}
int SumOfElement(int m, int n)

{
    if (n < m) return 0;
    else return (n + SumOfElement(m,n-1));
}
int mElement = GetDataFromUser("Введите значение M: ");
int nElement = GetDataFromUser("Введите значение N: ");
int sumElementov = SumOfElement(mElement,nElement);
Console.WriteLine($"сумму натуральных элементов в промежутке от M до N равно {sumElementov}");