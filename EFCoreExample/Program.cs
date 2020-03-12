using System;

namespace EFCoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void ListAll()
        {
            using (var db = new AppDbContext())
            {
                foreach (var book in db.Books.AsQueryable()) 
                {
                    var webUrl = book.Author.WebUrl == null? "No web URL given": book.Author.WebUrl;
                    Console.WriteLine($"{book.Title} by {book.Author.Name}");
                    Console.WriteLine($"Published on {book.PublishedOn:dd-MMM-yyyy}. {webUrl}");

                }
            }
        }
    }
}
