/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12  */ 
int getDataFromUser(string message)
{
int result = 0;
Console.WriteLine(message);
result = Convert.ToInt32(Console.ReadLine());
return result;
}
int sumOfDigit( int inputData, int chisloTsyfr )
{
int dec=1;
int sum=0 ;
    for ( int i = 1; i <= chisloTsyfr; i++)
        {
           int number = inputData /dec %10;
            sum = sum+ number;
            dec= dec*10;
        }
        Console.WriteLine($" Итоговая сумма {sum} ");
return sum;
}
int userNumber = getDataFromUser("Введите целое число (максимально 9 знаков ): ");
int numberOfInputDigits =Convert.ToString(userNumber).Length;
Console.WriteLine($"Введенное чило состоит из {numberOfInputDigits} цифр");
if (numberOfInputDigits <= 9)
    {
    int summa = sumOfDigit(userNumber,numberOfInputDigits);
    }
else Console.WriteLine($"Это большое чем 9 знаков!");
