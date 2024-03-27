using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Implement_the_CustomList_Class
{
    public class CustomList
    {
        private const int Capacity = 2;
        private int[] array;
        private int count;
        public CustomList()
        {
            array = new int[Capacity];
            this.Count = 0;
        }
        public int this[int index]
        {
            get
            {
                if (CheckForValidIndex(index))
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.array[index];
            }
            set
            {
                if (CheckForValidIndex(index))
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.array[index] = value;
            }
        }
        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        public void Add(int element)
        {
            if (this.Count == this.array.Length)
            {
                this.Resize();
            }

            this.array[this.Count] = element;
            this.Count++;
        }

        public int RemoveAt(int index)
        {
            if (CheckForValidIndex(index))
            {
                throw new ArgumentOutOfRangeException();
            }

            int element = this.array[index];
            this.Shift(index);
            this.Count--;

            if (this.Count < this.array.Length / 4)
            {
                this.Shrink();
            }

            return element;
        }

        private bool CheckForValidIndex(int index)
        {
            return index < 0 || index >= this.Count;
        }

        public bool Contains(int element)
        {
            foreach (int currentElement in this.array)
            {
                if (currentElement == element)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int index1, int index2)
        {
            if (index1 > -1 && index1 < this.Count && index2 < this.Count && index2 > -1)
            {
                int temp = this.array[index1];
                this.array[index1] = this.array[index2];
                this.array[index2] = temp;
            }
        }

        public void Insert(int index, int element)
        {
            if (this.Count == this.array.Length)
            {
                this.Resize();
            }

            this.ShiftRight(index);

            this.array[index] = element;
            count++;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.array[i]);
            }
        }

        private void Resize()
        {
            int[] newArray = new int[this.array.Length * 2];

            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.array[i];
            }

            this.array = newArray;
        }

        private void Shrink()
        {
            int[] newArray = new int[this.array.Length / 2];

            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.array[i];
            }

            this.array = newArray;
        }

        private void Shift(int index)
        {

            for (int i = index; i < this.Count - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
        }
        private void ShiftRight(int index)
        {
            for (int i = this.Count; i > index; i--)
            {
                this.array[i] = this.array[i - 1];
            }
        }
    }
}
