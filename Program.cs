

using BOOKSTORE;
using System;

class Program
{
    static void Main()
    {
        using (var context = new ReadMoreContext())
        {
            Console.WriteLine("Creating database...");

           
            bool isCreated = context.Database.EnsureCreated();

            if (isCreated)
            {
                Console.WriteLine("Database  ReadMoreBooksDB Created Successfully!");
            }
            else
            {
                Console.WriteLine("Database already exists.");
            }
        }
    }
}