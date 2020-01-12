using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListProject
{
    class MyList
    {
        private const int initialNumber = 10;
        private int[] elements;

        public int Count { get; private set; }

        public MyList()
        {
            elements = new int[initialNumber];
        }

        public void Add(int i)
        {
            if (Count == elements.Length)
            {
                Increase();
            }
            elements[Count] = i;
            Count++;
        }

        public int GetAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return elements[index];
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = index; i < Count - 1; i++)
            {
                elements[i] = elements[i + 1];
            }
            Count--;
        }

        public void RemoveAll()
        {
            elements = new int[initialNumber];
            Count = 0;
        }

        public void PrintAll()
        {
            if (Count == 0)
            {
                Console.WriteLine("No elements!");
                return;
            }
            for (int i = 0; i < Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(elements[i]);
            }
            Console.WriteLine();
        }

        private void Increase()
        {
            int[] tmp = new int[elements.Length + initialNumber];
            for (int i = 0; i < elements.Length; i++)
            {
                tmp[i] = elements[i];
            }
            elements = tmp;
        }
    }
}
