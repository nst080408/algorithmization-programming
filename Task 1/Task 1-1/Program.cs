using System;

namespace Task_1_1
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            const double a = 3;
            const double b = 1;
            const double c = 2;

            double x = GetNumber("Введите x = ");
            double y = GetResult(a, b, c, x);

            Console.WriteLine($"x = {x}; y = {y}");
        }

        /// <summary>
        /// Вычисляет значение функции.
        /// </summary>
        /// <param name="a">Константа a.</param>
        /// <param name="b">Константа b.</param>
        /// <param name="c">Константа c.</param>
        /// <param name="x">Аргумент функции.</param>
        /// <returns>Значение функции.</returns>
        private static double GetResult(double a, double b, double c, double x)
        {
            return (a * x * x + 3.0 / 5.0 * b * Math.Abs(x)) /
                (c + Math.Sqrt(x * x + 4));
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
