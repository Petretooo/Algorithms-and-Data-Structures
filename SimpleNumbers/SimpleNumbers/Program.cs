using System;

namespace SimpleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Boolean isTrue = true;
                for (int j = 2; j < numbers[i]; j++)
                {
                    if (numbers[i] % j == 0)
                    {
                        isTrue = false;
                        break;
                    }
                }

                if (isTrue)
                {
                    Console.WriteLine($"This number {numbers[i]} is prime!");
                }
            }
        }
    }
}
