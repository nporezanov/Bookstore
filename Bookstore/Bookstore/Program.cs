using System;
using System.Collections;
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
        
        static void Main(string[] args)
        {
            Book st1 = new Book("7е издание С#","Э.Троелсен",2525,true);
            Book st2 = new Book("CLR via C#", "Джеффри Рихтер", 499, true);
            Book st3 = new Book("Гений", "Теодор Драйзер", 196, false);
            Book st4 = new Book("Остров сокровищ", "Роберт Стивенсон", 551, false);
           
            //Console.WriteLine(st1);
            //Console.WriteLine(st1.Author);

            //Console.ReadKey();



            // Bank<int> bank = new Bank<int>(new int[] { 1, 2, 4, 5, 6 });
            //Book [] bank2 = new  Book [] { st1,st2,st1 };
            //bank2.Last(new Book);           

            //foreach (var el in bank2) Console.WriteLine(el);
            Bookstore<Book> bank2 = new Bookstore<Book>(new Book[] { st1, st2, st1 });
            foreach (var el in bank2) Console.WriteLine(el);
            

            Console.ReadKey();
            bank2.AddBook(st1);

    }
}
}
