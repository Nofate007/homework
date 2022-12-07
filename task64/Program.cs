/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
int GetDataFromUser(string message)
{
int result = 0;
Console.WriteLine(message);
result = Convert.ToInt32(Console.ReadLine());
return result;
}
void printRange(int index)
{
    if (index >= 1)
    {
        Console.Write(index + ",");
        printRange(index - 1);
    }
} 
int maxElement = GetDataFromUser("Введите значение N: ");
Console.WriteLine(maxElement);
printRange(maxElement);


