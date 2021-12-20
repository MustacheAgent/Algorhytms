using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        	int b = 0;
            Console.ReadLine(); // количество кошельков
            var wallets = Console.ReadLine().Split(' ').Select(int.Parse).Select(el => new Wallet { MyQuantity = el }).ToList(); // количество денег в каждом кошельке
            wallets.Sort(Comparer<Wallet>.Create((w1, w2) => w1.MyQuantity.CompareTo(w2.MyQuantity)));

            int count = int.Parse(Console.ReadLine()); // общее количество денег

            var max = wallets.Select(el => el.MyQuantity).Sum(); // максимально возможное количество денег во всех кошельках

            Console.Write(Check(count, wallets, max, 0) ? "Yes" : "No");
        }

        /// <summary>
        /// Проверить распределение денег по кошелькам
        /// </summary>
        /// <param name="num">Общее количество денег</param>
        /// <param name="wallets">Кошельки</param>
        /// <param name="max">Максимально возможное количество денег во всех кошельках</param>
        /// <param name="pointer">Индекс кошелька</param>
        /// <returns></returns>
        private static bool Check(int num, List<Wallet> wallets, int max, int pointer)
        {
            while (true)
            {
                if (pointer == wallets.Count || max < num) 
                    return false;

                if (num == max) 
                    return true;

                if (TryNest(wallets, pointer) && Check(num, wallets, max - wallets[pointer].MyQuantity, pointer + 1)) 
                    return true;

                if (wallets[pointer].In != null) 
                    TakeOut(wallets[pointer]);

                pointer += 1;
            }
        }

        /// <summary>
        /// Убрать вложенный кошелек
        /// </summary>
        /// <param name="wallet">кошелек, который надо убрать</param>
        private static void TakeOut(Wallet wallet)
        {
            wallet.In.NestedQuantity -= wallet.MyQuantity;
            wallet.In = null;
        }

        /// <summary>
        /// Попытаться засунуть кошелек в один из следующих
        /// </summary>
        /// <param name="wallets">Кошельки</param>
        /// <param name="pointer">Впихиваемый кошелек</param>
        /// <returns></returns>
        private static bool TryNest(List<Wallet> wallets, int pointer)
        {
            var current = wallets[pointer];
            for (int i = pointer + 1; i < wallets.Count; i++)
            {
                // в каждом кошельке должна быть хотя бы одна не вложенная монета, поэтому неподходящие кошельки пропускаем
                if (wallets[i].MyQuantity == current.MyQuantity || wallets[i].NestedQuantity + current.MyQuantity > wallets[i].MyQuantity - 1)
                    continue;

                wallets[i].NestedQuantity += current.MyQuantity;
                current.In = wallets[i];
                return true;
            }

            return false;
        }
    }

    class Wallet
    {
        /// <summary>
        /// Вложенный кошелек
        /// </summary>
        public Wallet In { get; set; }
        /// <summary>
        /// Количество денег в кошельке
        /// </summary>
        public int MyQuantity { get; set; }
        /// <summary>
        /// Общее количество денег во вложенных кошельках
        /// </summary>
        public int NestedQuantity { get; set; }
    }
}