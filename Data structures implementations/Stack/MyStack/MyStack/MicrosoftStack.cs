using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack
{
     class Node<T>
    {
        internal T data;
        internal Node<T> next; 
        public Node(T d)
        {
            data = d;
            next = null;
        }
    }

    public class MicrosoftStack<T>
    {
        Node<T> top;
        public MicrosoftStack()
        {
            this.top = null;
        }
        internal void Push(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine("{0} pushed to stack", value);
        }
        internal void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow. Deletion not possible");
                return;
            }

            Console.WriteLine("Item popped is {0}", top.data);
            top = top.next;
        }
        internal void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow.");
                return;
            }
            Console.WriteLine("{0} is on the top of Stack", this.top.data);
        }
    }
}
