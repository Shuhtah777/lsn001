using System;

class TextAnalyzer
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Програма «Аналіз тексту»");
        Console.WriteLine("Введіть текст (для завершення введення натисніть Enter двічі):");

        // Зчитуємо увесь текст (кілька рядків)
        string input = "";
        string line;
        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            input += line + "\n";
        }

        // Кількість символів (усіх)
        int totalChars = input.Length;

        // Кількість видимих символів (не враховуємо пробіли, \n, \t)
        int visibleChars = 0;
        foreach (char c in input)
        {
            if (!char.IsWhiteSpace(c))
                visibleChars++;
        }

        // Кількість пробілів
        int spaces = 0;
        foreach (char c in input)
        {
            if (c == ' ')
                spaces++;
        }

        // Кількість слів (розбиваємо за пробілами та розділовими знаками)
        string[] words = input.Split(
            new char[] { ' ', '\n', '\t', ',', '.', '!', '?', ':', ';', '-', '(', ')', '[', ']', '"' },
            StringSplitOptions.RemoveEmptyEntries
        );
        int wordCount = words.Length;

        // Кількість рядків
        int lineCount = input.Split('\n').Length - 1;

        // Вивід результату
        Console.WriteLine("\nРезультат аналізу:");
        Console.WriteLine($"Кількість символів (усіх): {totalChars}");
        Console.WriteLine($"Кількість символів (видимих): {visibleChars}");
        Console.WriteLine($"Кількість пробілів: {spaces}");
        Console.WriteLine($"Кількість слів: {wordCount}");
        Console.WriteLine($"Кількість рядків: {lineCount}");
    }
}
