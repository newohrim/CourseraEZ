using System;

namespace Partitioning_Souvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int[] values = new int[n];
            for (int i = 0; i < n; i++) 
            {
                values[i] = int.Parse(input[i]);
            }
            Console.WriteLine(IsPartitionBy3(values));
            Console.ReadLine();
        }

        private static int IsPartitionBy3(int[] nums) 
        {
            int sum = 0;
            foreach (int num in nums) 
            {
                sum += num;
            }
            if (sum % 3 != 0)
                return 0;
            sum = sum / 3;
            int count = 0;
            int[,] val = new int[sum + 1, nums.Length + 1];
            for (int i = 0; i <= nums.Length; i++) 
            {
                val[0, i] = 0;
            }
            for (int j = 0; j <= sum; j++)
            {
                val[j, 0] = 0;
            }
            for (int i = 1; i < sum + 1; i++) 
            {
                for (int j = 1; j < nums.Length + 1; j++) 
                {
                    val[i, j] = val[i, j - 1];
                    if (nums[j - 1] <= i) 
                    {
                        int temp = val[i - nums[j - 1], j - 1] + nums[j - 1];
                        if (temp > val[i, j])
                            val[i, j] = temp;
                    }
                    if (val[i, j] == sum)
                        count++;
                }
            }

            if (count < 3)
                return 0;
            else
                return 1;
        }
    }
}
