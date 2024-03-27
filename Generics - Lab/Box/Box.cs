using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> stack;
        private int count;

        public Box()
        {
            stack = new Stack<T>();
        }

        public int Count
        { get { return count; } }

        public void Add(T element)
        {
            stack.Push(element);
            count++;
        }

        public T Remove()
        {
            count--;
            return stack.Pop();
        }
    }
}
