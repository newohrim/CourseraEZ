using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Digit_of_the_Sum_of_Fibonacci_Numbers_Again
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            Console.WriteLine(LastDig(m, n));
            Console.ReadLine();
        }

        static int LastDig(int m, int n) 
        {
            int sum = 0;
            ulong current = 0;
            ulong next = 1;
            for (int i = 2; i <= n; i++) 
            {
                ulong c = (current + next) % 10;
                current = next;
                next = c;
                if (i < m)
                    continue;
                sum = (sum + (int)(next % 10)) % 10;
            }
            return sum;
        }
    }
}
