using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_Amount_of_Gold
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int W = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            input = Console.ReadLine().Split();
            int[] nums = new int[n];
            for (int i = 0; i < n; i++) 
            {
                nums[i] = int.Parse(input[i]);
            }
            Console.WriteLine(MaxValueGold(nums, W));
            Console.ReadLine();
        }

        private static int MaxValueGold(int[] nums, int W) 
        {
            int[] nums2 = new int[nums.Length + 1];
            for (int i = nums.Length; i > 0; i--) 
            {
                nums2[i] = nums[i - 1];
            }
            nums2[0] = 0;
            int[,] val = new int[nums.Length + 1, W + 1];
            for (int i = 0; i < nums2.Length; i++) 
            {
                val[i, 0] = 0;
            }
            for (int i = 0; i <= W; i++)
            {
                val[0, i] = 0;
            }
            for (int i = 1; i < nums2.Length; i++) 
            {
                for (int w = 1; w <= W; w++) 
                {
                    val[i, w] = val[i - 1, w];
                    if (nums2[i] <= w) 
                    {
                        int max = val[i - 1, w - nums2[i]] + nums2[i];
                        if (val[i, w] < max)
                            val[i, w] = max;
                    }
                }
            }
            /*
            for (int i = 0; i < nums2.Length; i++) 
            {
                for (int j = 0; j <= W; j++) 
                {
                    Console.Write(val[i, j] + " ");
                }
                Console.Write(Environment.NewLine);
            }
            */
            return val[nums2.Length - 1, W];
        }
    }
}
