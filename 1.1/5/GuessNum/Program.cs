using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.GuessNum();
        }
        private void GuessNum()
        {
            // Генерируем случайное число от 1 до 10
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            Console.Write("Угадайте число от 1 до 10: ");
            int userGuess = int.Parse(Console.ReadLine());

            // Проверяем, угадал ли пользователь число
            if (userGuess == randomNumber)
            {
                Console.WriteLine("Поздравляем! Вы угадали число.");
            }
            else
            {
                Console.WriteLine($"Вы не угадали. Загаданное число было: {randomNumber}");
            }
            Console.ReadLine();
        }
    }
}
