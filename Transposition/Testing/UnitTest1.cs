using NUnit.Framework;
using System;
using System.IO;
using Transposition;

namespace Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            int[] param = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); // ���������� ��������� � ���������� ������� ������������
            int[][] swaps = new int[param[1]][]; // ������ �������� ������������
            for (int i = 0; i < param[1]; i++)
            {
                swaps[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); // ��������� ������������
            }
            Console.ReadLine();
            int[] swapsOrder = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); // ������� ���������� ������������

            int[] res = Program.Solve(swaps, swapsOrder);
        }

        [Test]
        public void Test1()
        {
            int[] res;
            using (StreamReader reader = new StreamReader(TestContext.CurrentContext.TestDirectory + "\\test1.txt"))
            {
                int[] param = Array.ConvertAll(reader.ReadLine().Split(' '), int.Parse); // ���������� ��������� � ���������� ������� ������������
                int[][] swaps = new int[param[1]][]; // ������ �������� ������������
                for (int i = 0; i < param[1]; i++)
                {
                    swaps[i] = Array.ConvertAll(reader.ReadLine().Split(' '), s => int.Parse(s) - 1); // ��������� ������������
                }
                reader.ReadLine();
                int[] swapsOrder = Array.ConvertAll(reader.ReadLine().Split(' '), s => int.Parse(s) - 1); // ������� ���������� ������������
                res = Program.Solve(swaps, swapsOrder);
            }

            int[] test = new int[] { 3, 1, 2 };

            Assert.AreEqual(test, res);
        }
    }
}