namespace Transposition
{
    public static class Solution
    {
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
                result[i]++;
            }
            return result;
        }

        public static int[] SolveNew(int[][] swaps, int[] swapsOrder)
        {
            int[] result = new int[swapsOrder.Length];

            for (int i = 0; i < swapsOrder.Length; i++)
            {
                for (int j = 0; j < swapsOrder.Length; j++)
                {
                    if (j == i) continue;
                    result[i] = swaps[swapsOrder[j]][result[i]];
                }
                result[i]++;
            }
            return result;
        }
    }
}
