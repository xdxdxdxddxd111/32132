using System;
using System.Collections.Generic;

class CurrencyConverter
{
    private static readonly Dictionary<string, double> Rates = new Dictionary<string, double>
    {
        { "USD", 1.0 },
        { "EUR", 0.85 },
        { "RUB", 90.0 }
    };

    static void Main()
    {
        Console.WriteLine("Конвертер валют (EUR/USD/RUB)\n");

        string from = ReadCurrency("Из (USD/EUR/RUB): ");

        string to = ReadCurrency("В (USD/EUR/RUB): ");

        double amount = ReadAmount("Сумма: ");

        double result = Convert(amount, from, to);
        Console.WriteLine($"\nРезультат: {amount:F2} {from} = {result:F2} {to}");
    }

    static string ReadCurrency(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine()?.ToUpper();

            if (Rates.ContainsKey(input))
                return input;

            Console.WriteLine("Ошибка: допустимы только USD, EUR, RUB.");
        }
    }

    static double ReadAmount(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double value) && value > 0)
                return value;

            Console.WriteLine("Ошибка: введите положительное число.");
        }
    }

    static double Convert(double amount, string from, string to)
    {
        double fromRate = Rates[from];
        double toRate = Rates[to];
        return amount * (toRate / fromRate);
    }
}
