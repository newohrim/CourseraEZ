using System;

namespace Number_of_Inversions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(input[i]);
            }
            Console.WriteLine(Inversions(nums));
            Console.ReadLine();
        }

        private static int Inversions(int[] nums) 
        {
            int inversions = 0;
            for (int i = 0; i < nums.Length - 1; i++) 
            {
                for (int j = i + 1; j < nums.Length; j++) 
                {
                    if (nums[i] > nums[j])
                        inversions++;
                }
            }
            return inversions;
        }
    }
}
