using System;

namespace Euclid
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while(b != 0)
            {
                int c = b;
                b = a % b;
                a = c;
            }
            Console.WriteLine(a);

        }
    }
}
