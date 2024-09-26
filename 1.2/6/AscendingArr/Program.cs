using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AscendingArr
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.AscendingArr();
        }
        private void AscendingArr()
        {
            // Создаем и заполняем вещественный массив из 10 элементов случайными значениями в диапазоне [-10, 10)
            Random random = new Random();
            double[] array = new double[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble() * 20 - 10; // Преобразуем диапазон [0, 1) в диапазон [-10, 10)
                Console.WriteLine($"Элемент {i}: {array[i]:F2}");
            }

            // Создаем массив индексов, отсортированных по значениям элементов первого массива
            int[] indices = Enumerable.Range(0, array.Length).OrderBy(i => array[i]).ToArray();

            // Выводим массив индексов
            Console.WriteLine("\nМассив индексов в порядке возрастания значений первого массива:");
            foreach (int index in indices)
            {
                Console.WriteLine(index);
            }
            Console.ReadLine();
        }
    }
}
