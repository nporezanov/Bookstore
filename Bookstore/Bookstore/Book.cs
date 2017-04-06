using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
  public class Book:IComparable
    {
        public string Title; // Название.
        public string Author; // Автор.
        public decimal Price; // Цена.
        public bool CSharp; // Книга о C#

        public Book(string title, string author, decimal price, bool cSharp)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
            this.CSharp = cSharp;
        }
              

        public override string ToString()
        {
            return $"Название книги : {Title};\nАвтор : {Author};\nЦена: {Price};\nМетка С# : {CSharp}\n_________ ";
        }

        public int CompareTo(object obj)
        {
            Book book = obj as Book;
            if (book!= null) //&& book.CSharp = true - еще впихнуть условие чтобы только по С# фильтр.
            {
                if (this.Price > book.Price)
                    return -1;
                else if (this.Price < book.Price)
                    return 1;
                else return 0;
            }
            else
            {
                throw new Exception("Что-то пошло не так внутри IComparable"); 
            }
        }
    }
}
