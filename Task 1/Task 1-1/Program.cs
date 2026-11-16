using System;
using System.Globalization;
using System.Text;

namespace Task_1_1
{
    /// <summary>
    /// Вычисляет значение функции из задания 1.1 для варианта №11.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Задаёт константы, получает x и выводит результат вычисления.
        /// </summary>
        /// <param name="args">Аргументы командной строки. В этой работе не используются.</param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Константы взяла из таблицы для варианта №11.
            const double a = 3;
            const double b = 1;
            const double c = 2;

            Console.WriteLine("Задание 1.1. Вариант №11");
            Console.WriteLine("y = (a * x^2 + (3/5) * b * |x|) / (c + sqrt(x^2 + 4))");
            Console.WriteLine($"Константы: a = {a}; b = {b}; c = {c}");
            Console.WriteLine("Для проверки введите x = 2. Дробные числа можно вводить с точкой или запятой.");

            // Ввод и вычисление вынесла в отдельные функции.
            double x = GetNumber("Введите x = ");
            double y = GetResult(a, b, c, x);

            Console.WriteLine($"При x = {x} значение y = {y:F10}");
        }

        /// <summary>
        /// Выводит приглашение и считывает вещественное число с клавиатуры.
        /// </summary>
        /// <param name="message">Текст приглашения ко вводу.</param>
        /// <returns>Введённое пользователем число.</returns>
        static double GetNumber(string message = "Введите число: ")
        {
            Console.Write(message);
            string input = Console.ReadLine();

            // Заменяю запятую на точку, чтобы оба варианта записи дроби работали одинаково.
            return double.Parse(input.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Вычисляет y по расчётной формуле варианта №11.
        /// </summary>
        /// <param name="a">Константа a, равная 3.</param>
        /// <param name="b">Константа b, равная 1.</param>
        /// <param name="c">Константа c, равная 2.</param>
        /// <param name="x">Значение аргумента функции.</param>
        /// <returns>Рассчитанное значение функции y.</returns>
        static double GetResult(double a, double b, double c, double x)
        {
            // Записала дробь как 3.0 / 5.0, чтобы деление было вещественным.
            double numerator = a * x * x + 3.0 / 5.0 * b * Math.Abs(x);
            double denominator = c + Math.Sqrt(x * x + 4);

            return numerator / denominator;
        }
    }
}
