using System;

namespace Edit_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine(EditDistance(a, b));
            Console.ReadLine();
        }

        private static int EditDistance(string a, string b) 
        {
            a = " " + a.Trim();
            b = " " + b.Trim();
            int n = a.Length;
            int m = b.Length;
            int[,] D = new int[n, m];
            for (int i = 0; i < n; i++) 
            {
                D[i, 0] = i;
            }
            for (int i = 0; i < m; i++)
            {
                D[0, i] = i;
            }
            for (int i = 1; i < n; i++) 
            {
                for (int j = 1; j < m; j++) 
                {
                    int insertion = D[i, j - 1] + 1;
                    int deletion = D[i - 1, j] + 1;
                    int match = D[i - 1, j - 1];
                    int mismatch = D[i - 1, j - 1] + 1;
                    if (a[i] == b[j])
                        D[i, j] = Math.Min(insertion, Math.Min(deletion, match));
                    else
                        D[i, j] = Math.Min(insertion, Math.Min(deletion, mismatch));
                }
            }
            return D[n - 1, m - 1];
        }
    }
}
