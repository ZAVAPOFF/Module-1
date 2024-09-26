using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.PrimeNum();
        }
        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        private void PrimeNum()
        {
            Console.WriteLine("Введите количество простых чисел:");
            int K = int.Parse(Console.ReadLine());
            int count = 0;
            int number = 2;

            while (count < K)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                    count++;

                    if (count % 10 == 0)
                        Console.WriteLine();
                }
                number++;
            }
            Console.ReadLine();
        }
    }
}
