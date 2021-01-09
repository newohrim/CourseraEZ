using System;

namespace Maximum_Value_of_the_Loot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = Console.ReadLine().Split();
            int n = int.Parse(lines[0]);
            int W = int.Parse(lines[1]);
            int[] values = new int[n];
            int[] weights = new int[n];
            for (int i = 0; i < n; i++) 
            {
                lines = Console.ReadLine().Split();
                values[i] = int.Parse(lines[0]);
                weights[i] = int.Parse(lines[1]);
            }
            Console.WriteLine("{0:0.0000}", MaxValueFractions(n, W, values, weights));
            Console.ReadLine();
        }

        static float MaxValueFractions(int n, int W, int[] values, int[] weights) 
        {
            if (W <= 0) 
            {
                return 0.0f;
            }
            float sum = 0;
            int mass = 0;
            // sorting
            for (int i = 0; i < n - 1; i++) 
            {
                for (int j = i + 1; j < n; j++) 
                {
                    if ((float)values[i] / weights[i] < (float)values[j] / weights[j]) 
                    {
                        int temp = values[i];
                        values[i] = values[j];
                        values[j] = temp;
                        temp = weights[i];
                        weights[i] = weights[j];
                        weights[j] = temp;
                    }
                }
            }
            // looting
            int k = 0;
            while (W > 0) 
            {
                int min = Math.Min(weights[k], W);
                W -= min;
                sum += min * ((float)values[k] / weights[k]);
                k++;
                if (k >= n)
                    break;
            }
            return sum;
        }
    }
}
