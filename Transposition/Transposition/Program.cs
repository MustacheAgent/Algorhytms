﻿using System;
using System.IO;

namespace Transposition
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] param = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); // количество элементов и количество наборов перестановок
            int[][] swaps = new int[param[1]][]; // массив массивов перестановок
            for (int i = 0; i < param[1]; i++)
            {
                swaps[i] = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s) - 1); // получение перестановок
            }
            Console.ReadLine();
            int[] swapsOrder = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s) - 1); // порядок применения перестановок

            int[] result = new int[swapsOrder.Length]; // массив ответов (позиций первого элемента)

            for (int i = 0; i < swapsOrder.Length; i++) // исследуем каждую перестановку
            {
                for (int j = 0; j < swapsOrder.Length; j++) // применяем все перестановки кроме выбранной
                {
                    if (j == i) continue; // собственно пропускаем выбранную перестановку, если натыкаемся

                    // смотрим на индекс первого элемента в первой применяемой перестановке, запоминаем его новую позицию,
                    // и в следующей перестановке проверяем уже запомненную позицию, запоминая следующую позицию, и так далее, пока не переберем все перестановки
                    result[i] = swaps[swapsOrder[j]][result[i]];
                }
            }

            Console.WriteLine();
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write((result[i] + 1).ToString() + " "); // вывод
            }

            Console.ReadKey();
        }
    }
}
