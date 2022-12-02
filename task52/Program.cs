/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.  */
int GetDataFromUser(string message)
{
int result = 0;
Console.WriteLine(message);
result = Convert.ToInt32(Console.ReadLine());
return result;
}
int[,] generate2DArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow, lengthCol];
    {
        for (int i = 0; i < lengthRow; i++) { for (int j = 0; j < lengthCol; j++) { array[i, j] = new Random().Next(0,10); } }
    }
    return array;
}
void print2dArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++)
     { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
        Console.Write(array[i, j] + "\t"); 
        }
    Console.WriteLine(); 
    }
}
void GetSrSumOfCol (int[,] array, int lengthCol, int lengthRow,  double summa ) 
{
       for (int j = 0; j < lengthCol; j++)
       {
        summa=0;
        for (int i = 0; i < lengthRow; i++) 
            {
            summa = summa + array[i,j];
            }
        summa = summa / lengthRow;       
        Console.WriteLine($"Среднее арефмитическое столбца {j} равно {Math.Round(summa ,3) }");
        }
}
double sum = 0;
int col = GetDataFromUser("Введите числох столбцов : ");
int row = GetDataFromUser("Введите числох строк : ");
int[,] array = generate2DArray(row,col , 1);
print2dArray(array); 
GetSrSumOfCol (array, col, row, sum);