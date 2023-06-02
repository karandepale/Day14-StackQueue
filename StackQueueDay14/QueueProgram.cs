using System;

namespace StackQueueDay14
{
    public class Queue
    {
        private Node front; // Reference to the front node of the queue
        private Node rear; // Reference to the rear node of the queue

        // Node class represents an individual element in the queue
        private class Node
        {
            public int Data;
            public Node Next;
        }

        // Enqueue method adds an element to the rear of the queue
        public void Enqueue(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;

            if (front == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        // Dequeue method removes and returns the front element from the queue
        public int Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
                return -1; // or throw an exception
            }

            int data = front.Data;
            front = front.Next;

            if (front == null)
                rear = null;

            return data;
        }

        // Display method prints the elements in the queue from front to rear
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Node current = front;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

    internal class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Queue Implementation ...");

            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            queue.Display(); // Output: 56 30 70

            int dequeuedElement = queue.Dequeue();
            Console.WriteLine("Dequeued: " + dequeuedElement); // Output: Dequeued: 56

            queue.Display(); // Output: 30 70

            int dequeuedElement2 = queue.Dequeue();
            Console.WriteLine("Dequeued: " + dequeuedElement2); // Output: Dequeued: 30

            queue.Display(); // Output: 70
        }
    }
}
