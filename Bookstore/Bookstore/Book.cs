using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
  public class Book
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
    }
}
