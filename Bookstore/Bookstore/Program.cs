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
Интерфейс для реализации сортировки IComparable.
*/

namespace Bookstore
{
    class Program
    {        
        
        static void Main(string[] args)
        {
            #region Инициализируем книжки
            Book st1 = new Book("7е издание С#","Э.Троелсен",2525,true);
            Book st2 = new Book("CLR via C#", "Джеффри Рихтер", 499, true);
            Book st3 = new Book("Гений", "Теодор Драйзер", 196, false);
            Book st4 = new Book("Остров сокровищ", "Роберт Стивенсон", 551, false);
            #endregion
            //Console.WriteLine(st1);
            //Console.WriteLine(st1.Author);
            #region создание списка книг и метода Add
            Book[] bang = new []  { st4, st3, st2, st1 };
            //List<Book> allbooks = new List<Book>();
            //Console.WriteLine("Выводим содержимое списка книг 1й раз:\n");
            //foreach (var el in allbooks) Console.WriteLine(el);
            //Console.WriteLine(allbooks.Capacity);
            //allbooks.Add(st1);
            //allbooks.Add(st3);
            //Console.WriteLine("Выводим содержимое списка, дополненного книгами:\n");
            //foreach (var el in allbooks) Console.WriteLine(el);
            //Console.WriteLine(allbooks.Capacity);
            //Bookstore<Book> bankbooks = new Bookstore<Book>(allbooks);
            //bankbooks.AddBook<Book>(new Book("Остров сокровищ", "Роберт Стивенсон", 551, false));
            //bankbooks.AddBook<Book>(st2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Проверка добавления методом AddBook:\n");
            foreach (var el in bang) Console.WriteLine(el);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion

            #region Реализация сортировки
            Array.Sort(bang);
            Console.WriteLine("Вывод результата сортировки:");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach (var el in bang) Console.WriteLine(el);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion



            Console.ReadKey();
            
    }
}
}
