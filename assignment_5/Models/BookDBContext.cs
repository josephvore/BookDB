using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_5.Models
{
    //DBContext File has been created
    public class BookDBContext : DbContext
    {
        public BookDBContext (DbContextOptions<BookDBContext> options) : base (options)
        {

        }

        public DbSet <Book> Books { get; set; }
    }
}
