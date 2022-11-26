/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/ 


int[] GenerateRandomArray(int length,int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint+1);
    }
    return resultArray;
}

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

int countNumberInRange (int []array)
{
    
    int result = 0;
    for( int i=0; i<array.Length;i++)
    {
        if (array[i]>=10 && array[i]<=99)
        {
            result +=1 ;
        } 
    }
    return result;
}

int[] array = GenerateRandomArray(20,0,500); //20 случайных чисел в отрезке 0-1000
printArray(array);
int count = countNumberInRange(array);
Console.WriteLine(count);
