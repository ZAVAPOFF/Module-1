using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.EvenOdd();
        }

        private void EvenOdd()
        {
            Console.WriteLine("Введите целое число: ");
            int num;
            int.TryParse(Console.ReadLine(), out num);
            if (num % 2 == 0)
            {
                Console.WriteLine("Число четное.");
            }
            else
            {
                Console.WriteLine("Число нечетное.");
            }
            Console.ReadLine();
        }
    }
}

