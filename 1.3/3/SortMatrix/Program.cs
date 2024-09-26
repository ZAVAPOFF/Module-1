using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.SortMatrix();
        }

        private void SortMatrix()
        {
            Console.WriteLine("Введите размер квадратной матрицы:");
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            Random rand = new Random();

            // Заполнение матрицы случайными значениями от -50 до 50
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rand.Next(-50, 51);
                }
            }

            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrix);

            // Создание массива сумм строк
            var rowsWithSums = Enumerable.Range(0, size)
                .Select(i => new { Index = i, Sum = Enumerable.Range(0, size).Sum(j => matrix[i, j]) })
                .OrderBy(row => row.Sum)
                .ToArray();

            // Создание новой упорядоченной матрицы
            int[,] sortedMatrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sortedMatrix[i, j] = matrix[rowsWithSums[i].Index, j];
                }
            }

            Console.WriteLine("Матрица после сортировки строк по возрастанию суммы их элементов:");
            PrintMatrix(sortedMatrix);

        }
        static void PrintMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine();
            }
        Console.ReadLine();
        }
    }
}