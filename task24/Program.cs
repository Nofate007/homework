/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/



int sumOfRange(int start, int finish)
{
    int sum = 0;
    for (int i=start; i<= finish; i++)
    {
        sum += i;    //sum=sum +1;
    }
    return sun;
}

int getDataFromUser(string mesage)
{
int result = 0;
Console.ForegroundColoor = ConsoleColor.DarkGreen;
Console.WriteLine(mesage);
Console.ResetColor();
data = Convert.ToInt32(Console.ReadLine());
return result;
}

int userNumber = getDataFromUser( "Введите А для расчета суммы от1 до А");
int sum= sumOfRange(1,userNumber);

Console.WriteLine($"Сумма чисел от1 до {userNumber} = {sum}");

