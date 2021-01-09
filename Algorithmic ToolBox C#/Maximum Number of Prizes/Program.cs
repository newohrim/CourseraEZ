using System;
using System.Collections.Generic;

namespace Maximum_Number_of_Prizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
        }

        static int[] MaxNumOfPrizes(int n) 
        {
            List<int> nums = new List<int>();
            int st = 1;
            while ((1 << st) < n) 
            { 
                
            }
            int sum = 0;
            for (int i = 1; i < 2 << n; i++) 
            {
                sum += i;
                nums.Add(i);
            }
            nums.Add(n - sum);
            return nums.ToArray();
        }
    }
}
