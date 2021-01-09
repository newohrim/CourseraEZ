using System;

namespace FibLastNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(LastFibDigit(n));
            Console.ReadLine();
        }

        static int LastFibDigit(int n) 
        {
            if (n < 2)
                return n;

            int current = 0;
            int next = 1;

            for (int i = 2; i <= n; i++) 
            {
                int temp = current + next;
                current = next;
                next = temp % 10;
            }

            return next;
        }

        private static ulong Fib(int n)
        {
            if (n <= 2)
                return (ulong)n;
            ulong[] fibNums = new ulong[n];
            fibNums[0] = 0;
            fibNums[1] = 1;
            for (int i = 2; i < n; i++)
            {
                fibNums[i] = fibNums[i - 2] + fibNums[i - 1];
            }
            return fibNums[n - 1];
        }
    }
}
