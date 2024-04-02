using System;

namespace ComplexProgram
{
    class Program
    {
        static void Main()
        {
            RationalNumber r1 = new RationalNumber(3, 4);
            RationalNumber r2 = new RationalNumber(2, 5);

            RationalNumber sum = RationalNumber.Add(r1, r2);
            RationalNumber product = RationalNumber.Multiply(r1, r2);
            RationalNumber quotient = RationalNumber.Divide(r1, r2);

            Console.WriteLine($"Сумма: {sum.Numerator}/{sum.Denominator}");
            Console.WriteLine($"Произведение: {product.Numerator}/{product.Denominator}");
            Console.WriteLine($"Частное: {quotient.Numerator}/{quotient.Denominator}");

            ComplexNumber c1 = new ComplexNumber(1, 2);
            RationalNumber rationalConstant = new RationalNumber(3, 2);

            ComplexNumber productComplex = ComplexNumber.MultiplyByRational(c1, rationalConstant);
            Console.WriteLine($"Умножение на рациональную константу: {productComplex.Real} + {productComplex.Imaginary}i");
        }
    }
}