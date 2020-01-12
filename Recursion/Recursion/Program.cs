using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(fibonacci(n));
            Console.WriteLine(factoriel(n));
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(euclid(n,b));

            char a = 'A';
            char b1 = 'B';
            char c = 'C';
            hanoiTowers(n, a, b1, c);
        }
        static int fibonacci(int n)
        {
            if (n < 2)
            {
                return 1;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }


        static int factoriel(int n)
        {
            if(n <= 1)
            {
                return 1;
            }
            else
            {
                return factoriel(n - 1) * n;
            }
        }


        static int euclid(int n, int a)
        {
            if(n == 0)
            {
                return a;
            }
            if(a == 0)
            {
                return n;
            }


            if(n > a)
            {
                return euclid(n % a, a);
            }else
            {
                return euclid(n, a % n);
            }
        }

        static void hanoiTowers(int n, char start, char end, char temp)
        {
            if (n > 0)
            {
                hanoiTowers(n-1, start, temp, end);
                Console.WriteLine($"Move from: {start} to: {end}");
                hanoiTowers(n - 1, temp, end, start);
            }
        }
    }
}
