using System;

namespace FormatDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;

            Console.WriteLine($"**Результаты операций: {sum}**");
        }
    }
}