/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];
int[,] array3 = new int[2, 2];
void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"Введите {i} {j} элементы матрицы 2Х2:");
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
int[,] ProizvedenieMatrx(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array3[i,j] = 0;

            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i, j] = array3[i, j] +(array1[i, k] * array2[k, j]);
            }
        }
    }
    return array3;
}
Console.WriteLine($"Первая матрица 2Х2:");
FillArray(array1);
PrintArray(array1);
Console.WriteLine($"Вторая матрица 2Х2:");
FillArray(array2);
PrintArray(array2);
Console.WriteLine($"Произведение двух матриц будет матрица 2Х2:");
int [,] matrix = ProizvedenieMatrx(array1, array2);
PrintArray(matrix);
