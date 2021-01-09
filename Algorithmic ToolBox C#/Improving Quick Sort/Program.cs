using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Improving_Quick_Sort
{
    class Program
    {
        private static Random rnd = new Random();

        static void Main(string[] args)
        {
            do
            {
                /*
                int n = int.Parse(Console.ReadLine());
                string[] input = Console.ReadLine().Split();
                int[] nums = new int[n];
                for (int i = 0; i < n; i++)
                {
                    nums[i] = int.Parse(input[i]);
                }
                */
                int n = 10;
                int[] nums = new int[n];
                for (int i = 0; i < n; i++) 
                {
                    nums[i] = rnd.Next(1, 100);
                }
                QuickSort(ref nums, 0, n - 1);
                foreach (int num in nums)
                {
                    Console.Write(num + " ");
                }
                Console.ReadLine();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static void QuickSort(ref int[] nums, int left, int right) 
        {
            if (left >= right)
                return;
            //int k = rnd.Next(left, right + 1);
            //Swap(ref nums[left], ref nums[k]);
            int[] m = Partition3(ref nums, left, right);
            QuickSort(ref nums, left, m[0] - 1);
            QuickSort(ref nums, m[1] + 1, right);
        }

        private static int[] Partition3(ref int[] nums, int left, int right) 
        {
            int[] m = new int[2];
            int x = nums[left];
            int index = left;
            for (int i = left + 1; i <= right; i++) 
            {
                if (nums[i] < x) 
                {
                    if (index < i - 1)
                        Swap(ref nums[index + 1], ref nums[i]);
                    else
                        index++;
                }
            }
            Swap(ref nums[left], ref nums[index]);
            m[0] = index;
            int offset = 0;
            for (int i = index + 1; i <= right; i++) 
            {
                if (nums[i] == x) 
                {
                    offset++;
                    if (index + offset == i) continue;
                    Swap(ref nums[index + offset], ref nums[i]);
                }
            }
            m[1] = index + offset;
            return m;
        }

        private static void Swap<T>(ref T a, ref T b) where T : struct
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
