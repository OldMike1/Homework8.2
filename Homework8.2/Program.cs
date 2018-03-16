using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8._2
{
    public struct Book
    {
        public int Id;
        public string Autor;
        public string Title;
        public int Count;

        public string GetString()
        {
            return "ID : " + Id + " Author : " + Autor + " Title : " + Title + " Count books : " + Count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Book №" + i);

                Console.Write("Enter ID ");
                int IdBook = int.Parse(Console.ReadLine());
                Console.Write("Enter Autor ");
                string AutorBook = Console.ReadLine();
                Console.Write("Enter Title ");
                string TitleBook = Console.ReadLine();
                Console.Write("Enter Count ");
                int CountBook = int.Parse(Console.ReadLine());

                Book book = new Book();
                book.Id = IdBook;
                book.Autor = AutorBook;
                book.Title = TitleBook;
                book.Count = CountBook;

                books.Add(book);
            }


            for (int j = 0; j < books.Count; j++)
            {
                Console.WriteLine(books[j].GetString());
            }



        }
    }
}
