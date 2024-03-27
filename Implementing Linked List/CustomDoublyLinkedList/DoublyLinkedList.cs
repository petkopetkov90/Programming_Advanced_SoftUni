using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private ListNode head;
        private ListNode tail;
        private int count;
        public DoublyLinkedList()
        {
            this.count = 0;
        }

        public int Count
        {
            get { return this.count; }
        }
        public void AddFirst(int element)
        {
            ListNode newNode = new ListNode(element);

            this.count++;

            if (this.tail == null)
            {
                this.head = newNode;
                this.tail = newNode;
                return;
            }

            newNode.NextNode = this.head;
            this.head.PreviousNode = newNode;
            this.head = newNode;
        }

        public void AddLast(int element)
        {
            this.count++;
            ListNode newNode = new ListNode(element);

            if (this.head == null)
            {
                this.head = newNode;
                this.tail = newNode;
                return;
            }

            newNode.PreviousNode = this.tail;
            this.tail.NextNode = newNode;
            this.tail = newNode;
        }

        public int RemoveFirst()
        {
            if (this.Count == 0)
            {
                return default;
            }

            ListNode currentNode = this.head;

            if (this.Count == 0)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                this.head = currentNode.NextNode;
                this.head.PreviousNode = null;
                currentNode.NextNode = null;
            }
            this.count--;

            return currentNode.Value;

        }

        public int RemoveLast()
        {
            if (this.Count == 0)
            {
                return default;
            }

            ListNode currentNode = this.tail;

            if (this.Count == 0)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                this.tail = currentNode.PreviousNode;
                this.tail.NextNode = null;
                currentNode.PreviousNode = null;
            }

            this.count--;
            return currentNode.Value;
        }

        public void ForEach(Action<int> action)
        {
            ListNode currentNode = this.head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[this.count];
            ListNode currentNode = this.head;

            for (int i = 0; i < this.count; i++)
            {
                array[i] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return array;
        }

        public string Join(string separator)
        {
            if (this.head == null)
            {
                return default;
            }
            StringBuilder stringBuilder = new StringBuilder();
            ListNode currentNode = this.head;
            while (currentNode.NextNode != null)
            {
                stringBuilder.Append(currentNode.Value + separator);
                currentNode = currentNode.NextNode;
            }

            stringBuilder.Append(currentNode.Value);

            return stringBuilder.ToString();
        }

        public bool Contains(int value)
        {
            ListNode currentNode = this.head;
            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    return true;
                }

                currentNode = currentNode.NextNode;
            }

            return false;
        }

        public void Clear()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }
    }
}
