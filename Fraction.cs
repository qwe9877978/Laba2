using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW2
{
    public class Fraction
    {
        // Поля класса
        public int Numerator;
        public int Denominator;

        // Конструктор по умолчанию
        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }

        // Основной конструктор дроби
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен нулю.");
            }

            Numerator = numerator;
            Denominator = denominator;
            Simplify();
        }

        // Метод для нахождения наибольшего общего делителя (НОД)
        private int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Метод для упрощения дроби
        private void Simplify()
        {
            if (Numerator == 0)
            {
                Denominator = 1;
                return;
            }

            int gcd = FindGCD(Math.Abs(Numerator), Math.Abs(Denominator));
            Numerator = Numerator / gcd;
            Denominator = Denominator / gcd;

            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }

        // Операция сложения с другой дробью
        public Fraction Add(Fraction other)
        {
            int newNumerator = Numerator * other.Denominator + other.Numerator * Denominator;
            int newDenominator = Denominator * other.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        // Операция сложения с целым числом
        public Fraction Add(int number)
        {
            return Add(new Fraction(number, 1));
        }

        // Операция вычитания с другой дробью
        public Fraction Subtract(Fraction other)
        {
            int newNumerator = Numerator * other.Denominator - other.Numerator * Denominator;
            int newDenominator = Denominator * other.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        // Операция вычитания целого числа
        public Fraction Subtract(int number)
        {
            return Subtract(new Fraction(number, 1));
        }

        // Операция умножения на другую дробь
        public Fraction Multiply(Fraction other)
        {
            int newNumerator = Numerator * other.Numerator;
            int newDenominator = Denominator * other.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        // Операция умножения на целое число
        public Fraction Multiply(int number)
        {
            return Multiply(new Fraction(number, 1));
        }

        // Операция деления на другую дробь
        public Fraction Divide(Fraction other)
        {
            if (other.Numerator == 0)
            {
                throw new DivideByZeroException("Деление на нулевую дробь.");
            }

            int newNumerator = Numerator * other.Denominator;
            int newDenominator = Denominator * other.Numerator;
            return new Fraction(newNumerator, newDenominator);
        }

        // Операция деления на целое число
        public Fraction Divide(int number)
        {
            return Divide(new Fraction(number, 1));
        }

        // Строковое представление дроби
        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }
    }

}
