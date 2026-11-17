using System;
using System.Globalization;
using System.Text;

namespace Task_1_3
{
    /// <summary>
    /// Вычисляет потенциальную энергию растянутой пружины.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Получает жёсткость и растяжение пружины, вычисляет и выводит энергию.
        /// </summary>
        /// <param name="args">Аргументы командной строки. В этой работе не используются.</param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Задание 1.3. Вариант №11");
            Console.WriteLine("Потенциальная энергия пружины: E = k * x^2 / 2");
            Console.WriteLine("Дробные числа можно вводить с точкой или запятой.");

            // Величины вводятся в системе СИ: жёсткость в Н/м, растяжение в метрах.
            double k = GetNumber("Введите жёсткость k (Н/м, положительное число) = ");
            double x = GetNumber("Введите растяжение x (м, неотрицательное число) = ");
            double energy = GetPotentialEnergy(k, x);

            Console.WriteLine($"Исходные данные: k = {k} Н/м; x = {x} м");
            Console.WriteLine($"Потенциальная энергия E = {energy:F10} Дж");
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
            return double.Parse(input.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Вычисляет потенциальную энергию пружины по закону Гука.
        /// </summary>
        /// <param name="k">Жёсткость пружины в ньютонах на метр, положительное число.</param>
        /// <param name="x">Растяжение пружины в метрах, неотрицательное число.</param>
        /// <returns>Потенциальная энергия пружины в джоулях.</returns>
        static double GetPotentialEnergy(double k, double x)
        {
            // В формуле нужен квадрат растяжения. Деление записала через 2.0.
            return k * x * x / 2.0;
        }
    }
}
