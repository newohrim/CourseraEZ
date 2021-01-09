using System;

namespace Fibonacci_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
            Console.ReadLine();
        }

        private static ulong Fib(int n) 
        {
            if (n < 2)
                return (ulong)n;
            ulong current = 0;
            ulong next = 1;
            for (int i = 2; i <= n; i++) 
            {
                ulong c = current + next;
                current = next;
                next = c;
            }
            return next;
        }
    }
}
