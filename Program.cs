using System;

namespace ks_Target_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(" ");

            int n = int.Parse(str[0]);
            int m = int.Parse(str[1]);

            Console.WriteLine(F(m - 1) / (F(n - 1) * F(m - n)));

        }

        static int F(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * F(x - 1);
            }
        }
    }
}
