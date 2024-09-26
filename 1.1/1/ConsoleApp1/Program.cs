using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите градусы по Цельсию");
            double cel = Convert.ToDouble(Console.ReadLine());
            double far = cel * (9.0 / 5.0) + 32;
            Console.WriteLine("Градусы по Фаренгейту: {0} ",far);
            Console.ReadLine();



        }
    }
}
