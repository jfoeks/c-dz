using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        string reversed = new string(input.ToCharArray().Reverse().ToArray());

        if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Строка не является палиндромом.");
        }
    }
}



