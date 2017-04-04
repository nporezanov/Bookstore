using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Порезанов Николай. Домашнее задание №3.(04.04.2017)
/*Разработать класс описывающий библиотеку, Bookstore.
Класс должен поддерживать возможность добавлять книги в библиотеку, метод AddBook,
и обрабатывать книги, метод ProcessBooks(ProcessBookDelegate processBook). 
Книги в библиотеке имеют следующие атрибуты:
public string Title; // Название.
public string Author; // Автор.
public decimal Price; // Цена.
public bool CSharp; // Книга о C#
Используя делегат public delegate void ProcessBookDelegate(Book book) 
1) распечатать названия всех книг о С# отсортировав их по убыванию цены в консоли
2) вычислить и отобразить общую стоимость всех книг о С# в консоли
3) вычислить и отобразить среднюю стоимость книг о С# в консоли.
Расчет общей и средней стоимости реализовать в отдельном классе.
Интерфейс для реализации сортировки IComparable.*/

namespace Bookstore
{
    class Program
    {
        class Bank<T>
        {
            T[] clients;

            public Bank()
            {
            }
            public Bank(T[] _clients)
            {
                this.clients = _clients;
            }
            public override string ToString()
            {
                return T.ToString();
            }
        }
        static void Main(string[] args)
        {
            Book st1 = new Book("7е издание С#","Э.Троелсен",2525,true);
            Book st2 = new Book("CLR via C#", "Джеффри Рихтер", 499, true);
            //Console.WriteLine(st1);
            //Console.WriteLine(st1.Author);

            //Console.ReadKey();



           // Bank<int> bank = new Bank<int>(new int[] { 1, 2, 4, 5, 6 });
        Bank<string> bank2 = new Bank<string>(new string[] { "13433", "342454", "21432" });
            Bank<Book> bank = new Bank<Book>(new Book[] { st1,st2});
            Console.WriteLine(bank);
            Console.WriteLine(bank2);
            Console.ReadLine();

    }
}
}
