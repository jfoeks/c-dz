using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите арифметическое выражение (например, 2 + 3 - 1): ");
        string input = Console.ReadLine();

        string[] parts = input.Split(' ');

        if (parts.Length % 2 == 0)
        {
            Console.WriteLine("Некорректное выражение.");
            return;
        }

        double result = Convert.ToDouble(parts[0]);

        for (int i = 1; i < parts.Length; i += 2)
        {
            string operation = parts[i];
            double number = Convert.ToDouble(parts[i + 1]);

            if (operation == "+")
            {
                result += number;
            }
            else if (operation == "-")
            {
                result -= number;
            }
            else
            {
                Console.WriteLine("Поддерживаются только операции + и -.");
                return;
            }
        }

        Console.WriteLine($"Результат: {result}");
    }
}
