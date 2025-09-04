using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Простой калькулятор на C#");

        Console.Write("Введите первое число: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите оператор (+, -, *, /): ");
        string op = Console.ReadLine();

        double result = 0;
        bool validOperation = true;

        switch (op)
        {
            case "+":
                result = x + y;
                break;
            case "-":
                result = x - y;
                break;
            case "*":
                result = x * y;
                break;
            case "/":
                if (y != 0)
                    result = x / y;
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                    validOperation = false;
                }
                break;
            default:
                Console.WriteLine("Неизвестный оператор!");
                validOperation = false;
                break;
        }

        if (validOperation)
            Console.WriteLine($"Результат: {result}");
    }
}
