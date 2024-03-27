using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authos = authors.ToList();
        }
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authos { get; set; }

        public int CompareTo(Book other)
        {
            if (this.Year.CompareTo(other.Year) != 0)
            {
                return this.Year.CompareTo(other.Year);
            }

            return this.Title.CompareTo(other.Title);
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
