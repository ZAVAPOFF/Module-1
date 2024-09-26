using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalizeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.NormalizeArray();
        }
        private void NormalizeArray()
        {
            Console.WriteLine("Введите размер массива:");
            int N = int.Parse(Console.ReadLine());
            double[] arr = new double[N];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < N; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }

            double maxElement = arr.Max(Math.Abs);

            for (int i = 0; i < N; i++)
            {
                arr[i] /= maxElement;
            }

            Console.WriteLine("Нормированный массив:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();

        }
    }
}
