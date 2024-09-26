using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Alphabet();
        }
        private void Alphabet()
        {
            Console.WriteLine("Введите размер массива (K):");
            int K = int.Parse(Console.ReadLine());
            char[] arr = new char[K];
            char[] consonantsArr = new char[K];
            int consonantsCount = 0;

            Random rnd = new Random();
            string alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

            for (int i = 0; i < K; i++)
            {
                arr[i] = alphabet[rnd.Next(alphabet.Length)];
                if ("БВГДЖЗЙКЛМНПРСТФХЦЧШЩ".Contains(arr[i]))
                {
                    consonantsArr[consonantsCount++] = arr[i];
                }
            }

            Console.WriteLine("Исходный массив:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nМассив согласных:");
            for (int i = 0; i < consonantsCount; i++)
            {
                Console.Write(consonantsArr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
