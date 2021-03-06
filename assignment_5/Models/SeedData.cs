﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDBContext>();

            //Checks to see if there are any pending migrations and gets them
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }


            //Creates new Book objects in given range
            //NumberOfPages added on each book
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    
                    new Book
                    {
                        Title = "Les Miserables",
                        Publisher = "Signet",
                        AuthorFirst = "Victor",
                        AuthorMiddle = "",
                        AuthorLast = "Hugo",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95m,
                        NumberOfPages = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        Publisher = "Simon & Schuster",
                        AuthorFirst = "Doris",
                        AuthorMiddle = "Kearns",
                        AuthorLast = "Goodwin",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58m,
                        NumberOfPages = 944
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        Publisher = "Bantam",
                        AuthorFirst = "Alice",
                        AuthorMiddle = "",
                        AuthorLast = "Schroeder",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54m,
                        NumberOfPages = 832
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        Publisher = "Random House",
                        AuthorFirst = "Ronald",
                        AuthorMiddle = "C.",
                        AuthorLast = "White",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61m,
                        NumberOfPages = 864
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        Publisher = "Random House",
                        AuthorFirst = "Laura",
                        AuthorMiddle = "",
                        AuthorLast = "Hillenbrand",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33m,
                        NumberOfPages = 528
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        Publisher = "Vintage",
                        AuthorFirst = "Michael",
                        AuthorMiddle = "",
                        AuthorLast = "Crichton",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = " Historical Fiction",
                        Price = 15.95m,
                        NumberOfPages = 288
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        Publisher = "Grand Central Publishing",
                        AuthorFirst = "Cal",
                        AuthorMiddle = "",
                        AuthorLast = "Newport",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99m,
                        NumberOfPages = 304
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        Publisher = "Grand Central Publishing",
                        AuthorFirst = "Michael",
                        AuthorMiddle = "",
                        AuthorLast = "Abrashoff",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66m,
                        NumberOfPages = 240
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        Publisher = "Portfolio",
                        AuthorFirst = "Richard",
                        AuthorMiddle = "",
                        AuthorLast = "Branson",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16m,
                        NumberOfPages = 400
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        Publisher = "Bantam",
                        AuthorFirst = "John",
                        AuthorMiddle = "",
                        AuthorLast = "Grisham",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03m,
                        NumberOfPages = 642
                    },

                    //  After you have incorporated the Pagination, add three of your own favorite books to the
                    //  SeedData, and rebuild the database to test that the Pagination works as it should.

                    new Book
                    {
                        Title = "Midnight in Chernobyl",
                        Publisher = "Simon & Schuster",
                        AuthorFirst = "Adam",
                        AuthorMiddle = "",
                        AuthorLast = "Higginbotham",
                        ISBN = "978-1501134616",
                        Classification = "Non-Fiction",
                        Category = "Disasters",
                        Price = 19.00m,
                        NumberOfPages = 560
                    },

                    new Book
                    {
                        Title = "The Way of Kings",
                        Publisher = "Tor Books",
                        AuthorFirst = "Brandon",
                        AuthorMiddle = "",
                        AuthorLast = "Sanderson",
                        ISBN = "978-0765326355",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        Price = 18.23m,
                        NumberOfPages = 1007
                    },

                    new Book
                    {
                        Title = "Words of Radiance",
                        Publisher = "Tor Books",
                        AuthorFirst = "Brandon",
                        AuthorMiddle = "",
                        AuthorLast = "Sanderson",
                        ISBN = "978-0765326362",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        Price = 19.05m,
                        NumberOfPages = 1087
                    }

                );

                //Saves the changes in the context object
                context.SaveChanges();
            }
        }
    }
}
