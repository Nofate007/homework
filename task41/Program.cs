/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2            1, -7, 567, 89, 223-> 3   */
void PrintArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
    }
    Console.WriteLine("]");
}
int GetDataFromUser(string message)
{
int result = 0;
Console.WriteLine(message);
result = Convert.ToInt32(Console.ReadLine());
return result;
}
int [] InputUserArray (int length, int start, int end)
{
    int [] array = new int [length];
    for (int i = 0; i < array.Length; i++)
        {
        Console.Write($"Введите {i} 'лемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());;                    
        }
    return array;
 }
int GetPlusElement(int[]array)
{
    int sum=0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] > 0)
        {
        sum = sum +1;
        }
    }
return sum; 
}
int userNumber = GetDataFromUser("Введите число M вводимых элементов : ");
int [] userArray = InputUserArray(userNumber,-999, 1000);
Console.WriteLine();            
PrintArray(userArray);
int plusElement = GetPlusElement(userArray);
Console.WriteLine(($"Число вводимых положительных элементов равно: {plusElement} "));   

