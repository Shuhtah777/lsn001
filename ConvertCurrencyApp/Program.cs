using System;

class CurrencyConverter
{
    // Константи (курси відносно UAH)
    const double USD_TO_UAH = 41.2; // 1 USD = 41.2 UAH
    const double EUR_TO_UAH = 44.3; // 1 EUR = 44.3 UAH

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Програма «Конвертор валют»");
        Console.WriteLine("Доступні валюти: USD, EUR, UAH");

        Console.Write("Введіть суму: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.Write("З якої валюти (USD/EUR/UAH): ");
        string from = Console.ReadLine().ToUpper();

        Console.Write("В яку валюту (USD/EUR/UAH): ");
        string to = Console.ReadLine().ToUpper();

        double result = ConvertCurrency(amount, from, to);

        if (result >= 0)
            Console.WriteLine($"{amount} {from} = {result:F2} {to}");
        else
            Console.WriteLine("Помилка: невідома валюта.");
    }

    static double ConvertCurrency(double amount, string from, string to)
    {
        double amountInUAH;

        // Переводимо в гривні
        switch (from)
        {
            case "USD": amountInUAH = amount * USD_TO_UAH; break;
            case "EUR": amountInUAH = amount * EUR_TO_UAH; break;
            case "UAH": amountInUAH = amount; break;
            default: return -1; // невідома валюта
        }

        // З гривні у потрібну валюту
        switch (to)
        {
            case "USD": return amountInUAH / USD_TO_UAH;
            case "EUR": return amountInUAH / EUR_TO_UAH;
            case "UAH": return amountInUAH;
            default: return -1;
        }
    }
}
