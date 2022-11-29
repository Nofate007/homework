/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, к
оторая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
int[] GenerateRandomArray(int length,int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint+1);
    }
    return resultArray;
}
int FindDigits (int []array)
{
    int sumChet=0;
    for (int i=0; i< array.Length; i++)
    {
          if (array[i] %2== 0)
        {
            sumChet = sumChet +1;
        }
    }
    return sumChet;
}


int[] array = GenerateRandomArray(5,1,1000);
printArray(array);
int findDigit = FindDigits (array);
Console.WriteLine($"Количество четных элементов массива равно {findDigit}");


