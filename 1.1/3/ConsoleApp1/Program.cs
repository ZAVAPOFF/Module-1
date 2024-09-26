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
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            // Переворачиваем строку
            char[] revArray = input.ToCharArray();
            Array.Reverse(revArray);
            string revInput = new string(revArray);

            // Проверяем, является ли строка палиндромом
            if (input == revInput)
            {
                Console.WriteLine("Введенная строка является палиндромом.");
            }
            else
            {
                Console.WriteLine("Введенная строка не является палиндромом.");
            }
            Console.ReadLine();
        }

    }
}
