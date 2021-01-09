using System;

namespace Car_Fueling
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] stops = new int[n];
            string[] lines = Console.ReadLine().Split();
            for (int i = 0; i < n; i++) 
            {
                stops[i] = int.Parse(lines[i]); 
            }
            Console.WriteLine(MinRefuels(d, m, n, stops));
            Console.ReadLine();
        }

        static int MinRefuels(int d, int m, int n, int[] stops) 
        {
            int currentDist = 0;
            int k = 0;
            while (currentDist < d && d - currentDist > m) 
            {
                int nextFuel = 0;
                for (int i = 0; i < n; i++) 
                {
                    if (stops[i] - currentDist <= m && stops[i] > currentDist)
                        nextFuel = stops[i];
                }
                if (nextFuel == 0) return -1;
                currentDist += nextFuel - currentDist;
                k++;
            }
            return k;
        }
    }
}
