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
            Console.Write("Введите температуру: ");
            double temperature = double.Parse(Console.ReadLine());

            Console.Write("Преобразовать в (F)аренгейт или (C)ельсий? ");
            char scale = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (scale == 'F')
            {
                double ToFahrenheit = (temperature * 9 / 5) + 32;
                Console.WriteLine($"Температура в Фаренгейтах: {ToFahrenheit}");
            }
            else if (scale == 'C')
            {
                double ToCelsius = (temperature - 32) * 5 / 9;
                Console.WriteLine($"Температура в Цельсиях: {ToCelsius}");
            }
            else
            {
                Console.WriteLine("Некорректный выбор.");
            }
            Console.ReadLine();
        }
    }
}
