using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maximum_Advertisement_Revenue
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputData = Console.ReadLine().Split();
            int[] profit = new int[n];
            for (int i = 0; i < n; i++) 
            {
                profit[i] = int.Parse(inputData[i]);
            }
            inputData = Console.ReadLine().Split();
            int[] averageClick = new int[n];
            for (int i = 0; i < n; i++) 
            {
                averageClick[i] = int.Parse(inputData[i]);
            }
            Console.WriteLine(MaxAdRevenue(n, profit, averageClick));
            Console.ReadLine();
        }

        static long MaxAdRevenue(int n, int[] profit, int[] averageClick) 
        {
            List<int> profitList = profit.ToList();
            profitList.Sort();
            List<int> averageClickList = averageClick.ToList();
            averageClickList.Sort();
            long sum = 0;
            for (int i = 0; i < n; i++) 
            {
                sum += (long)profitList[i] * averageClickList[i];
            }
            return sum;
        }
    }
}
