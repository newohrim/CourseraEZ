using System;

namespace Money_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(MinimumCoins(n));
            Console.ReadLine();
        }

        static int MinimumCoins(int n) 
        {
            int sum = 0;
            int k = 0;
            int[] coins = { 10, 5, 1 };
            int i = 0;
            while (sum < n) 
            {
                sum += coins[i];
                if (sum > n) 
                {
                    sum -= coins[i];
                    i++;
                    continue;
                }
                k++;
            }
            return k;
        }
    }
}
