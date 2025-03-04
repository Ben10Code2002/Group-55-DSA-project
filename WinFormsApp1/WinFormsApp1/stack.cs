using System;

namespace WinFormsApp1
{
    //The same stack function which we used in lectures, however with few extra implementations
    public class Stack
    {
        private string[] elements;
        private int top;
        private int capacity;

        
        public Stack(int size)
        {
            capacity = size;
            elements = new string[capacity];
            top = -1;
        }

        // Push method to add elements to the stack
        public void Push(string item)
        {
            if (top == capacity - 1)
            {
                Console.WriteLine("Capacity filled");
                return;
            }
            elements[++top] = item;
        }

        // Pop method to remove elements from the stack
        public string Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return default;
            }
            return elements[top--];
        }

        // Peek method to return the top element
        public string Peek()
        {
            if (IsEmpty())
            {
                return "Stack is empty!";
            }
            return elements[top];
        }

        // Check if stack is empty
        public bool IsEmpty()
        {
            return top == -1;
        }

        // Return the current size of the stack
        public int Size()
        {
            return top + 1;
        }

        // Return the index of the top of the stack
        public int GetTop()
        {
            return top;
        }

        // Return the element at a specific index without modifying the stack
        public string GetElement(int index)
        {
            if (index >= 0 && index <= top)
            {
                return elements[index];
            }
            else
            {
                return "Invalid Index!";
            }
        }
    }

}
