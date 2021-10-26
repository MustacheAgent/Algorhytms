using System;

namespace Transposition
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] param = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); // количество элементов и количество наборов перестановок
            int[][] swaps = new int[param[0]][]; // массив массивов перестановок

            for (int i = 0; i < param[0]; i++)
            {
                swaps[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); // получение перестановок
            }

            Console.ReadLine();
            int[] swapsOrder = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); // порядок применения перестановок
            */

            int[] elements = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] swap = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Array.Sort(swap, elements);

            foreach(var item in elements)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Переставляет элементы в указанном порядке.
        /// </summary>
        /// <param name="elements">Массив элементов.</param>
        /// <param name="swap">Новый порядок элементов.</param>
        /// <returns>Массив элементов с новым порядком.</returns>
        static int[] SwapElements(int[] elements, int[] swap)
        {
            Array.Sort(swap, elements);
            /*
            int[] res = new int[elements.Length];
            int tmp;

            for (int i = 0; i < elements.Length; i++)
            {
                if (i == swap[i] - 1) continue; // если новый индекс равен текущему, то менять ничего не надо

                tmp = elements[swap[i] - 1];
                elements[swap[i] - 1] = elements[i];
                elements[i] = tmp;
            }
            */

            return elements;
        }
    }
}
