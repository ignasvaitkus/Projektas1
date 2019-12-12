using System;

namespace Pamoka5_git_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            int skaicius3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Max(skaicius1, skaicius2, skaicius3));

        }
        static int Max(int a, int b, int c)
        {
            int max;
            if (a > b && a > c) max = a;
            else if (b > c) max = b;
            else max = c;
            return max;
        }
    }
}
