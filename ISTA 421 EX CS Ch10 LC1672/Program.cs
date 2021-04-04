using System;

namespace ISTA_421_EX_CS_Ch10_LC1672
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] accounts = new int[3][];
            accounts[0] = new int[] { 100, 200, 300 };
            accounts[1] = new int[] { 500 };
            accounts[2] = new int[] { 400, 600, 500 };
            Console.WriteLine(MaximumWealth(accounts));

            int[][] accounts2 = new int[4][];
            accounts2[0] = new int[] { 50, 250, 500 };
            accounts2[1] = new int[] { 10, 25, 1000, 5, 10 };
            accounts2[2] = new int[] { 30, 400, 500, 600, 300, 100  };
            accounts2[3] = new int[] { 200, 700 };
            Console.WriteLine(MaximumWealth(accounts2));
        }


        public static int MaximumWealth(int[][] accounts)
        {
            int[] custTotalWealth = new int[accounts.GetLength(0)];

            for (int i = 0; i < custTotalWealth.Length; i++)
            {
                custTotalWealth[i] = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    custTotalWealth[i] += accounts[i][j];
                }
            }

            int biggestWealth = custTotalWealth[0];

            foreach (int num in custTotalWealth)
            {
                if (num > biggestWealth)
                {
                    biggestWealth = num;
                }
            }

            return biggestWealth;
        }

    }
}
