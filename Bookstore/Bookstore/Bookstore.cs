using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{

    public class Bookstore<T> : IEnumerable, IEnumerator, IComparable
    {      
            List<T> library;
            int index = -1;

        public Bookstore()
        {
        }
        public Bookstore(List<T> _library)
        {
            this.library = new List<T>();
            this.library = _library;
        }
        public IEnumerator GetEnumerator()
            {
                return this;
            }
            public object Current
            {
                get
                {

                return library[index];
                }
            }

            public bool MoveNext()
            {
                if (index == library.Capacity - 1)
                { Reset(); return false; }
                index++;
                return true;
            }

            public void Reset()
            {
                index = -1;
            }
        public void AddBook<X>(T book) where X:Book
        {
            this.library.Add(book);
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
        public void ProcessBooks(ProcessBookDelegate processBook)
        {

        }
    }
}
