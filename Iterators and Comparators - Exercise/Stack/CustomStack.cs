using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private const int initialCapacity = 4;
        private T[] elements;
        private int count = 0;
        public CustomStack()
        {
            this.elements = new T[initialCapacity];
        }

        public void Push(params T[] elements)
        {
            foreach (var element in elements)
            {
                if (count == initialCapacity)
                {
                    Resize();
                }

                this.elements[count++] = element;
            }
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            count--;
            return elements[count];
        }

        private void Resize()
        {
            T[] newArray = new T[elements.Length * 2];

            for (int i = 0; i < count - 1; i++)
            {
                newArray[i] = elements[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = count - 1; i >= 0; i--)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
