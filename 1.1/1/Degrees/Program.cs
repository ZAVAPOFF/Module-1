using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Program program = new Program();
            program.Degrees();
        }
        private void Degrees()
        {
            Console.WriteLine("Введите градусы по Цельсию");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double far = celsius * (9.0 / 5.0) + 32;
            Console.WriteLine($"Градусы по Фаренгейту {far}");
            Console.ReadLine();
        }
    }
}
