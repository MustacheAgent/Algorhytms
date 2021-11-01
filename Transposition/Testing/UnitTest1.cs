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
                res = Solution.Solve(swaps, swapsOrder);
            }

            int[] test = new int[] { 3, 1, 2 };

            Assert.AreEqual(test, res);
        }

        [Test]
        public void Test2()
        {
            int[] res;
            using (StreamReader reader = new StreamReader(TestContext.CurrentContext.TestDirectory + "\\test2.txt"))
            {
                int[] param = Array.ConvertAll(reader.ReadLine().Split(' '), int.Parse); // ���������� ��������� � ���������� ������� ������������
                int[][] swaps = new int[param[1]][]; // ������ �������� ������������
                for (int i = 0; i < param[1]; i++)
                {
                    swaps[i] = Array.ConvertAll(reader.ReadLine().Split(' '), s => int.Parse(s) - 1); // ��������� ������������
                }
                reader.ReadLine();
                int[] swapsOrder = Array.ConvertAll(reader.ReadLine().Split(' '), s => int.Parse(s) - 1); // ������� ���������� ������������
                res = Solution.Solve(swaps, swapsOrder);
            }

            int[] test = new int[] { 2, 1, 2 };

            Assert.AreEqual(test, res);
        }

        [Test]
        public void Test3()
        {
            int[] res;
            using (StreamReader reader = new StreamReader(TestContext.CurrentContext.TestDirectory + "\\test3.txt"))
            {
                int[] param = Array.ConvertAll(reader.ReadLine().Split(' '), int.Parse); // ���������� ��������� � ���������� ������� ������������
                int[][] swaps = new int[param[1]][]; // ������ �������� ������������
                for (int i = 0; i < param[1]; i++)
                {
                    swaps[i] = Array.ConvertAll(reader.ReadLine().Split(' '), s => int.Parse(s) - 1); // ��������� ������������
                }
                reader.ReadLine();
                int[] swapsOrder = Array.ConvertAll(reader.ReadLine().Split(' '), s => int.Parse(s) - 1); // ������� ���������� ������������
                res = Solution.Solve(swaps, swapsOrder);
            }

            int[] test = new int[] { 1 };

            Assert.AreEqual(test, res);
        }
    }
}