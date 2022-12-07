/*
            Задача 67: Напишите программу, которая будет принимать на вход число 
            и возвращать сумму его цифр.
            453 -> 12
            45 -> 9
            */
            int GetUserInt(string message)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine (message);
                Console.ResetColor();
                int userInt = Convert.ToInt32(Console.ReadLine());
                return userInt;
            }
            int userNumber = GetUserInt ("Введите число: ");
            Console.WriteLine();
            int sumOfDigit = GetSumOfDigit (userNumber);
            Console.WriteLine ($"Сумма цифр числа {userNumber} = {sumOfDigit}");

            int GetSumOfDigit (int userNumber)
            {
                if (userNumber == 0)
                {
                    return 0;
                }
                return userNumber % 10 + GetSumOfDigit (userNumber / 10);
            }