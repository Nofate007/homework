/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] CreateArray(int N,int min, int max)
{
    int [] arr = new int [8];
    for (int i=0; i <N; i++)
    {
        arr [i] = new Random().Next(min, max+1);
    }
    return arr;
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
Console.WriteLine ("Программу задаёт массив из N=8  (двузначных) элементов и выводит их на экран.");
int[] array = CreateArray(8,0,99);
printArray(array);
