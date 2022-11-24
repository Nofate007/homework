/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. 
4 -> 24 5 -> 120 
*/ 


int getNumberFromUser(string message) 
{ int result = 0;
Console.ForegroundColor = ConsoleColor.DarkGreen; 
Console.WriteLine(message);
Console.ResetColor();
result = Convert.ToInt32(Console.ReadLine()); 
return result; 
} 

int multOfRange (int start, int finish)
{
    int mult = 1;
    for (int i=start; i<= finish; i++)
    {
         mult *= i;    
    }

    return mult;
}


int userNumber = getNumberFromUser("введите N для посчета произведения 1.. N");
int mult= multOfRange (1, userNumber);
Console.WriteLine($"Произведение чисел от1 до N {userNumber}={mult}");