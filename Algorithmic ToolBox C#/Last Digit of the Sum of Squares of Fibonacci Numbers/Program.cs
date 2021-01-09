using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Digit_of_the_Sum_of_Squares_of_Fibonacci_Numbers
{
    class Program
    {
        static int[] pisano =  { 0, 1, 3 ,  8 ,  6  , 20 ,  24 , 16 , 12 , 24 , 60 , 10 , 24 , 28,
                            };

        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine(ComputeBySqueres(n));
            Console.ReadLine();
        }

        static int LastDigSquere(ulong n) 
        {
            int sum = 1;
            ulong current = 0;
            ulong next = 1;
            for (ulong i = 2; i <= n; i++) 
            {
                ulong c = (current + next) % 10;
                current = next;
                next = c;
                sum = (sum + (int)(next * next)) % 10; 
            }
            return sum;
        }

        static int ComputeBySqueres(ulong n) 
        {
            int height = (int)(n % 10);
            int width = FibByAnotherReminder(n - 1, 10) + FibByAnotherReminder(n, 10);
            return (int)(checked(height * width) % 10);
        }

        static int FibByAnotherReminder(ulong n, ulong reminder)
        {
            ulong rem = n % (ulong)pisano[reminder];
            return (int)(Fib(rem) % reminder);
        }

        private static ulong Fib(ulong n)
        {
            if (n <= 2)
                return (ulong)n;
            ulong[] fibNums = new ulong[n];
            fibNums[0] = 0;
            fibNums[1] = 1;
            for (ulong i = 2; i < n; i++)
            {
                fibNums[i] = fibNums[i - 2] + fibNums[i - 1];
            }
            return fibNums[n - 1];
        }
    }
}
