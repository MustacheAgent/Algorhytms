using System;

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

            int[] res = Solve(swaps, swapsOrder);
            foreach (var item in res)
            {
                Console.WriteLine((item + 1).ToString());
            }

            Console.ReadKey();
        }

        public static int[] Solve(int[][] swaps, int[] swapsOrder)
        {
            int[] result = new int[swapsOrder.Length];

            for (int i = 0; i < swapsOrder.Length; i++)
            {
                for (int j = 0; j < swapsOrder.Length; j++)
                {
                    if (j == i) continue;
                    result[i] = swaps[swapsOrder[j]][result[i]];
                }
            }
            return result;
        }
    }
}
