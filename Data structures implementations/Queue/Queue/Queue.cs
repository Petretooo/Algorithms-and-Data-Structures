using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{

    public class QueueNode<T>
    {
        public QueueNode<T> NextNode { get; set; }
        public QueueNode<T> PrevNode { get; set; }

        public T value { get; private set; }

        public QueueNode(T value, QueueNode<T> prevNode = null)
        {
            this.value = value;
            this.PrevNode = prevNode;
        }
    }
    class Queue<T>
    {

        public QueueNode<T> head;
        private QueueNode<T> tail;

        public int Count { get; private set; }

        public void Enqueue(T element)
        {
            if(this.Count == 0)
            {
                this.head = this.tail = new QueueNode<T>(element);
            }
            else
            {
                var node = new QueueNode<T>(element, this.tail);
                this.tail.NextNode = node;
                this.tail = node;

            }
            this.Count++;
        }
        public T Dequeue()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var removedElement = this.head.value;
            this.head = this.head.NextNode;
            this.Count--;

            return removedElement;
        }

        public T[] ToArray()
        {
            var array = new T[this.Count];
            var currentNode = this.head;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = currentNode.value;
                currentNode = currentNode.NextNode;
            }
            return array;
        }


    }
}
