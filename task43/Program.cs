/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)  */

double GetDataFromUser(string message)
{
double result = 0;
Console.WriteLine(message);
result = Convert.ToInt32(Console.ReadLine());
return result;
}
void GetCrossPoint (double k1, double b1, double k2, double b2)
{
    double x=(b2-b1)/(k1-k2);
    //double y= k1*x+b1;  или использовать эту команду
    double y= k2*x+b2;
    Console.WriteLine($"Точа пересечения двух прямых {x} и {y}");
}
double k1 = GetDataFromUser("Введите числох k1 : ");
double b1 = GetDataFromUser("Введите числох b1 : ");
double k2 = GetDataFromUser("Введите числох k2 : ");
double b2 = GetDataFromUser("Введите числох b2 : ");
GetCrossPoint( k1, b1, k2, b2);