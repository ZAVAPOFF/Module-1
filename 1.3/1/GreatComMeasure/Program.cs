using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatComMeasure
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.GreatComMeasure();
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private void GreatComMeasure()
        {
            Console.WriteLine("Введите числитель (неотрицательное число):");
            int numerator = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите знаменатель (положительное число):");
            int denominator = int.Parse(Console.ReadLine());

            if (denominator == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю.");
                return;
            }

            int gcd = GCD(numerator, denominator);

            numerator /= gcd;
            denominator /= gcd;

            Console.WriteLine($"Сокращенная дробь: {numerator}/{denominator}");
            Console.ReadLine();
        }
    }
}
