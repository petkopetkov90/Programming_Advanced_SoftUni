using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T> where T : IComparable<T>
    {
        private ListNode<T> head;
        private ListNode<T> tail;
        private int count = 0;

        public int Count
        {
            get { return this.count; }
        }
        public void AddFirst(T element)
        {
            ListNode<T> newNode = new ListNode<T>(element);

            if (this.Count == 0)
            {
                this.head = newNode;
                this.tail = newNode;
                this.count++;
                return;
            }

            newNode.NextNode = this.head;
            this.head.PreviousNode = newNode;
            this.head = newNode;
            this.count++;
        }

        public void AddLast(T element)
        {
            ListNode<T> newNode = new ListNode<T>(element);

            if (this.Count == 0)
            {
                this.head = newNode;
                this.tail = newNode;
                this.count++;
                return;
            }

            newNode.PreviousNode = this.tail;
            this.tail.NextNode = newNode;
            this.tail = newNode;
            this.count++;
        }

        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }

            T removedElement = this.head.Value;

            if (count == 1)
            {
                this.head = default;
                this.tail = default;
            }
            else
            {
                this.head = this.head.NextNode;
                this.head.PreviousNode = default;
            }

            this.count--;
            return removedElement;

        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }

            T removedElement = this.tail.Value;

            if (count == 1)
            {
                this.head = default;
                this.tail = default;
            }
            else
            {
                this.tail = this.tail.PreviousNode;
                this.tail.NextNode = default;
            }

            this.count--;
            return removedElement;
        }

        public void ForEach(Action<T> action)
        {
            ListNode<T> currentNode = this.head;

            for (int i = 0; i < this.Count; i++)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public T[] ToArray()
        {
            T[] array = new T[this.count];
            ListNode<T> currentNode = this.head;

            for (int i = 0; i < this.count; i++)
            {
                array[i] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return array;
        }

        public string Join(string separator)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }

            StringBuilder stringBuilder = new StringBuilder();
            ListNode<T> currentNode = this.head;

            while (currentNode.NextNode != null)
            {
                stringBuilder.Append(currentNode.Value + separator);
                currentNode = currentNode.NextNode;
            }

            stringBuilder.Append(currentNode.Value);

            return stringBuilder.ToString();
        }

        public bool Contains(T value)
        {
            ListNode<T> currentNode = this.head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return true;
                }

                currentNode = currentNode.NextNode;
            }

            return false;
        }

        public void Clear()
        {
            this.head = default;
            this.tail = default;
            this.count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            ListNode<T> current = this.head;

            for (int i = 0; i < Count; i++)
            {
                yield return current.Value;
                current = current.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
