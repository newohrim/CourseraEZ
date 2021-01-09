using System;

namespace Majority_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[input.Length];
            for (int i = 0; i < input.Length; i++) 
            {
                nums[i] = int.Parse(input[i]);
            }
            Console.WriteLine(IsMajor2(nums));
            Console.ReadLine();
        }

        private static int IsMajorityWithSort(int[] nums) 
        {
            int mid = (nums.Length - 1) / 2;
            nums = Sort(nums, 0, mid);
            nums = Sort(nums, mid + 1, nums.Length - 1);
            int[] output = new int[nums.Length];
            int k = 0;
            int index1 = 0;
            int index2 = mid + 1;
            for (int i = 0; i < nums.Length; i++) 
            {
                if (index2 == nums.Length) 
                {
                    output[k] = nums[index1];
                    k++;
                    nums[index1] = int.MaxValue;
                    index1++;
                    continue;
                }
                if (index1 == mid + 1) 
                {
                    output[k] = nums[index2];
                    k++;
                    nums[index2] = int.MaxValue;
                    index2++;
                    continue;
                }
                if (nums[index1] < nums[index2])
                {
                    output[k] = nums[index1];
                    k++;
                    nums[index1] = int.MaxValue;
                    index1++;
                }
                else 
                {
                    output[k] = nums[index2];
                    k++;
                    nums[index2] = int.MaxValue;
                    index2++;
                }
            }
            int median = output[(nums.Length - 1) / 2];
            int count = 0;
            for (int i = 0; i < output.Length; i++) 
            {
                if (output[i] == median)
                    count++;
            }
            if (count > nums.Length / 2)
                return 1;
            else
                return 0;
            //if (output[nums.Length / 2] == output[0] || output[nums.Length / 2] == output[nums.Length - 1])
            /*
            if (output[nums.Length / 2] == output[(int)(nums.Length * 0.25f)] || output[nums.Length / 2] == output[(int)(nums.Length * 0.75f)])
                return 1;
            else
                return 0;
            */
        }

        private static int IsMajor2(int[] nums) 
        {
            int counter = 0;
            int majorityElement = -1;
            for (int i = 0; i < nums.Length; i++) 
            {
                if (counter == 0)
                {
                    majorityElement = nums[i];
                    counter = 1;
                }
                else if (nums[i] == majorityElement)
                    counter++;
                else
                    counter--;
            }
            counter = 0;
            for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[i] == majorityElement)
                    counter++;
            }
            if (counter > nums.Length / 2)
                return 1;
            else
                return 0;
        }

        private static int[] Sort(int[] nums, int left, int right) 
        {
            for (int i = left; i <= right - 1; i++) 
            {
                for (int j = i + 1; j <= right; j++) 
                {
                    if (nums[i] > nums[j])
                        Swap(ref nums[i], ref nums[j]);
                }
            }
            return nums;
        }

        private static void Swap<T>(ref T a, ref T b) where T : struct
        {
            T temp = a;
            a = b;
            b = temp;
        }

        private static int IsMajority(int[] nums) 
        {
            int[] counts = new int[nums.Length];
            int[] tempNums = new int[nums.Length];
            int k = 0;
            for (int i = 0; i < nums.Length; i++) 
            {
                int f = 0;
                for (int j = 0; j < tempNums.Length; j++) 
                {
                    if (tempNums[j] == nums[i])
                    {
                        counts[j]++;
                        f = 1;
                        break;
                    }
                }
                if (f == 0) 
                {
                    tempNums[k] = nums[i];
                    counts[k] = 1;
                    k++;
                }
            }
            for (int i = 0; i < k; i++) 
            {
                if (counts[i] > nums.Length / 2)
                    return 1;
            }
            return 0;
        }
    }
}
