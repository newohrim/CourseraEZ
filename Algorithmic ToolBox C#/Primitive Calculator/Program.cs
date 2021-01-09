using System;

namespace Primitive_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] steps;
            Console.WriteLine(MinStepsTo(n, out steps));
            for (int i = steps.Length - 1; i >= 0; i--) 
                if (steps[i] != 0)
                    Console.Write(steps[i] + " ");
            Console.ReadLine();
        }

        private static int MinStepsTo(int n, out int[] steps) 
        {
            steps = new int[n];
            steps[0] = n;
            int[] minStepsFor = new int[n + 1];
            minStepsFor[0] = 0;
            minStepsFor[1] = 0;
            for (int i = 2; i <= n; i++) 
            {
                minStepsFor[i] = int.MaxValue;
                //int num = Math.Min(minStepsFor[i - 1] + 1, minStepsFor[i]);
                int num = minStepsFor[i - 1] + 1;
                if (num < minStepsFor[i])
                {
                    minStepsFor[i] = num;
                }
                if (i % 2 == 0)
                {
                    num = minStepsFor[i / 2] + 1;
                    if (num < minStepsFor[i])
                    {
                        minStepsFor[i] = num;
                    }
                }
                if (i % 3 == 0) 
                {
                    num = minStepsFor[i / 3] + 1;
                    if (num < minStepsFor[i])
                    {
                        minStepsFor[i] = num;
                    }
                }
            }
            int minSteps = minStepsFor[n];
            int k = 1;
            while (n != 1) 
            {
                if (n % 3 == 0 && minStepsFor[n] - 1 == minStepsFor[n / 3])
                {
                    steps[k] = n / 3;
                    n /= 3;
                }
                else if (n % 2 == 0 && minStepsFor[n] - 1 == minStepsFor[n / 2])
                {
                    steps[k] = n / 2;
                    n /= 2;
                }
                else 
                {
                    steps[k] = n - 1;
                    n -= 1;
                }
                k++;
            }
            return minSteps;
        }
    }
}
