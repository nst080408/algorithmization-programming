using System;

namespace Task_1_2
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            double x = GetNumber("Введите x = ");
            double y = GetNumber("Введите y = ");

            double a = GetArithmetic(x, y);
            double g = GetGeometric(x, y);

            Console.WriteLine($"x = {x}; y = {y}");
            Console.WriteLine($"Среднее арифметическое кубов A = {a}");
            Console.WriteLine($"Среднее геометрическое модулей G = {g}");
        }

        /// <summary>
        /// Вычисляет среднее арифметическое кубов.
        /// </summary>
        /// <param name="x">Первое число.</param>
        /// <param name="y">Второе число.</param>
        /// <returns>Среднее арифметическое кубов.</returns>
        private static double GetArithmetic(double x, double y)
        {
            return (x * x * x + y * y * y) / 2.0;
        }

        /// <summary>
        /// Вычисляет среднее геометрическое модулей.
        /// </summary>
        /// <param name="x">Первое число.</param>
        /// <param name="y">Второе число.</param>
        /// <returns>Среднее геометрическое модулей.</returns>
        private static double GetGeometric(double x, double y)
        {
            return Math.Sqrt(Math.Abs(x) * Math.Abs(y));
        }

        /// <summary>
        /// Считывает число с клавиатуры.
        /// </summary>
        /// <param name="message">Сообщение пользователю.</param>
        /// <returns>Введённое число.</returns>
        private static double GetNumber(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return double.Parse(input);
        }
    }
}
