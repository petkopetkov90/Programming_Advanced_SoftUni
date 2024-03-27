using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoublyLinkedList
{
    public class ListNode
    {
        private int value;
        private ListNode nextNode;
        private ListNode previousNode;
        public ListNode(int value)
        {
            this.value = value;
        }
        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        public ListNode NextNode
        {
            get { return this.nextNode; }
            set { this.nextNode = value; }
        }
        public ListNode PreviousNode
        {
            get { return this.previousNode; }
            set { this.previousNode = value; }
        }
    }
}