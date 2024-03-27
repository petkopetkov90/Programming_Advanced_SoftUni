using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class ListNode<T>
    {
        private T value;
        private ListNode<T> nextNode;
        private ListNode<T> previousNode;
        public ListNode(T value)
        {
            this.value = value;
        }
        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        public ListNode<T> NextNode
        {
            get { return this.nextNode; }
            set { this.nextNode = value; }
        }
        public ListNode<T> PreviousNode
        {
            get { return this.previousNode; }
            set { this.previousNode = value; }
        }
    }
}
