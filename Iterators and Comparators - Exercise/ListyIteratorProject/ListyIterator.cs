using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIteratorProject
{
    public class ListyIterator<T>
    {
        private List<T> elements;
        int index = 0;
        public ListyIterator(params T[] elements)
        {
            this.elements = new List<T>(elements);
        }

        public bool Move()
        {
            if (index < elements.Count - 1)
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (index < elements.Count - 1)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(elements[index]);
            }
        }
    }
}
