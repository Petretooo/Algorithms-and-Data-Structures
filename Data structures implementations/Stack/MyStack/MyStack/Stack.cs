using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack
{
    /*
    public class Node<T>
    {
        public Node<T> NextNode { get; set; }
        public T value { get; set; }
        public Node(T value, Node<T> nextNode = null)
        {
            this.value = value;
            this.NextNode = nextNode;
        }
    }
    class Stack<T>
    {
        private Node<T> firstNode;
        public int Count { get; private set; }
        public void Push(T element)
        {
            this.firstNode = new Node<T>(element, this.firstNode);
            this.Count++;
        }
        public T Pop()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException();
            }
            var removedNode = this.firstNode;
            this.firstNode = this.firstNode.NextNode;
            this.Count--;
            return removedNode.value;
        }
        public T[] ToArray()
        {
            var currentNode = this.firstNode;
            var array = new T[this.Count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = currentNode.value;
                currentNode = currentNode.NextNode;
            }
            return array;
        }
    }
    */
}
