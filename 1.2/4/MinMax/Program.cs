using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.MinMax();
        }
        private void MinMax()
        {
            Console.WriteLine("Введите размер массива (K):");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите границы диапазона A и B:");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int[] arr = new int[K];
            Random rnd = new Random();

            for (int i = 0; i < K; i++)
            {
                arr[i] = rnd.Next(A, B);
            }

            int minIndex = Array.IndexOf(arr, arr.Min());
            int maxIndex = Array.IndexOf(arr, arr.Max());

            Console.WriteLine("Элементы между минимальным и максимальным индексами:");
            for (int i = Math.Min(minIndex, maxIndex); i <= Math.Max(minIndex, maxIndex); i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
