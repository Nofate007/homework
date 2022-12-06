/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой 
элементов. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int[,] Generate2DArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(0, deviation);
        }
    }
    return array;
}
void printColor(string information, ConsoleColor color, bool newLine = false)
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
    if (newLine)
    {
        Console.WriteLine();
    }
}
void print2dArray(int[,] array, string Name = "")
{
    printColor(Name, ConsoleColor.DarkCyan, true);
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
          printColor(i + "\t", ConsoleColor.DarkYellow,(i >= array.GetLength(1) - 1));
    }
        for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i + "\t", ConsoleColor.DarkYellow);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int FindSummaInLine (int [,] array, int i)
{
    int summaline = array [i,0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            summaline = summaline + array[i,j];      
        }
return summaline;
}
int FindLine (int [,] array)
{
    int numberOfLine = 0;
    int minSummOfLine = FindSummaInLine (array, 0);
    for (int k = 1; k < array.GetLength(0); k++)
        {
            int sumOfLine = FindSummaInLine (array, k);
                if (minSummOfLine > sumOfLine)
                    {
                        minSummOfLine = sumOfLine;
                        numberOfLine = k;
                    }
        }
return numberOfLine;
}
int[,] generatedArray = Generate2DArray(4,4,10);
print2dArray(generatedArray, "Изначальный массив");
int minStroka = FindLine(generatedArray);
Console.WriteLine($" строка j = {minStroka} имеет наименьшую сумму элементов.");
