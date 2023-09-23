using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day2
{


    internal class Book
    {
        public Book()
        {
            Console.WriteLine("BOOK Object Created...");
        }
        public Book(int x)
        {
            Console.WriteLine($"BOOK Object Created...{x}");
        }
        public void Open()
        {
            Console.WriteLine("Book is OPEN");
        }
        public void Open(int pageNo)
        {
            Console.WriteLine("Book is OPEN at Page " + pageNo);
        }
        public void Close()
        {
            Console.WriteLine("Book is CLOSED");
        }
    }
    public class BookTester
    {
        public static void BookObjectCreator()
        {
            //Book book = new Book();
            Book book = new Book(1);
            book.Open();
            book.Close();
        }
    }
}