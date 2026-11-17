using System;
using System.Globalization;
using System.Text;

namespace Task_1_2
{
    /// <summary>
    /// Находит среднее арифметическое кубов и среднее геометрическое модулей двух чисел.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Получает два числа, выполняет вычисления и выводит результаты.
        /// </summary>
        /// <param name="args">Аргументы командной строки. В этой работе не используются.</param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Задание 1.2. Вариант №11");
            Console.WriteLine("Среднее арифметическое кубов: A = (x^3 + y^3) / 2");
            Console.WriteLine("Среднее геометрическое модулей: G = sqrt(|x| * |y|)");
            Console.WriteLine("Дробные числа можно вводить с точкой или запятой.");

            double x = GetNumber("Введите x = ");
            double y = GetNumber("Введите y = ");
            double arithmeticMean = GetArithmeticMeanOfCubes(x, y);
            double geometricMean = GetGeometricMeanOfModules(x, y);

            Console.WriteLine($"Исходные числа: x = {x}; y = {y}");
            Console.WriteLine($"Среднее арифметическое кубов A = {arithmeticMean:F10}");
            Console.WriteLine($"Среднее геометрическое модулей G = {geometricMean:F10}");
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

            // Для ввода оставила оба десятичных разделителя.
            return double.Parse(input.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Находит среднее арифметическое кубов двух чисел.
        /// </summary>
        /// <param name="x">Первое число.</param>
        /// <param name="y">Второе число.</param>
        /// <returns>Полусумма кубов x и y.</returns>
        static double GetArithmeticMeanOfCubes(double x, double y)
        {
            // Сначала возвожу каждое число в куб, затем нахожу их среднее.
            return (x * x * x + y * y * y) / 2.0;
        }

        /// <summary>
        /// Находит среднее геометрическое модулей двух чисел.
        /// </summary>
        /// <param name="x">Первое число.</param>
        /// <param name="y">Второе число.</param>
        /// <returns>Квадратный корень из произведения модулей x и y.</returns>
        static double GetGeometricMeanOfModules(double x, double y)
        {
            // Модули взяла до умножения, чтобы выражение под корнем было неотрицательным.
            return Math.Sqrt(Math.Abs(x) * Math.Abs(y));
        }
    }
}
