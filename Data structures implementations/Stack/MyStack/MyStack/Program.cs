using System;

namespace MyStack
{
    class Program
    {
        static void Main(string[] args)
        {

            MicrosoftStack<int> s = new MicrosoftStack<int>();
            s.Push(4);
            s.Push(22);

            s.Pop();


            /*

            Stack<int> a = new Stack<int>();


            a.Push(1);
            a.Push(2);
            a.Push(3);
            a.Push(15);
            a.Push(11);


            a.Pop();
            a.Pop();

            for (int i = 0; i < a.ToArray().Length; i++)
            {
                Console.WriteLine(a.ToArray()[i]);
            }
            */
        }
    }
}
