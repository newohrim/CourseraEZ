using System;

namespace Money_Change_Again
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(DPChange(num, 1, 3, 4));
            Console.ReadLine();
        }

        private static int DPChange(int money, params int[] coins) 
        {
            int[] MinNumCoins = new int[money + 1];
            MinNumCoins[0] = 0;
            for (int m = 1; m < money + 1; m++) 
            {
                MinNumCoins[m] = int.MaxValue;
                for (int i = 0; i < coins.Length; i++) 
                {
                    if (m >= coins[i]) 
                    {
                        int NumCoins = MinNumCoins[m - coins[i]] + 1;
                        if (NumCoins < MinNumCoins[m])
                            MinNumCoins[m] = NumCoins;  
                    }
                }
            }
            return MinNumCoins[money];
        }
    }
}
