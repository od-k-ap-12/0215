using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0215
{
    class Book:ICloneable,IComparable,IComparer 
    {
        public string Author;
        public string Name;
        public int PublishingYear;
        public string Genre;
        public Book(string _Author, string _Name, int _PublishingYear, string _Genre)
        {
            Author = _Author;
            Name = _Name;
            PublishingYear = _PublishingYear;
            Genre = _Genre;
        }
        public void Print()
        {
            Console.WriteLine("Author: " + Author + "\nName:" + Name + "\nPublished:" + PublishingYear + "\nGenre:" + Genre);
        }
        public void Input()
        {
            Console.WriteLine("Enter author: ");
            Author = Console.ReadLine();
            Console.WriteLine("Enter name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter publishing year: ");
            PublishingYear =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter genre: ");
            Genre = Console.ReadLine();
        }
        public override string ToString()
        {
            return "Author: " + Author + "\nName:" + Name + "\nPublished:" + PublishingYear + "\nGenre:" + Genre;
        }

        public object Clone()
        {
            return new Book(Author, Name, PublishingYear, Genre);
        }

        public int CompareTo(object obj)
        {
            if (obj is Book)
            {
                return this.PublishingYear.CompareTo((obj as Book).PublishingYear);
            }
            throw new NotImplementedException();
        }

        public int Compare(object x, object y)
        {
            if(x is Book && y is Book)
            {
                return (x as Book).PublishingYear.CompareTo((y as Book).PublishingYear);
            }
            throw new NotImplementedException();
        }
    }
}

