using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_53._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            foreach (int n in numbers) { Console.WriteLine(n); }

            Console.WriteLine("\n-------------------------------------------\n");

            Library_1 library_1 = new Library_1();
            foreach (Book b in library_1) { Console.WriteLine(b.Name); }

            Console.WriteLine("\n-------------------------------------------\n");

            Library_2 library_2 = new Library_2();
            foreach (Book b in library_2.GetBooks(5)) { Console.WriteLine(b.Name); }

            Console.ReadKey();
        }
    }

    class Numbers
    {
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < 6; i++) { yield return i * i; }
        }
    }

    class Book
    {
        public string Name { get; set; }
        public Book(string name) { this.Name = name; }
    }

    class Library_1
    {
        private Book[] books;

        public Library_1() { books = new Book[] { new Book("Sherlock Holmes"), new Book("Via la France"), new Book("I am legend") }; }

        public int Length { get { return books.Length; } }

        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < books.Length; i++) { yield return books[i]; }
        }
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

        public IEnumerable GetBooks(int max)
        {
            for(int i = 0; i < max; i++)
            {
                if(i == books.Length) { yield break; }
                else { yield return books[i]; }
            }
        }
    }
}
