using System;
using System.Collections.Generic;

namespace Map
{
    class Program
    {
        static void Main(string[] args)
        {
            HashMap<int, string> map = new HashMap<int, string>();

            map.Add(1, "Yep");
            map.Add(1, "eee");
            map.Add(1, "fsf");
            map.Add(12, "dd");


            Console.WriteLine(map.Get(12));
        }
    }
}
