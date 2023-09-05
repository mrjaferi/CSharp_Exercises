using System;

namespace BookLibraryCatalog
{
    class Program
    {
        static void Main()
        {
            Book[] libraryCatalog = new Book[]
            {
            new FictionBook("The Great Gatsby", "F. Scott Fitzgerald", 180, "Classic"),
            new FictionBook("Dune", "Frank Herbert", 412, "Science Fiction"),
            new NonFictionBook("Sapiens", "Yuval Noah Harari", 512, "History"),
            new NonFictionBook("Atomic Habits", "James Clear", 320, "Self-Help")
            };

            Library.DisplayBooks(libraryCatalog);
        }
    }

    class FictionBook : Book
    {
        public string Genre { get; set; }

        public FictionBook(string title, string author, int pages, string genre) : base(title, author, pages)
        {
            Genre = genre;
        }

        public override void GetAdditionalInfo()
        {
            Console.WriteLine($"Genre: {Genre}");
        }
    }

    class Library
    {
        public static void DisplayBooks(Book[] books)
        {
            foreach (var book in books)
            {
                Console.WriteLine("----------");
                book.DisplayBasicInfo();
                book.GetAdditionalInfo();
                Console.WriteLine("----------");
            }
        }
    }

    class NonFictionBook : Book
    {
        public string Topic { get; set; }

        public NonFictionBook(string title, string author, int pages, string topic) : base(title, author, pages)
        {
            Topic = topic;
        }

        public override void GetAdditionalInfo()
        {
            Console.WriteLine($"Topic: {Topic}");
        }
    }

    abstract class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public abstract void GetAdditionalInfo();

        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Pages: {Pages}");
        }
    }
}