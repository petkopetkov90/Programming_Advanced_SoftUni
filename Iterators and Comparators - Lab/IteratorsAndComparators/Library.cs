using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private BookComparator comparator = new BookComparator();
        public Library(params Book[] books)
        {
            Books = new SortedSet<Book>(books, comparator);
        }
        public SortedSet<Book> Books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;

            private int curentIndex = -1;
            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }
            public Book Current => books[curentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
               
            }

            public bool MoveNext()
            {
                if (curentIndex < books.Count - 1)
                {
                    curentIndex++;
                    return true;
                }

                return false;
            }

            public void Reset()
            {
                curentIndex = -1;
            }
        }
    }
}
