using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string input = Console.ReadLine();

        string[] sentences = input.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < sentences.Length; i++)
        {
            sentences[i] = char.ToUpper(sentences[i].Trim()[0]) + sentences[i].Trim().Substring(1);
        }

        string result = string.Join(". ", sentences);
        Console.WriteLine(result);
    }
}