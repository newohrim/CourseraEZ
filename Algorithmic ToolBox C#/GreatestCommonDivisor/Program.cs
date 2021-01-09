using System;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            Console.WriteLine(GCD(a, b));
            Console.ReadLine();
        }

        static int GCD(int a, int b) 
        {
            int c = a % b;
            while (c != 0) 
            {
                a = b;
                b = c;
                c = a % b;
            }
            return b;
        }
    }
}
