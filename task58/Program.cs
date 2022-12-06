/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.WriteLine($"Введите {i} {j} элементы матрицы 2Х2:");
      array[i, j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}
void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  } 
}




Console.WriteLine($"Первая матрица 2Х2:");
int[,] array = new int[2, 2];
FillArray(array);
System.Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Вторая матрица 2Х2:");
int[,] array2 = new int[2, 2];
FillArray(array2);
System.Console.WriteLine();
PrintArray(array2);
Console.WriteLine($"Произведение двух матриц будет матрица 2Х2:");

PrintArray(array2);



