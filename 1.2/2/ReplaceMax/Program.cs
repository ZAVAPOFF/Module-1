using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ReplaceMax();
        }
        private void ReplaceMax() 
        {
            int[] randomArr = new int[10];
            Random random = new Random();
            for (int i = 0; i < randomArr.Length; i++)
                randomArr[i] = random.Next(1, 101);

            Console.WriteLine("Изначальный массив:");
            foreach (var item in randomArr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nВведите число для замены максимального элемента:");
            int newValue = int.Parse(Console.ReadLine());

            int maxIndex = Array.IndexOf(randomArr, randomArr.Max());

            randomArr[maxIndex] = newValue;

            Console.WriteLine("Измененный массив:");
            foreach (var item in randomArr)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
