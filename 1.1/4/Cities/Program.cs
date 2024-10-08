﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Cities();
        }
        private void Cities() 
        {
            // Создаем массив из 5 названий городов
            string[] cities = { "Москва", "Рим", "Париж", "Минск", "Берлин" };

            Console.Write("Введите название города: ");
            string inputCity = Console.ReadLine();

            // Поиск города в массиве
            int index = Array.IndexOf(cities, inputCity);

            // Проверяем, найден ли город
            if (index != -1)
            {
                Console.WriteLine($"Город найден в массиве под индексом {index}.");
            }
            else
            {
                Console.WriteLine("Такого города нет в массиве.");
            }
            Console.ReadLine();
        }
    }
}
