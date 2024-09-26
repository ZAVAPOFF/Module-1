using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.LimArray();
        }

        private void LimArray()
        {
            Console.WriteLine("Введите максимальную сумму элементов массива:");
            int maxSum = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int currentSum = 0;
            int elementCount = 0;

            while (currentSum < maxSum)
            {
                int newElement = rand.Next(1, 10); // Случайное число от 1 до 9

                if (currentSum + newElement > maxSum)
                    break;

                currentSum += newElement;
                elementCount++;
                Console.WriteLine($"Добавлен элемент: {newElement}, текущая сумма: {currentSum}");
            }

            Console.WriteLine($"Общее количество элементов: {elementCount}");
            Console.ReadLine();
        }
    }
}
