using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
    class Program
    {
        static void Main(string[] args)
        {
            int walletsQuantity = int.Parse(Console.ReadLine()); // количество кошельков
            var wallets = Console.ReadLine().Split(' ').Select(int.Parse).Select(el => new Wallet { Quantity = el }).ToList(); // конфигурация кошельков
            //wallets.Sort(Comparer<Wallet>.Create((w1, w2) => w1.Size.CompareTo(w2.Size)));

            int coinsQuantity = int.Parse(Console.ReadLine()); // общее количество монет

            Console.WriteLine(CheckForConfiguration(wallets, coinsQuantity) ? "true" : "false");
        }

        /// <summary>
        /// Проверяет наличие конфигурации.
        /// </summary>
        /// <param name="wallets">Кошельки.</param>
        /// <param name="coinsAmount">Оставшееся количество денег.</param>
        /// <returns>Да или нет?</returns>
        static bool CheckForConfiguration(List<Wallet> wallets, int coinsAmount)
        {
            if (wallets.Max(t => t.Quantity) > coinsAmount) // если нельзя всеми монетами заполнить самый большой кошелек, то дальше решать смысла нет
                return false;

            return false;
        }
    }

    class Wallet
    {
        public List<Wallet> In { get; set; }
        public int Quantity { get; set; }
        public int Filling { get; set; }
    }
}
