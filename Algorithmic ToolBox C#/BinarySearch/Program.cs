using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input_data = Console.ReadLine().Split();
            int[] nums = new int[input_data.Length - 1];
            for (int i = 1; i < input_data.Length; i++)
                nums[i - 1] = int.Parse(input_data[i]);
            input_data = Console.ReadLine().Split();
            int[] search_nums = new int[input_data.Length - 1];
            for (int i = 1; i < input_data.Length; i++)
                search_nums[i - 1] = int.Parse(input_data[i]);
            int[] indexes = BinarySearch(nums, search_nums);
            foreach (int index in indexes) 
            {
                Console.Write(index + " ");
            }
            Console.ReadLine();
        }

        private static void Swap<T>(ref T a, ref T b) where T : struct
        {
            T temp = a;
            a = b;
            b = temp;
        }

        private static int[] BinarySearch(int[] nums, int[] targets) 
        {
            int[] output = new int[targets.Length];
            for (int i = 0; i < targets.Length; i++) {
                int low = 0;
                int high = nums.Length - 1;
                int f = 0;
                while (low <= high)
                {
                    int mid = (int)(low + (high - low) / 2.0f);
                    if (targets[i] == nums[mid])
                    {
                        output[i] = mid;
                        f = 1;
                        break;
                    }
                    else if (targets[i] < nums[mid])
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                if (f == 1)
                    continue;
                output[i] = - 1;
            }
            return output;
        }
    }
}
