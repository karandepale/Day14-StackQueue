﻿using System;

namespace StackQueueDay14
{
    public class Stack
    {
        private Node top;

        private class Node
        {
            public int Data;
            public Node Next;
        }

        public void Push(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;

            if (top == null)
                top = newNode;
            else
            {
                newNode.Next = top;
                top = newNode;
            }
        }

        public int Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }

            int data = top.Data;
            top = top.Next;
            return data;
        }

        public int Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }

            return top.Data;
        }

        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Node current = top;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void PopAll()
        {
            while (top != null)
            {
                Console.WriteLine("Popped: " + Pop());
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Queue Implementation ...");

            Stack stack = new Stack();
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);

            stack.Display(); // Output: 70 30 56

            Console.WriteLine("Peek: " + stack.Peek()); // Output: Peek: 70

            stack.PopAll();
            // Output: 
            // Popped: 70
            // Popped: 30
            // Popped: 56

            stack.Display(); // Output: Stack is empty
        }
    }
}
