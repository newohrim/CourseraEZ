using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumPairwiseProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] lines = Console.ReadLine().Split();
            long max1 = long.Parse(lines[0]);
            long max2 = 0;
            for (int i = 1; i < n; i++) 
            {
                if (long.Parse(lines[i]) > max1)
                {
                    max2 = max1;
                    max1 = long.Parse(lines[i]);
                }
                else if (long.Parse(lines[i]) > max2) 
                {
                    max2 = long.Parse(lines[i]);
                }
            }
            Console.WriteLine(max1 * max2);
            Console.ReadLine();
        }
    }
}
