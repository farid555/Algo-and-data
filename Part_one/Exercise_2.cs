using System;

namespace part1

{
    public class Substrings
    {
        public int Calculate (string a, string b)
        {
            int m = b.Length;
            int n = a.Length;
            int sum = 0;
            for (int i = 0; i <= n - m; i++)
            {
                int j;
                for( j = 0; j < m; j++)
                {
                    if (a[i+j] != b[j])
                    {
                        break;
                    } 
                }
                if (j == m)
                {
                    sum++;
                    j = 0;
                }
            }
            return sum;
        }
    }
}