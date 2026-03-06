using System;
using BookstoreSystem.Contexts;

namespace BookstoreSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BookstoreDbContext())
            {
                Console.WriteLine("BookstoreDB context created successfully.");
            }
        }
    }
}
