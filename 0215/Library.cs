using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0215
{
    class Library:IEnumerable,IEnumerator
    {
        int curpos = -1;
        private Book[] arr;
        public Library(params Book[] book)
        {
            arr = new Book[book.Length];
            for (int i = 0; i < book.Length; i++)
                arr[i] = book[i];
        }
        public Library(int size)
        {
            arr = new Book[size];
        }
        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                {
                    return arr[index];
                }
                else
                {
                    throw new Exception("Invalid index");
                }
            }
            set
            {
                if (index >= 0 && index < arr.Length)
                {
                    arr[index] = value;
                }
                else
                {
                    throw new Exception("Invalid index");
                }
            }

        }

        public object Current
        {
            get
            {
                return arr[curpos];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if ((int)Current < arr.Length - 1)
            {
                curpos++;
                return true;
            }
            else
            {
                this.Reset();
                return false;
            }
        }

        public void Reset()
        {
           curpos = -1;
        }
    }
}
