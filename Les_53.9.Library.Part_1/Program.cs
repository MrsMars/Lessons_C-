using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_53._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Library_1 library_1 = new Library_1();
            foreach (Book b in library_1) { Console.WriteLine(b.Name); }

            Console.WriteLine("\n--------------------------------------------------\n");
            Library_2 library_2 = new Library_2();
            foreach (Book b in library_2) { Console.WriteLine(b.Name); }

            Console.ReadLine();
        }
    }

    class Book
    {
        public Book(string name) { this.Name = name; }

        public string Name { get; set; }
    }

    class Library_1 : IEnumerable
    {
        private Book[] books;

        public Library_1(){ books = new Book[] { new Book("Sherlock Holmes"), new Book("Via la France"), new Book("I am legend") }; }

        public int Length { get { return books.Length; } }

        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        // return IEnumerator
        IEnumerator IEnumerable.GetEnumerator() { return books.GetEnumerator(); }
    }
    // or
    class Library_2
    {
        private Book[] books;

        public Library_2() { books = new Book[] { new Book("Sherlock Holmes"), new Book("Via la France"), new Book("I am legend") }; }

        public int Length { get { return books.Length; } }

        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        public IEnumerator GetEnumerator() { return books.GetEnumerator(); }
    }
}
