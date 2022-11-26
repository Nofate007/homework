/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21

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

int multElementsOfArray(int[] array)
{
    lenghtNewArray = array.Lenght / 2 
        if (array.Lenght % 2 != 0)
        {
            lenghtNewArray=lenghtNewArray+1;
        }
    int[] newArray = new int[lenghtNewArray];
            
    for (int i = 0; i < array.Length/2; i++)
    {
       newArray[i]= array[i]* array[array.Length-i]
    }
    return newArray;
}
















int[] array = GenerateRandomArray(20,0,500); //20 случайных чисел в отрезке 0-1000
printArray(array);
int [] mult = multElementsOfArray(array);
printArray(array); //new array

