/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. 
[3 7 22 2 78] -> 76   */
void printArray(double[] array)
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
int getDataFromUser(string message)
{
int result = 0;
Console.WriteLine(message);
result = Convert.ToInt32(Console.ReadLine());
return result;
}
double[] GenerateRandomArray(int length,int startPoint, int endPoint)
{
    double[] resultArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint+1);
    }
    return resultArray;
}
double FindMaxElenent (double []array)
{
    double maxEl = array [0];
    //Console.WriteLine($" o проход Макс Элемент {maxEl}");
    for (int i=1; i< array.Length;i++)
    {
        if (array[i] >  maxEl)
        {
            maxEl = array [i];
            //Console.WriteLine($"Прход цикла {i} макс Элемент {maxEl}");
        }
    }
    return maxEl;
}
double FindMinElenent (double []array)
{
    double minEl = array [0];
    //Console.WriteLine($" o проход Мин Элемент {minEl}");
    for (int i=1; i< array.Length;i++)
    {
        if (array[i] <  minEl)
        {
            minEl = array [i];
            //Console.WriteLine($"Прход цикла {i} мин Элемент {minEl}");
        }
    }
    return minEl;
}
int userNumber = getDataFromUser("Введите число элементов массива: ");
double[] array = GenerateRandomArray( userNumber,-99,100);
printArray(array);
double max = FindMaxElenent (array);
double min = FindMinElenent (array);
double dif = max - min;
Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементами массива равно {dif}");