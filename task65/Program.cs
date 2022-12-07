/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
M = 1; N = 5 -> "1, 2, 3, 4, 5" 
M = 4; N = 8 -> "4, 5, 6, 7, 8" 
*/


int getUserInt(string message) 
{ 
    Console.ForegroundColor = ConsoleColor.DarkCyan; 
    Console.WriteLine(message); 
    Console.ResetColor(); 
    int userInt = Convert.ToInt32(Console.ReadLine()); 
    return userInt; 
} 
int numberM = getUserInt("Введите число M"); 
int numberN = getUserInt("Введите число N"); 
maxNumber(numberM, numberN); 
 
void maxNumber(int numberM, int numberN) 
{ 
    int max = numberM; 
    int min = numberN; 
    if (numberM < numberN) 
    { 
        max = numberN; 
        min = numberM; 
    } 
    printRange(min, max); 
} 
 
void printRange(int numberM, int numberN) 
{ 
    if (numberM <= numberN) 
    { 
        printRange(numberM, numberN - 1); 
        Console.Write(numberN + ", "); 
    } 
}

/*
int getUserInt(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}
void maxNumber(int numberM, int numberN)
{
int max=numberM;
int min=numberN;
    if (numberM > numberN)
    {
        max = numberN;
        min = numberM;
    }
    printRange(min, max);
    //return;
}

void printRange(int numberM, int numberN )
{
    if (numberM <= numberN)
    {
        printRange(numberM, numberN-1);
        Console.Write(numberN + ",");
    }

}
int numberM = getUserInt("Введите число M");
int numberN = getUserInt("Введите число N");
maxNumber(numberM,numberN);

*/