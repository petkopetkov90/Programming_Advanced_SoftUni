using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_the_CustomQueue_Class
{
    public class CustomQueue
    {
        private const int InitialCapacity = 4;
        private const int FirstElementsIndex = 0;
        private int[] elements;
        private int count;

        public CustomQueue()
        {
            this.elements = new int[InitialCapacity];
            this.Count = 0;
        }

        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        public void Enqueue(int value)
        {
            if (this.Count == this.elements.Length)
            {
                this.Resize();
            }
            this.elements[this.Count++] = value;
        }

        public int Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            int currentElemetns = this.elements[FirstElementsIndex];
            this.Count--;
            this.Shift();

            if (this.Count == this.elements.Length / 4)
            {
                this.Shrink();
            }

            return currentElemetns;
        }

        public int Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            return this.elements[FirstElementsIndex];
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.elements[i]);
            }
        }

        public void Clear()
        {
            this.elements = new int[InitialCapacity];
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

            for (int i = 0; i < this.count; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }

        private void Shift()
        {
            for (int i = 0; i < this.Count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
        }
    }
}
