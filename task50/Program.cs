/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет. */
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
        for (int i = 0; i < lengthRow; i++) 
        { 
            for (int j = 0; j < lengthCol; j++) 
                { 
                array[i, j] = new Random().Next(-deviation,deviation +1); 
                }
        }
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
int col = GetDataFromUser("Введите числох столбцов : ");
int row = GetDataFromUser("Введите числох строк : ");
int[,] array = generate2DArray(row,col , 10);
print2dArray(array); 
int indexlin = GetDataFromUser("Введите линейный индекс числа для поиска: ");
if (indexlin < col*row)
{
    int j = indexlin% col;
    Console.WriteLine($"cтолбец {j}");
    int i = indexlin/ col;
    Console.WriteLine($"cтрока {i}");
    Console.WriteLine ($"Элемент массива :  {array [i,j]}");
}
else
{
Console.WriteLine("такого элемента нет");
}