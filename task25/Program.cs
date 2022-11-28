/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/ 
int getDataFromUser(string message)
{
int result = 0;
Console.WriteLine(message);
result = Convert.ToInt32(Console.ReadLine());
return result;
}
int vozvedeniyStepeny(int a, int b)
{
    int c = 1;
    int i = 1;
    while (i <= b)
        {
            c = c*a;
            i++;
        }
return c;
}

int numberA = getDataFromUser("Введите целое число A: ");
Console.WriteLine($" Число А равно: {numberA}");
int numberB = getDataFromUser("Введите целое число B: ");
Console.WriteLine($" Число И равно: {numberB}");
int stepen = vozvedeniyStepeny(numberA,numberB );
Console.WriteLine($" Число А возведенное в степень B равно: {stepen}");