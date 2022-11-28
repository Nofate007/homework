/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/ 
int inputUserNumber(string userMessage)
{
    Console.WriteLine(userMessage);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

string FibonachyString(int number)
{
    int buf = 0;
    string result = "";
    if (number == 1 || number == 2)
    {
        result = "1";
    }
    else
    {
        result = "0 1";
        int buf1 = 0;
        int buf2 = 1;
        for (int i = 2; i <= number; i++)
        {
            
            buf = buf1 + buf2;
            buf2 = buf1;
            buf1 = buf;
            result = result + " " + buf;
            
        }
    }
    return result;
}


int userNumber = inputUserNumber("Введите число N");
string fibNumb = FibonachyString(userNumber);
Console.WriteLine(fibNumb);