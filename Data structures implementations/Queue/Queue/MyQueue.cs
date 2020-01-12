using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{


     class Node<T>
    {
        internal T data;
        internal Node<T> next;

        // Constructor to create a new node.Next is by default initialized as null 
        public Node(T d)
        {
            data = d;
            next = null;
        }
    }
    public class MyQueue<T>
    {
        Node<T> front;
        Node<T> rear;

        public MyQueue()
        {
            this.front = null;//First element of the queue
            this.rear = null;//Last element of the queue
        }

        internal void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);

            // If queue is empty, then new node is front and rear both 
            if (this.rear == null)
            {
                this.front = newNode;
                this.rear = newNode;
            }
            else
            {
                // Add the new node at the end of queue and change rear 
                this.rear.next = newNode;
                this.rear = newNode;
            }
            Console.WriteLine("{0} inserted into Queue", item);
        }

        internal void Dequeue()
        {
            // If queue is empty, return NULL. 
            if (this.front == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            // Store previous front and move front one node ahead 
            Node<T> temp = this.front;
            this.front = this.front.next;

            // If front becomes NULL, then change rear also as NULL 
            if (this.front == null)
            {
                this.rear = null;
            }

            Console.WriteLine("Item deleted is {0}", temp.data);
        }

    }
}
