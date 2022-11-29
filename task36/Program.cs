/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19  [-4, -6, 89, 6] -> 0 */ 
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
int getDataFromUser(string message)
{
int result = 0;
Console.WriteLine(message);
result = Convert.ToInt32(Console.ReadLine());
return result;
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
int FindNumber (int []array)
{
    int sumNechet =0;
    for (int i=1; i< array.Length;)
    {
        {
            sumNechet = sumNechet + array [i];
            i=i+2;
            //Console.WtiteLine(sumNechet);
        }
    }
    return sumNechet;
}
int userNumber = getDataFromUser("Введите число элементов массива: ");
int[] array = GenerateRandomArray( userNumber,-99,100);
printArray(array);
int findNechetNumber = FindNumber (array);
Console.WriteLine($"Сумма элементов на нечетных позициях массива равно {findNechetNumber}");