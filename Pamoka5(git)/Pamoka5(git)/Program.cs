using System;

namespace Pamoka5_git_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            int skaicius3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Max(skaicius1, skaicius2, skaicius3));
            Console.WriteLine(InRange(skaicius1, skaicius2, skaicius3));
            Console.WriteLine(IsPrimal(skaicius1, skaicius2, skaicius3));

        }
        static int Max(int a, int b, int c)
        {
            int max;
            if (a > b && a > c) max = a;
            else if (b > c) max = b;
            else max = c;
            return max;
        }

        static bool InRange(int testNumber, int minValue, int maxValue)
        {

             bool test = testNumber >= minValue && testNumber <= maxValue;
            return test;
            
        }

        static bool IsPrimal(int a,int b, int c)
        {
           

            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                    
                }
            }
            return true;     
                
            
            
        }

    }
}
