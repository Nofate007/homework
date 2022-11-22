/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int userNumber1 = new int();                              
Console.Write("Введите первое число ");         
userNumber1 = Convert.ToInt32(Console.ReadLine());         
Console.WriteLine(userNumber1);    

int userNumber2 = new int();                              
Console.Write("Введите второе число ");         
userNumber2 = Convert.ToInt32(Console.ReadLine());         
Console.WriteLine(userNumber2);    

int userNumber3 = new int();                              
Console.Write("Введите третье число ");         
userNumber3 = Convert.ToInt32(Console.ReadLine());        
Console.WriteLine(userNumber3);  

int max = new int();

if (userNumber1  > userNumber2) 
     {
     max = userNumber1;
     }
else
{
     max = userNumber2;
}
     if (userNumber2 > userNumber3)
     {
     max = userNumber2;
          }
     else
     {
     max = userNumber3;
     }
if (userNumber3 > userNumber1 )
{
        max = userNumber3;
}
else
{
    max = userNumber1;
}

Console.WriteLine();
Console.Write("Максимальное число: ");  
Console.WriteLine(max);