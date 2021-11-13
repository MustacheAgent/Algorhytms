using System;
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
            int swapsAmount = int.Parse(Console.ReadLine());
            int[] swapsOrder = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s) - 1); // порядок применения перестановок
            /*
            int[] origin = new int[swapsAmount];
            for (int i = 0; i < swapsAmount; i++)
            {
                if (i == 0)
                {
                    origin[i] = swaps[swapsOrder[i]][origin[i]];
                }
                else
                {
                    origin[i] = swaps[swapsOrder[i]][origin[i - 1]];
                }
            }*/
            /*
            Console.WriteLine();
            for (int i = 0; i < origin.Length; i++)
            {
                Console.Write((origin[i] + 1).ToString() + " "); // вывод
            }
            */
            
            int[] result = new int[swapsAmount]; // массив ответов (позиций первого элемента)
            int prev = 0;
            for (int i = 0; i < swapsAmount; i++) // исследуем каждую перестановку
            {
                if (i == 1)
                {
                    result[i] = prev = swaps[swapsOrder[i - 1]][prev];
                }
                else if (i > 1)
                {
                    result[i] = prev = swaps[swapsOrder[i - 1]][prev];
                }
                for (int j = i + 1; j < swapsAmount; j++) // исследуем все перестановки после исключенной
                {
                    result[i] = swaps[swapsOrder[j]][result[i]];
                }
            }

            /*
            for (int i = 0; i < swapsAmount; i++) // исследуем каждую перестановку
            {
                if (i > 0) result[i] = origin[i - 1];
                for (int j = i + 1; j < swapsAmount; j++) // применяем все перестановки кроме выбранной
                {
                    // смотрим на индекс первого элемента в первой применяемой перестановке, запоминаем его новую позицию,
                    // и в следующей перестановке проверяем уже запомненную позицию, запоминая следующую позицию, и так далее, пока не переберем все перестановки
                    result[i] = swaps[swapsOrder[j]][result[i]];
                }
            }
            */

            Console.WriteLine();
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write((result[i] + 1).ToString() + " "); // вывод
            }
            
            Console.ReadKey();
        }
    }
}
