using System;
using System.IO;

namespace Transposition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = new int[] { 1, 2, 3 };
            StreamReader input = new StreamReader("../../input.txt");
            int[] param = Array.ConvertAll(input.ReadLine().Split(' '), s => int.Parse(s)); // количество элементов и количество наборов перестановок
            int[][] swaps = new int[param[1]][]; // массив массивов перестановок

            for (int i = 0; i < param[1]; i++)
            {
                swaps[i] = Array.ConvertAll(input.ReadLine().Split(' '), s => int.Parse(s) - 1); // получение перестановок
            }

            input.ReadLine();
            int[] swapsOrder = Array.ConvertAll(input.ReadLine().Split(' '), s => int.Parse(s) - 1); // порядок применения перестановок

            Console.WriteLine("");

            for (int i = 0; i < swapsOrder.Length; i++)
            {
                foreach (var item in elements)
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.Write("=> ");
                Array.Sort((Array)swaps[swapsOrder[i]].Clone(), elements);
                foreach (var item in elements)
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();

            /*
            int[] elements = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] swap = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Array.Sort(swap, elements);

            foreach(var item in elements)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.ReadKey();
            */
        }
    }
}
