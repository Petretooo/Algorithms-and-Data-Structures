using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> a = new MyQueue<int>();

            a.Enqueue(2);
            a.Enqueue(3);
            a.Enqueue(4);
            a.Enqueue(5);
            a.Enqueue(6);
            a.Enqueue(7);
            a.Enqueue(8);

            a.Dequeue();
            a.Dequeue();
            a.Dequeue();

            
        }
    }
}
