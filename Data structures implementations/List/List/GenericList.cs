using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class GenericList<T>
    {
        private int initialNumber = 10;
        private T[] elements;

        public int Count { get; private set; }

        public GenericList()
        {
            elements = new T[initialNumber];
        }

        private void Increase()
        {
            T[] temp = new T[elements.Length + initialNumber];
            for (int i = 0; i < elements.Length; i++)
            {
                temp[i] = elements[i];
            }
            elements = temp;
        }

        public void Add(T i)
        {
            if (Count == elements.Length)
            {
                Increase();
            }
            elements[Count] = i;
            Count++;
        }

        public void GetAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine(elements[index]);
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = index; i < Count-1; i++)
            {
                elements[i] = elements[i + 1];
            }
            Count--;
        }

        public void RemoveAll()
        {
            elements = new T[initialNumber];
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
                if(i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(elements[i]);
            }
            Console.WriteLine();
        }


    }
}
