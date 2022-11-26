/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/


//TO DO заменить из чата
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

bool fibdNumberArray(int[] array, int Number)
{
    bool findInArray = false;
    for (i=0; i < array.Lenght; i++)
    {
        if (array[i]== Number)
        {
            findInArray =true;
            break;
        }
    }
    return findInArray;
}


int[] array = GenerateRandomArray(5,-9,9);
printArray(array);
bool isFibdNumberArray = fibdNumberArray(array, 5);
if (isFibdNumberArray) 
    Console.Writeline("YES");
else
    Console.Writeline("No");