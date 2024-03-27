using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Implement_the_CustomStack_Class
{
    public class CustomStack
    {
        private const int InitialCapacity = 4;
        private int[] elements;
        private int count;

        public CustomStack()
        {
            elements = new int[InitialCapacity];
            this.Count = 0;
        }

        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        public void Push(int element)
        {
            if (this.Count == this.elements.Length)
            {
                this.Resize();
            }

            this.elements[this.Count++] = element;
        }

        public int Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            this.Count--;
            int currentElement = this.elements[this.Count];

            if (this.Count == this.elements.Length / 4)
            {
                this.Shrink();
            }

            return currentElement;

        }

        public int Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            return this.elements[this.Count - 1];
        }

        public void ForEach(Action<int> action)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                action(this.elements[i]);
            }
        }

        public void Clear()
        {
            int[] newElements = new int[InitialCapacity];
            this.elements = newElements;
            this.Count = 0;
        }

        private void Resize()
        {
            int[] newElements = new int[this.elements.Length * 2];

            for (int i = 0; i < this.Count; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }

        private void Shrink()
        {
            int[] newElements = new int[this.elements.Length / 2];

            for (int i = 0; i < this.Count; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }

        public bool Contains(int value)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i] == value)
                {
                    return true;
                }
            }

            return false;
        }

        public double Average()
        {
            double sum = 0;

            for (int i = 0; i < this.Count; i++)
            {
                sum += this.elements[i];
            }

            return sum / this.Count;
        }

        public int Sum()
        {
            int sum = 0;

            for (int i = 0; i < this.Count; i++)
            {
                sum += this.elements[i];
            }

            return sum;
        }
    }
}
