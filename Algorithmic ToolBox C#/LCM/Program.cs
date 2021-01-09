using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCM
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            ulong a = ulong.Parse(input[0]);
            ulong b = ulong.Parse(input[1]);
            Console.WriteLine(LCM(a, b));
            Console.ReadLine();
        }

        static ulong LCM(ulong a, ulong b) 
        {
            double lcm = (double)(a * b) / GCD(a, b);
            if (Math.Abs(lcm) != lcm)
                return a * b;
            return (ulong)lcm;
        }

        static int GCD(ulong a, ulong b)
        {
            int c = (int)(a % b);
            while (c != 0)
            {
                a = b;
                b = (ulong)c;
                c = (int)(a % b);
            }
            return (int)b;
        }
    }
}
