using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{

    public class Bookstore<T> : IEnumerable, IEnumerator
    {      
            T[] library;
            int index = -1;
        int ind1 = 0;   

        public Bookstore()
        {
        }
        public Bookstore(T[] _library)
        {
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
                if (index == library.Length - 1)
                { Reset(); return false; }
                index++;
                return true;
            }

            public void Reset()
            {
                index = -1;
            }
        public void AddBook(T t)
        {
            if (ind1==library.Length)
            {
                library.a= library.Length + 1;
            }
            library[ind1] = t;
            ind1++;
        }
    }
}
