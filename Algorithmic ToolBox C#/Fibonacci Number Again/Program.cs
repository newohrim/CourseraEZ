using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Number_Again
{
    class Program
    {
        static int[] pisano =  { 0, 1, 3 ,  8 ,  6  , 20 ,  24 , 16 , 12 , 24 , 60 , 10 , 24 , 28, 
                            };

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            ulong reminder = ulong.Parse(input[1]);
            Console.WriteLine(FibByAnotherReminder(n, reminder));
            Console.ReadLine();
        }

        static int FibByAnotherReminder(int n, ulong reminder) 
        {
            int rem = n % pisano[reminder];
            return (int)(Fib(rem) % reminder);
        }

        static int FibByReminder(int n, ulong reminder) 
        {
            ulong prevNum = 0;
            ulong currentNum = 1;
            for (int i = 2; i <= n * 100; i++) 
            {
                ulong next = prevNum + currentNum;
                prevNum = currentNum;
                currentNum = next;
                Console.Write(prevNum % reminder + " ");
                if (prevNum % reminder == 0 && currentNum % reminder == 1) 
                {
                    int c = n % (i - 1);
                    return (int)(Fib(c) % reminder);
                }
            }
            Console.Write(currentNum);

            throw new ArgumentException("error");
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
