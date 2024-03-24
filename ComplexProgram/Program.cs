using ComplexLibruary;
using System;

namespace ComplexProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ComplexNumber complex1 = new ComplexNumber();

            ComplexNumber complex2 = new ComplexNumber();

            Console.WriteLine($"Числитель: {complex1}");
            Console.WriteLine($"Знаменатель: {complex2}");

            Console.WriteLine($"Сложение: {complex1.Add(complex2)}");
            Console.WriteLine($"Умножение: {complex1.Multiply(complex2)}");
            Console.WriteLine($"Деление: {complex1.Divide(complex2)}");

            Console.WriteLine("Введите константу для умножения:");
            int rational = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Комплексное, умноженное на константу {rational}: {complex1.MultiplyByRational(rational)}");
        }
    }
}
