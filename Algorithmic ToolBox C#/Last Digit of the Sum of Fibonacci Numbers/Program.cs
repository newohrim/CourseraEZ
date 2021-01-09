using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Digit_of_the_Sum_of_Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(ComputeFibSum(n));
            Console.ReadLine();
        }

        static int ComputeFibSum(int n) 
        {
            if (n == 0)
                return 0;
            int sum = 1;
            ulong current = 0;
            ulong next = 1;
            for (int i = 2; i <= n; i++) 
            {
                ulong c = next + current;
                current = next;
                next = c;
                sum = (sum + (int)(next % 10)) % 10;
            }
            return sum;
        }
    }
}
