using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Palindrome(); 
        }
        private void Palindrome()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            // Переворачиваем строку
            char[] revArray = input.ToCharArray();
            Array.Reverse(revArray);
            string revStr = new string(revArray);

            // Проверяем, является ли строка палиндромом
            if (input == revStr)
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
